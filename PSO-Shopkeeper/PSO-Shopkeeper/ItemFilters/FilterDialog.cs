using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PSOShopkeeperLib.Item;
using PSOShopkeeperLib.JSON;

namespace PSOShopkeeper.ItemFilters
{
    public partial class FilterDialog : Form
    {
        public FilterDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the results of the dialog
        /// </summary>
        public IEnumerable<string> Results { get { return _results; } }

        /// <summary>
        /// Gets the string indicating if the previous results are valid
        /// </summary>
        public bool Valid { get { return _valid; } }

        /// <summary>
        /// Gets a flag indicating if the filter was inverted
        /// </summary>
        public bool Inverted { get { return _invertFilterBox.Checked; } }

        /// <summary>
        /// Specifies the form's base height with no arguments
        /// </summary>
        private const int formBaseHeight = 200;

        /// <summary>
        /// Specifies the Ok/Cancel buttons offsets from the bottom of the dialog
        /// </summary>
        private const int dialogButtonOffsets = -67;

        /// <summary>
        /// Specifies The height of an arg
        /// </summary>
        private const int argHeight = 100;

        /// <summary>
        /// Specifies the y offset of an args text box
        /// </summary>
        private const int argTextBoxOffset = 30;

        /// <summary>
        /// Contains the current filter
        /// </summary>
        private IItemFilter _filter = null;

        /// <summary>
        /// Contains the results of the dialog
        /// </summary>
        private List<string> _results = new List<string>();

        /// <summary>
        /// Contains a flag indicating if the arg results are valid
        /// </summary>
        private bool _valid = true;

        /// <summary>
        /// Contains the dynamic labels for the names of all args
        /// </summary>
        private List<Label> _argLabels = new List<Label>();

        /// <summary>
        /// Contains the dynamic text boxes for all args
        /// </summary>
        private List<Control> _argTextBoxes = new List<Control>();

        /// <summary>
        /// Contains the dynamic labels for the descriptions of all args
        /// </summary>
        private List<Label> _argDescriptions = new List<Label>();

        /// <summary>
        /// Specifies valid strings for comparison arguments
        /// </summary>
        private readonly List<string> comparisonStrings = new List<string> { "=", ">", "<", ">=", "<=" };

        /// <summary>
        /// Sets up the dialog to show based on the filter passed
        /// </summary>
        /// <param name="filter">The filter to setup for</param>
        public void SetFilter(IItemFilter filter)
        {
            clearPreviousArgs();
            _filter = filter;
            _filterName.Text = filter.DisplayName;
            _filterDescription.Text = filter.Description;

            // Allocate dynamic controls for all args
            for (int i = 0; i < filter.Args.Length; i++)
            {
                addArg(i);
            }
        }

        /// <summary>
        /// Adds an arg to the list of args
        /// </summary>
        /// <param name="i">The index of the arg to add</param>
        private void addArg(int i)
        {
            // Allocate arg name
            Label name = new Label();
            name.Name = "ArgLabel" + i;
            name.Text = _filter.Args[i].Name + " (" + Enum.GetName(typeof(FilterArgType), _filter.Args[i].Type) + ")";
            name.AutoSize = true;
            name.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            name.Text += ": ";
            name.Location = new Point(_filterName.Location.X, i * argHeight);
            _argLabels.Add(name);
            _argsPanel.Controls.Add(name);

            //  Allocate arg text box
            Control argValue = null;

            if (_filter.Args[i].Type == FilterArgType.Number)
            {
                argValue = new TextBox();
                argValue.Text = "0";
            }
            else
            {
                ComboBox combo = new ComboBox();
                argValue = combo;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                combo.AutoCompleteMode = AutoCompleteMode.Append;

                if (_filter.Args[i].Type == FilterArgType.Comparison)
                {
                    foreach (string value in comparisonStrings)
                    {
                        combo.Items.Add(value);
                        combo.AutoCompleteCustomSource.Add(value);
                    }
                }
                else if (_filter.Args[i].Type == FilterArgType.ItemName)
                {
                    foreach (KeyValuePair<string, ItemJSON> kvp in ItemDatabaseJSON.Instance.Database)
                    {
                        combo.Items.Add(kvp.Value.Name);
                        combo.AutoCompleteCustomSource.Add(kvp.Value.Name);
                    }
                }
                else if (_filter.Args[i].Type == FilterArgType.Special)
                {
                    foreach (SpecialType special in Enum.GetValues(typeof(SpecialType)))
                    {
                        combo.Items.Add(Enum.GetName(typeof(SpecialType), special));
                        combo.AutoCompleteCustomSource.Add(Enum.GetName(typeof(SpecialType), special));
                    }
                }

                combo.SelectedIndex = 0;
            }

            argValue.Name = "ArgText" + i;
            argValue.Location = new Point(_filterName.Location.X, i * argHeight + argTextBoxOffset);
            _argTextBoxes.Add(argValue);
            _argsPanel.Controls.Add(argValue);
            argValue.TextChanged += onArgTextChanged;
            _results.Add(argValue.Text);

            // Allocate arg description
            Label description = new Label();
            description.Name = "ArgDescription" + i;
            description.Text = _filter.Args[i].Description;
            description.AutoSize = true;
            description.Location = new Point(_filterName.Location.X + name.Size.Width, i * argHeight);
            _argDescriptions.Add(description);
            _argsPanel.Controls.Add(description);
        }

        /// <summary>
        /// Clears args from previous iterations
        /// </summary>
        private void clearPreviousArgs()
        {
            for (int i = 0; i < _argLabels.Count; i++)
            {
                _argsPanel.Controls.Remove(_argLabels[i]);
                _argLabels[i].Dispose();
                _argsPanel.Controls.Remove(_argTextBoxes[i]);
                _argTextBoxes[i].Dispose();
                _argsPanel.Controls.Remove(_argDescriptions[i]);
                _argDescriptions[i].Dispose();
            }

            _results.Clear();
            _argLabels.Clear();
            _argTextBoxes.Clear();
            _argDescriptions.Clear();
            _invertFilterBox.Checked = false;
        }

        /// <summary>
        /// Validates all text box arguments
        /// </summary>
        private void validateTextBoxes()
        {
            _valid = true;
            for (int i = 0; i < _results.Count; i++)
            {
                _results[i] = _argTextBoxes[i].Text;

                if (_filter.Args[i].Type == FilterArgType.Number)
                {
                    int n;
                    if (!int.TryParse(_argTextBoxes[i].Text, out n))
                    {
                        _valid = false;
                        _argTextBoxes[i].BackColor = Color.Pink;
                    }
                    else
                    {
                        _argTextBoxes[i].BackColor = Color.White;
                    }
                }
                else if (_filter.Args[i].Type == FilterArgType.Comparison)
                {
                    if ((_argTextBoxes[i].Text != "=") && (_argTextBoxes[i].Text != ">") && (_argTextBoxes[i].Text != "<") &&
                        (_argTextBoxes[i].Text != ">=") && (_argTextBoxes[i].Text != "<="))
                    {
                        _valid = false;
                        _argTextBoxes[i].BackColor = Color.Pink;
                    }
                    else
                    {
                        _argTextBoxes[i].BackColor = Color.White;
                    }
                }
                else if (_filter.Args[i].Type == FilterArgType.ItemName)
                {
                    if (ItemDatabase.Instance.FindItem(_argTextBoxes[i].Text, ItemDatabase.Category.All, ItemDatabase.SearchType.ByName).Count == 0)
                    {
                        _valid = false;
                        _argTextBoxes[i].BackColor = Color.Pink;
                    }
                    else
                    {
                        _argTextBoxes[i].BackColor = Color.White;
                    }
                }
                else if (_filter.Args[i].Type == FilterArgType.Special)
                {
                    SpecialType special = SpecialType.None;
                    if (!Enum.TryParse(_argTextBoxes[i].Text.Trim(), true, out special))
                    {
                        _valid = false;
                        _argTextBoxes[i].BackColor = Color.Pink;
                    }
                    else
                    {
                        _argTextBoxes[i].BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Data binding for text changed on an arg text box
        /// </summary>
        /// <param name="sender">The control initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onArgTextChanged(object sender, EventArgs e)
        {
            validateTextBoxes();
        }

        /// <summary>
        /// Data binding for dialog load
        /// </summary>
        /// <param name="sender">The control initiating the event (unused)</param>
        /// <param name="e">The event args (unused)</param>
        private void onDialogLoad(object sender, EventArgs e)
        {
            if (_argTextBoxes.Count > 0)
            {
                this.ActiveControl = _argTextBoxes[0];
            }
        }
    }
}
