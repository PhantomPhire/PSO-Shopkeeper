namespace PSOShopkeeper
{
    partial class PSOShopkeeperItemList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSOShopkeeperItemList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._itemListBGPanel = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._itemListTitleBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this._itemListTitle = new System.Windows.Forms.Label();
            this._itemInfoTitleBG = new PSOShopkeeper.Controls.DoubleBufferedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this._itemInformationPanel = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._itemInformationLabel = new System.Windows.Forms.Label();
            this._clearItemsButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._unpricedButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._savePricingButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this.label3 = new System.Windows.Forms.Label();
            this._addItemsButton = new PSOShopkeeper.Controls.PSOShopkeeperButton();
            this._itemSearchBar = new System.Windows.Forms.TextBox();
            this._itemListPanelBG = new PSOShopkeeper.Controls.PSOShopkeeperPanel();
            this._itemListPanel = new PSOShopkeeper.Controls.TransparentDataGridView();
            this._itemContextMenu = new PSOShopkeeper.Controls.PSOContextMenu(this.components);
            this._cutCells = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._copyCells = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._pasteCells = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._headerContextMenuBasic = new PSOShopkeeper.Controls.PSOContextMenu(this.components);
            this._clearColumnButton = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._headerContextMenuPDs = new PSOShopkeeper.Controls.PSOContextMenu(this.components);
            this._sumItemsToolStripMenuItem = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._clearColumnToolStripMenuItem = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._headerContextMenuMeseta = new PSOShopkeeper.Controls.PSOContextMenu(this.components);
            this._autofillToolStripMenuItem1 = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._clearColumnsToolStripMenuItem = new PSOShopkeeper.Controls.PSOContextMenuItem();
            this._itemListBGPanel.SuspendLayout();
            this._itemListTitleBG.SuspendLayout();
            this._itemInfoTitleBG.SuspendLayout();
            this._itemInformationPanel.SuspendLayout();
            this._itemListPanelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).BeginInit();
            this._itemContextMenu.SuspendLayout();
            this._headerContextMenuBasic.SuspendLayout();
            this._headerContextMenuPDs.SuspendLayout();
            this._headerContextMenuMeseta.SuspendLayout();
            this.SuspendLayout();
            // 
            // _itemListBGPanel
            // 
            this._itemListBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._itemListBGPanel.BackColor = System.Drawing.Color.Transparent;
            this._itemListBGPanel.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Shop_BG;
            this._itemListBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemListBGPanel.Controls.Add(this._itemListTitleBG);
            this._itemListBGPanel.Controls.Add(this._itemInfoTitleBG);
            this._itemListBGPanel.Controls.Add(this._itemInformationPanel);
            this._itemListBGPanel.Controls.Add(this._clearItemsButton);
            this._itemListBGPanel.Controls.Add(this._unpricedButton);
            this._itemListBGPanel.Controls.Add(this._savePricingButton);
            this._itemListBGPanel.Controls.Add(this.label3);
            this._itemListBGPanel.Controls.Add(this._addItemsButton);
            this._itemListBGPanel.Controls.Add(this._itemSearchBar);
            this._itemListBGPanel.Controls.Add(this._itemListPanelBG);
            this._itemListBGPanel.Location = new System.Drawing.Point(0, 0);
            this._itemListBGPanel.Name = "_itemListBGPanel";
            this._itemListBGPanel.Size = new System.Drawing.Size(1350, 650);
            this._itemListBGPanel.TabIndex = 7;
            // 
            // _itemListTitleBG
            // 
            this._itemListTitleBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_2;
            this._itemListTitleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemListTitleBG.Controls.Add(this._itemListTitle);
            this._itemListTitleBG.Location = new System.Drawing.Point(31, 56);
            this._itemListTitleBG.Name = "_itemListTitleBG";
            this._itemListTitleBG.Size = new System.Drawing.Size(107, 45);
            this._itemListTitleBG.TabIndex = 8;
            // 
            // _itemListTitle
            // 
            this._itemListTitle.AutoSize = true;
            this._itemListTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemListTitle.Location = new System.Drawing.Point(23, 12);
            this._itemListTitle.Name = "_itemListTitle";
            this._itemListTitle.Size = new System.Drawing.Size(66, 23);
            this._itemListTitle.TabIndex = 0;
            this._itemListTitle.Text = "Items";
            // 
            // _itemInfoTitleBG
            // 
            this._itemInfoTitleBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._itemInfoTitleBG.BackgroundImage = global::PSO_Shopkeeper.Properties.Resources.Title_BG_3;
            this._itemInfoTitleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemInfoTitleBG.Controls.Add(this.label4);
            this._itemInfoTitleBG.Location = new System.Drawing.Point(1035, 6);
            this._itemInfoTitleBG.Name = "_itemInfoTitleBG";
            this._itemInfoTitleBG.Size = new System.Drawing.Size(219, 45);
            this._itemInfoTitleBG.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item Information";
            // 
            // _itemInformationPanel
            // 
            this._itemInformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._itemInformationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_itemInformationPanel.BackgroundImage")));
            this._itemInformationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemInformationPanel.Controls.Add(this._itemInformationLabel);
            this._itemInformationPanel.Location = new System.Drawing.Point(1007, -15);
            this._itemInformationPanel.Name = "_itemInformationPanel";
            this._itemInformationPanel.Size = new System.Drawing.Size(338, 639);
            this._itemInformationPanel.TabIndex = 6;
            this._itemInformationPanel.TitleText = "Item Information";
            // 
            // _itemInformationLabel
            // 
            this._itemInformationLabel.AutoSize = true;
            this._itemInformationLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemInformationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this._itemInformationLabel.Location = new System.Drawing.Point(25, 79);
            this._itemInformationLabel.Name = "_itemInformationLabel";
            this._itemInformationLabel.Size = new System.Drawing.Size(0, 16);
            this._itemInformationLabel.TabIndex = 0;
            // 
            // _clearItemsButton
            // 
            this._clearItemsButton.Active = false;
            this._clearItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._clearItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._clearItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._clearItemsButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._clearItemsButton.ForeColor = System.Drawing.Color.White;
            this._clearItemsButton.Location = new System.Drawing.Point(878, 598);
            this._clearItemsButton.Name = "_clearItemsButton";
            this._clearItemsButton.Size = new System.Drawing.Size(108, 45);
            this._clearItemsButton.TabIndex = 2;
            this._clearItemsButton.Text = "Clear Items";
            this._clearItemsButton.UseVisualStyleBackColor = true;
            this._clearItemsButton.Click += new System.EventHandler(this.onClearItemsClicked);
            // 
            // _unpricedButton
            // 
            this._unpricedButton.Active = false;
            this._unpricedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._unpricedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._unpricedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._unpricedButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._unpricedButton.ForeColor = System.Drawing.Color.White;
            this._unpricedButton.Location = new System.Drawing.Point(901, 9);
            this._unpricedButton.Name = "_unpricedButton";
            this._unpricedButton.Size = new System.Drawing.Size(85, 70);
            this._unpricedButton.TabIndex = 4;
            this._unpricedButton.Text = "Show Unpriced Items Only";
            this._unpricedButton.UseVisualStyleBackColor = true;
            this._unpricedButton.Click += new System.EventHandler(this.onUpricedButtonClicked);
            // 
            // _savePricingButton
            // 
            this._savePricingButton.Active = false;
            this._savePricingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._savePricingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._savePricingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._savePricingButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._savePricingButton.ForeColor = System.Drawing.Color.White;
            this._savePricingButton.Location = new System.Drawing.Point(765, 599);
            this._savePricingButton.Name = "_savePricingButton";
            this._savePricingButton.Size = new System.Drawing.Size(108, 45);
            this._savePricingButton.TabIndex = 2;
            this._savePricingButton.Text = "Save Prices";
            this._savePricingButton.UseVisualStyleBackColor = true;
            this._savePricingButton.Click += new System.EventHandler(this.onSavePricesClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search";
            // 
            // _addItemsButton
            // 
            this._addItemsButton.Active = false;
            this._addItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._addItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addItemsButton.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this._addItemsButton.ForeColor = System.Drawing.Color.White;
            this._addItemsButton.Location = new System.Drawing.Point(655, 599);
            this._addItemsButton.Name = "_addItemsButton";
            this._addItemsButton.Size = new System.Drawing.Size(104, 45);
            this._addItemsButton.TabIndex = 1;
            this._addItemsButton.Text = "Add Items";
            this._addItemsButton.UseVisualStyleBackColor = true;
            this._addItemsButton.Click += new System.EventHandler(this.onAddItemsClicked);
            // 
            // _itemSearchBar
            // 
            this._itemSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._itemSearchBar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemSearchBar.Location = new System.Drawing.Point(74, 9);
            this._itemSearchBar.Name = "_itemSearchBar";
            this._itemSearchBar.Size = new System.Drawing.Size(798, 26);
            this._itemSearchBar.TabIndex = 3;
            this._itemSearchBar.TextChanged += new System.EventHandler(this.onItemSearchBarTextChanged);
            // 
            // _itemListPanelBG
            // 
            this._itemListPanelBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._itemListPanelBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_itemListPanelBG.BackgroundImage")));
            this._itemListPanelBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemListPanelBG.Controls.Add(this._itemListPanel);
            this._itemListPanelBG.Location = new System.Drawing.Point(2, 49);
            this._itemListPanelBG.Name = "_itemListPanelBG";
            this._itemListPanelBG.Size = new System.Drawing.Size(999, 539);
            this._itemListPanelBG.TabIndex = 8;
            this._itemListPanelBG.TitleText = "Items";
            // 
            // _itemListPanel
            // 
            this._itemListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._itemListPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._itemListPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._itemListPanel.DefaultCellStyle = dataGridViewCellStyle5;
            this._itemListPanel.EnableHeadersVisualStyles = false;
            this._itemListPanel.Location = new System.Drawing.Point(18, 58);
            this._itemListPanel.Name = "_itemListPanel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._itemListPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._itemListPanel.Size = new System.Drawing.Size(978, 458);
            this._itemListPanel.TabIndex = 0;
            this._itemListPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onItemCellClicked);
            this._itemListPanel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.onCellRightClicked);
            this._itemListPanel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellChanged);
            this._itemListPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onCellKeyPressed);
            // 
            // _itemContextMenu
            // 
            this._itemContextMenu.BackColor = System.Drawing.Color.Transparent;
            this._itemContextMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_itemContextMenu.BackgroundImage")));
            this._itemContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemContextMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._itemContextMenu.ForeColor = System.Drawing.Color.White;
            this._itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cutCells,
            this._copyCells,
            this._pasteCells});
            this._itemContextMenu.Name = "_itemContextMenu";
            this._itemContextMenu.ShowImageMargin = false;
            this._itemContextMenu.Size = new System.Drawing.Size(84, 70);
            // 
            // _cutCells
            // 
            this._cutCells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cutCells.Image = ((System.Drawing.Image)(resources.GetObject("_cutCells.Image")));
            this._cutCells.Name = "_cutCells";
            this._cutCells.Size = new System.Drawing.Size(83, 22);
            this._cutCells.Text = "Cut";
            this._cutCells.Click += new System.EventHandler(this.onCutClicked);
            // 
            // _copyCells
            // 
            this._copyCells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._copyCells.Image = ((System.Drawing.Image)(resources.GetObject("_copyCells.Image")));
            this._copyCells.Name = "_copyCells";
            this._copyCells.Size = new System.Drawing.Size(83, 22);
            this._copyCells.Text = "Copy";
            this._copyCells.Click += new System.EventHandler(this.onCopyClicked);
            // 
            // _pasteCells
            // 
            this._pasteCells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pasteCells.Image = ((System.Drawing.Image)(resources.GetObject("_pasteCells.Image")));
            this._pasteCells.Name = "_pasteCells";
            this._pasteCells.Size = new System.Drawing.Size(83, 22);
            this._pasteCells.Text = "Paste";
            this._pasteCells.Click += new System.EventHandler(this.onPasteClicked);
            // 
            // _headerContextMenuBasic
            // 
            this._headerContextMenuBasic.BackColor = System.Drawing.Color.Transparent;
            this._headerContextMenuBasic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_headerContextMenuBasic.BackgroundImage")));
            this._headerContextMenuBasic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._headerContextMenuBasic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headerContextMenuBasic.ForeColor = System.Drawing.Color.White;
            this._headerContextMenuBasic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clearColumnButton});
            this._headerContextMenuBasic.Name = "_headerContextMenuBasic";
            this._headerContextMenuBasic.ShowImageMargin = false;
            this._headerContextMenuBasic.Size = new System.Drawing.Size(130, 26);
            // 
            // _clearColumnButton
            // 
            this._clearColumnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._clearColumnButton.Image = ((System.Drawing.Image)(resources.GetObject("_clearColumnButton.Image")));
            this._clearColumnButton.Name = "_clearColumnButton";
            this._clearColumnButton.Size = new System.Drawing.Size(129, 22);
            this._clearColumnButton.Text = "Clear Column";
            this._clearColumnButton.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // _headerContextMenuPDs
            // 
            this._headerContextMenuPDs.BackColor = System.Drawing.Color.Transparent;
            this._headerContextMenuPDs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_headerContextMenuPDs.BackgroundImage")));
            this._headerContextMenuPDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._headerContextMenuPDs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headerContextMenuPDs.ForeColor = System.Drawing.Color.White;
            this._headerContextMenuPDs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._sumItemsToolStripMenuItem,
            this._clearColumnToolStripMenuItem});
            this._headerContextMenuPDs.Name = "_headerContextMenuPDs";
            this._headerContextMenuPDs.ShowImageMargin = false;
            this._headerContextMenuPDs.Size = new System.Drawing.Size(130, 48);
            // 
            // _sumItemsToolStripMenuItem
            // 
            this._sumItemsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._sumItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_sumItemsToolStripMenuItem.Image")));
            this._sumItemsToolStripMenuItem.Name = "_sumItemsToolStripMenuItem";
            this._sumItemsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this._sumItemsToolStripMenuItem.Text = "Sum Items";
            this._sumItemsToolStripMenuItem.Click += new System.EventHandler(this.onSumItemsClicked);
            // 
            // _clearColumnToolStripMenuItem
            // 
            this._clearColumnToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._clearColumnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_clearColumnToolStripMenuItem.Image")));
            this._clearColumnToolStripMenuItem.Name = "_clearColumnToolStripMenuItem";
            this._clearColumnToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this._clearColumnToolStripMenuItem.Text = "Clear Column";
            this._clearColumnToolStripMenuItem.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // _headerContextMenuMeseta
            // 
            this._headerContextMenuMeseta.BackColor = System.Drawing.Color.Transparent;
            this._headerContextMenuMeseta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_headerContextMenuMeseta.BackgroundImage")));
            this._headerContextMenuMeseta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._headerContextMenuMeseta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headerContextMenuMeseta.ForeColor = System.Drawing.Color.White;
            this._headerContextMenuMeseta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._autofillToolStripMenuItem1,
            this._clearColumnsToolStripMenuItem});
            this._headerContextMenuMeseta.Name = "_headerContextMenuMeseta";
            this._headerContextMenuMeseta.ShowImageMargin = false;
            this._headerContextMenuMeseta.Size = new System.Drawing.Size(136, 48);
            // 
            // _autofillToolStripMenuItem1
            // 
            this._autofillToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._autofillToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("_autofillToolStripMenuItem1.Image")));
            this._autofillToolStripMenuItem1.Name = "_autofillToolStripMenuItem1";
            this._autofillToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this._autofillToolStripMenuItem1.Text = "Autofill";
            this._autofillToolStripMenuItem1.Click += new System.EventHandler(this.onAutofillClicked);
            // 
            // _clearColumnsToolStripMenuItem
            // 
            this._clearColumnsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._clearColumnsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_clearColumnsToolStripMenuItem.Image")));
            this._clearColumnsToolStripMenuItem.Name = "_clearColumnsToolStripMenuItem";
            this._clearColumnsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this._clearColumnsToolStripMenuItem.Text = "Clear Columns";
            this._clearColumnsToolStripMenuItem.Click += new System.EventHandler(this.onClearColumnClicked);
            // 
            // PSOShopkeeperItemList
            // 
            this.Controls.Add(this._itemListBGPanel);
            this.Name = "PSOShopkeeperItemList";
            this.Size = new System.Drawing.Size(1350, 651);
            this._itemListBGPanel.ResumeLayout(false);
            this._itemListBGPanel.PerformLayout();
            this._itemListTitleBG.ResumeLayout(false);
            this._itemListTitleBG.PerformLayout();
            this._itemInfoTitleBG.ResumeLayout(false);
            this._itemInfoTitleBG.PerformLayout();
            this._itemInformationPanel.ResumeLayout(false);
            this._itemInformationPanel.PerformLayout();
            this._itemListPanelBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._itemListPanel)).EndInit();
            this._itemContextMenu.ResumeLayout(false);
            this._headerContextMenuBasic.ResumeLayout(false);
            this._headerContextMenuPDs.ResumeLayout(false);
            this._headerContextMenuMeseta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PSOShopkeeper.Controls.DoubleBufferedPanel _itemListBGPanel;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _itemListTitleBG;
        private System.Windows.Forms.Label _itemListTitle;
        private PSOShopkeeper.Controls.DoubleBufferedPanel _itemInfoTitleBG;
        private System.Windows.Forms.Label label4;
        private PSOShopkeeper.Controls.PSOShopkeeperPanel _itemInformationPanel;
        private System.Windows.Forms.Label _itemInformationLabel;
        private Controls.PSOShopkeeperButton _clearItemsButton;
        private Controls.PSOShopkeeperButton _unpricedButton;
        private Controls.PSOShopkeeperButton _savePricingButton;
        private System.Windows.Forms.Label label3;
        private Controls.PSOShopkeeperButton _addItemsButton;
        private System.Windows.Forms.TextBox _itemSearchBar;
        private PSOShopkeeper.Controls.PSOShopkeeperPanel _itemListPanelBG;
        private PSOShopkeeper.Controls.TransparentDataGridView _itemListPanel;
        private PSOShopkeeper.Controls.PSOContextMenu _itemContextMenu;
        private PSOShopkeeper.Controls.PSOContextMenuItem _cutCells;
        private PSOShopkeeper.Controls.PSOContextMenuItem _copyCells;
        private PSOShopkeeper.Controls.PSOContextMenuItem _pasteCells;
        private PSOShopkeeper.Controls.PSOContextMenu _headerContextMenuBasic;
        private PSOShopkeeper.Controls.PSOContextMenuItem _clearColumnButton;
        private PSOShopkeeper.Controls.PSOContextMenu _headerContextMenuPDs;
        private PSOShopkeeper.Controls.PSOContextMenuItem _sumItemsToolStripMenuItem;
        private PSOShopkeeper.Controls.PSOContextMenuItem _clearColumnToolStripMenuItem;
        private PSOShopkeeper.Controls.PSOContextMenu _headerContextMenuMeseta;
        private PSOShopkeeper.Controls.PSOContextMenuItem _autofillToolStripMenuItem1;
        private PSOShopkeeper.Controls.PSOContextMenuItem _clearColumnsToolStripMenuItem;
    }
}
