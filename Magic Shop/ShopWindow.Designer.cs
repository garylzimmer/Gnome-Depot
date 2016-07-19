namespace Magic_Shop
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.ItemDataSet = new System.Data.DataSet();
			this.storeGridView = new System.Windows.Forms.DataGridView();
			this.storeBox = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.shopPricingLevelLabel = new System.Windows.Forms.Label();
			this.shopPricingLevel = new System.Windows.Forms.ComboBox();
			this.randomizePricesCheckBox = new System.Windows.Forms.CheckBox();
			this.scGridView = new System.Windows.Forms.DataGridView();
			this.scReturnCol = new System.Windows.Forms.DataGridViewButtonColumn();
			this.scQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scItemNameCol = new System.Windows.Forms.DataGridViewLinkColumn();
			this.scPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scWeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scRefCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scBox = new System.Windows.Forms.GroupBox();
			this.startingGPTextBox = new System.Windows.Forms.TextBox();
			this.scTotalTextBox = new System.Windows.Forms.TextBox();
			this.endingGPTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openStoreArchetypeXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.loadPreGeneratedStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveThisGeneratedStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.storeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomStoreNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.uniqueStoreNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.storeInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disabledPanel = new System.Windows.Forms.Panel();
			this.disabledPanel2 = new System.Windows.Forms.Panel();
			this.disabledLabel4 = new System.Windows.Forms.Label();
			this.arrow2label = new System.Windows.Forms.Label();
			this.disabledLabel1 = new System.Windows.Forms.Label();
			this.arrow1label = new System.Windows.Forms.Label();
			this.storeNameLabel = new System.Windows.Forms.Label();
			this.storeBuyCol = new System.Windows.Forms.DataGridViewButtonColumn();
			this.storeQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeItemNameCol = new System.Windows.Forms.DataGridViewLinkColumn();
			this.storePriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeWeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeRefCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.storeGridView)).BeginInit();
			this.storeBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scGridView)).BeginInit();
			this.scBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.disabledPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ItemDataSet
			// 
			this.ItemDataSet.DataSetName = "NewDataSet";
			// 
			// storeGridView
			// 
			this.storeGridView.AllowUserToAddRows = false;
			this.storeGridView.AllowUserToDeleteRows = false;
			this.storeGridView.AllowUserToResizeRows = false;
			this.storeGridView.AutoGenerateColumns = false;
			this.storeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.storeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeBuyCol,
            this.storeQuantityCol,
            this.storeItemNameCol,
            this.storePriceCol,
            this.storeRarityCol,
            this.storeDescriptionCol,
            this.storeWeightCol,
            this.storeTypeCol,
            this.storeRefCol});
			this.storeGridView.DataSource = this.ItemDataSet;
			this.storeGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.storeGridView.Location = new System.Drawing.Point(6, 21);
			this.storeGridView.Name = "storeGridView";
			this.storeGridView.RowHeadersVisible = false;
			this.storeGridView.Size = new System.Drawing.Size(529, 264);
			this.storeGridView.TabIndex = 0;
			this.storeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storeGridView_CellContentClick);
			// 
			// storeBox
			// 
			this.storeBox.Controls.Add(this.label4);
			this.storeBox.Controls.Add(this.shopPricingLevelLabel);
			this.storeBox.Controls.Add(this.shopPricingLevel);
			this.storeBox.Controls.Add(this.randomizePricesCheckBox);
			this.storeBox.Controls.Add(this.storeGridView);
			this.storeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storeBox.Location = new System.Drawing.Point(634, 27);
			this.storeBox.Name = "storeBox";
			this.storeBox.Size = new System.Drawing.Size(544, 327);
			this.storeBox.TabIndex = 1;
			this.storeBox.TabStop = false;
			this.storeBox.Text = "Store Inventory";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(149, 297);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Doubleclick or F2 to Edit Fields";
			// 
			// shopPricingLevelLabel
			// 
			this.shopPricingLevelLabel.AutoSize = true;
			this.shopPricingLevelLabel.Location = new System.Drawing.Point(325, 297);
			this.shopPricingLevelLabel.Name = "shopPricingLevelLabel";
			this.shopPricingLevelLabel.Size = new System.Drawing.Size(80, 13);
			this.shopPricingLevelLabel.TabIndex = 21;
			this.shopPricingLevelLabel.Text = "Shop Pricing is:";
			// 
			// shopPricingLevel
			// 
			this.shopPricingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shopPricingLevel.FormattingEnabled = true;
			this.shopPricingLevel.Items.AddRange(new object[] {
            "Cheap",
            "Average",
            "Expensive"});
			this.shopPricingLevel.Location = new System.Drawing.Point(411, 294);
			this.shopPricingLevel.Name = "shopPricingLevel";
			this.shopPricingLevel.Size = new System.Drawing.Size(121, 21);
			this.shopPricingLevel.TabIndex = 20;
			this.shopPricingLevel.SelectedIndexChanged += new System.EventHandler(this.shopPricingLevel_SelectedIndexChanged);
			// 
			// randomizePricesCheckBox
			// 
			this.randomizePricesCheckBox.AutoSize = true;
			this.randomizePricesCheckBox.Location = new System.Drawing.Point(7, 292);
			this.randomizePricesCheckBox.Name = "randomizePricesCheckBox";
			this.randomizePricesCheckBox.Size = new System.Drawing.Size(114, 17);
			this.randomizePricesCheckBox.TabIndex = 19;
			this.randomizePricesCheckBox.Text = "Randomize Pricing";
			this.randomizePricesCheckBox.UseVisualStyleBackColor = true;
			this.randomizePricesCheckBox.CheckedChanged += new System.EventHandler(this.randomizePrices_CheckedChanged);
			// 
			// scGridView
			// 
			this.scGridView.AllowUserToDeleteRows = false;
			this.scGridView.AllowUserToResizeRows = false;
			this.scGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.scGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scReturnCol,
            this.scQuantityCol,
            this.scItemNameCol,
            this.scPriceCol,
            this.scRarityCol,
            this.scDescriptionCol,
            this.scWeightCol,
            this.scTypeCol,
            this.scRefCol});
			this.scGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.scGridView.Enabled = false;
			this.scGridView.Location = new System.Drawing.Point(6, 21);
			this.scGridView.Name = "scGridView";
			this.scGridView.ReadOnly = true;
			this.scGridView.RowHeadersVisible = false;
			this.scGridView.Size = new System.Drawing.Size(503, 289);
			this.scGridView.TabIndex = 2;
			this.scGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scGridView_CellContentClick);
			// 
			// scReturnCol
			// 
			this.scReturnCol.HeaderText = "Return?";
			this.scReturnCol.Name = "scReturnCol";
			this.scReturnCol.ReadOnly = true;
			this.scReturnCol.Text = "Return";
			this.scReturnCol.UseColumnTextForButtonValue = true;
			// 
			// scQuantityCol
			// 
			this.scQuantityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.scQuantityCol.HeaderText = "Qty";
			this.scQuantityCol.Name = "scQuantityCol";
			this.scQuantityCol.ReadOnly = true;
			this.scQuantityCol.Width = 48;
			// 
			// scItemNameCol
			// 
			this.scItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.scItemNameCol.HeaderText = "Item Name";
			this.scItemNameCol.Name = "scItemNameCol";
			this.scItemNameCol.ReadOnly = true;
			this.scItemNameCol.Width = 64;
			// 
			// scPriceCol
			// 
			this.scPriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.scPriceCol.HeaderText = "Price (GP)";
			this.scPriceCol.Name = "scPriceCol";
			this.scPriceCol.ReadOnly = true;
			this.scPriceCol.Width = 50;
			// 
			// scRarityCol
			// 
			this.scRarityCol.HeaderText = "Rarity";
			this.scRarityCol.Name = "scRarityCol";
			this.scRarityCol.ReadOnly = true;
			// 
			// scDescriptionCol
			// 
			this.scDescriptionCol.HeaderText = "Description";
			this.scDescriptionCol.Name = "scDescriptionCol";
			this.scDescriptionCol.ReadOnly = true;
			this.scDescriptionCol.Visible = false;
			// 
			// scWeightCol
			// 
			this.scWeightCol.HeaderText = "Weight (lbs)";
			this.scWeightCol.Name = "scWeightCol";
			this.scWeightCol.ReadOnly = true;
			this.scWeightCol.Visible = false;
			// 
			// scTypeCol
			// 
			this.scTypeCol.HeaderText = "Type";
			this.scTypeCol.Name = "scTypeCol";
			this.scTypeCol.ReadOnly = true;
			this.scTypeCol.Visible = false;
			// 
			// scRefCol
			// 
			this.scRefCol.HeaderText = "Reference";
			this.scRefCol.Name = "scRefCol";
			this.scRefCol.ReadOnly = true;
			this.scRefCol.Visible = false;
			// 
			// scBox
			// 
			this.scBox.Controls.Add(this.scGridView);
			this.scBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scBox.Location = new System.Drawing.Point(113, 29);
			this.scBox.Name = "scBox";
			this.scBox.Size = new System.Drawing.Size(515, 325);
			this.scBox.TabIndex = 3;
			this.scBox.TabStop = false;
			this.scBox.Text = "Shopping Cart";
			// 
			// startingGPTextBox
			// 
			this.startingGPTextBox.Location = new System.Drawing.Point(7, 48);
			this.startingGPTextBox.Name = "startingGPTextBox";
			this.startingGPTextBox.Size = new System.Drawing.Size(100, 20);
			this.startingGPTextBox.TabIndex = 7;
			this.startingGPTextBox.Text = "0";
			// 
			// scTotalTextBox
			// 
			this.scTotalTextBox.Location = new System.Drawing.Point(7, 220);
			this.scTotalTextBox.Name = "scTotalTextBox";
			this.scTotalTextBox.Size = new System.Drawing.Size(100, 20);
			this.scTotalTextBox.TabIndex = 8;
			this.scTotalTextBox.Text = "Cart Total";
			// 
			// endingGPTextBox
			// 
			this.endingGPTextBox.Location = new System.Drawing.Point(7, 315);
			this.endingGPTextBox.Name = "endingGPTextBox";
			this.endingGPTextBox.Size = new System.Drawing.Size(100, 20);
			this.endingGPTextBox.TabIndex = 9;
			this.endingGPTextBox.Text = "Ending GP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Starting GP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Total in Cart";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 299);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Ending GP";
			// 
			// calculateButton
			// 
			this.calculateButton.Enabled = false;
			this.calculateButton.Location = new System.Drawing.Point(10, 74);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(97, 23);
			this.calculateButton.TabIndex = 14;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.generateToolStripMenuItem,
            this.aboutMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.TabStop = true;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStoreArchetypeXMLFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadPreGeneratedStoreToolStripMenuItem,
            this.saveThisGeneratedStoreToolStripMenuItem,
            this.toolStripSeparator1,
            this.editXMLFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileMenuItem.Text = "File";
			// 
			// openStoreArchetypeXMLFileToolStripMenuItem
			// 
			this.openStoreArchetypeXMLFileToolStripMenuItem.Name = "openStoreArchetypeXMLFileToolStripMenuItem";
			this.openStoreArchetypeXMLFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.openStoreArchetypeXMLFileToolStripMenuItem.Text = "Open Store Archetype XML file";
			this.openStoreArchetypeXMLFileToolStripMenuItem.Click += new System.EventHandler(this.openStoreArchetypeXMLFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
			// 
			// loadPreGeneratedStoreToolStripMenuItem
			// 
			this.loadPreGeneratedStoreToolStripMenuItem.Enabled = false;
			this.loadPreGeneratedStoreToolStripMenuItem.Name = "loadPreGeneratedStoreToolStripMenuItem";
			this.loadPreGeneratedStoreToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.loadPreGeneratedStoreToolStripMenuItem.Text = "Load Pre-Generated Store";
			// 
			// saveThisGeneratedStoreToolStripMenuItem
			// 
			this.saveThisGeneratedStoreToolStripMenuItem.Enabled = false;
			this.saveThisGeneratedStoreToolStripMenuItem.Name = "saveThisGeneratedStoreToolStripMenuItem";
			this.saveThisGeneratedStoreToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.saveThisGeneratedStoreToolStripMenuItem.Text = "Save This Generated Store";
			this.saveThisGeneratedStoreToolStripMenuItem.Click += new System.EventHandler(this.saveThisGeneratedStoreToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
			// 
			// editXMLFileToolStripMenuItem
			// 
			this.editXMLFileToolStripMenuItem.Name = "editXMLFileToolStripMenuItem";
			this.editXMLFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.editXMLFileToolStripMenuItem.Text = "Edit XML File";
			this.editXMLFileToolStripMenuItem.Click += new System.EventHandler(this.editXMLFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// generateToolStripMenuItem
			// 
			this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeNameToolStripMenuItem,
            this.storeInventoryToolStripMenuItem});
			this.generateToolStripMenuItem.Enabled = false;
			this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
			this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.generateToolStripMenuItem.Text = "Generate";
			// 
			// storeNameToolStripMenuItem
			// 
			this.storeNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomStoreNameToolStripMenuItem1,
            this.uniqueStoreNameToolStripMenuItem});
			this.storeNameToolStripMenuItem.Name = "storeNameToolStripMenuItem";
			this.storeNameToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.storeNameToolStripMenuItem.Text = "Store Name";
			// 
			// randomStoreNameToolStripMenuItem1
			// 
			this.randomStoreNameToolStripMenuItem1.Name = "randomStoreNameToolStripMenuItem1";
			this.randomStoreNameToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
			this.randomStoreNameToolStripMenuItem1.Text = "Random Store Name";
			this.randomStoreNameToolStripMenuItem1.Click += new System.EventHandler(this.randomStoreNameToolStripMenuItem1_Click);
			// 
			// uniqueStoreNameToolStripMenuItem
			// 
			this.uniqueStoreNameToolStripMenuItem.Name = "uniqueStoreNameToolStripMenuItem";
			this.uniqueStoreNameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.uniqueStoreNameToolStripMenuItem.Text = "Unique Store Name";
			this.uniqueStoreNameToolStripMenuItem.Click += new System.EventHandler(this.uniqueStoreNameToolStripMenuItem_Click);
			// 
			// storeInventoryToolStripMenuItem
			// 
			this.storeInventoryToolStripMenuItem.Name = "storeInventoryToolStripMenuItem";
			this.storeInventoryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.storeInventoryToolStripMenuItem.Text = "Store Inventory";
			this.storeInventoryToolStripMenuItem.Click += new System.EventHandler(this.storeInventoryToolStripMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// disabledPanel
			// 
			this.disabledPanel.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.disabledPanel.Location = new System.Drawing.Point(634, 29);
			this.disabledPanel.Name = "disabledPanel";
			this.disabledPanel.Size = new System.Drawing.Size(544, 326);
			this.disabledPanel.TabIndex = 4;
			// 
			// disabledPanel2
			// 
			this.disabledPanel2.Controls.Add(this.disabledLabel4);
			this.disabledPanel2.Controls.Add(this.arrow2label);
			this.disabledPanel2.Controls.Add(this.disabledLabel1);
			this.disabledPanel2.Controls.Add(this.arrow1label);
			this.disabledPanel2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.disabledPanel2.Location = new System.Drawing.Point(0, 29);
			this.disabledPanel2.Name = "disabledPanel2";
			this.disabledPanel2.Size = new System.Drawing.Size(628, 326);
			this.disabledPanel2.TabIndex = 7;
			// 
			// disabledLabel4
			// 
			this.disabledLabel4.AutoSize = true;
			this.disabledLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disabledLabel4.Location = new System.Drawing.Point(114, 62);
			this.disabledLabel4.Name = "disabledLabel4";
			this.disabledLabel4.Size = new System.Drawing.Size(351, 25);
			this.disabledLabel4.TabIndex = 6;
			this.disabledLabel4.Text = "Click \"Generate\" > \"Store Inventory\"";
			this.disabledLabel4.Visible = false;
			this.disabledLabel4.Click += new System.EventHandler(this.disabledLabel4_Click);
			// 
			// arrow2label
			// 
			this.arrow2label.AutoSize = true;
			this.arrow2label.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.arrow2label.Location = new System.Drawing.Point(38, -4);
			this.arrow2label.Name = "arrow2label";
			this.arrow2label.Size = new System.Drawing.Size(98, 106);
			this.arrow2label.TabIndex = 5;
			this.arrow2label.Text = "G";
			this.arrow2label.Visible = false;
			// 
			// disabledLabel1
			// 
			this.disabledLabel1.AutoSize = true;
			this.disabledLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disabledLabel1.Location = new System.Drawing.Point(74, 47);
			this.disabledLabel1.Name = "disabledLabel1";
			this.disabledLabel1.Size = new System.Drawing.Size(326, 25);
			this.disabledLabel1.TabIndex = 3;
			this.disabledLabel1.Text = "Open a Store Archetype XML file";
			this.disabledLabel1.Click += new System.EventHandler(this.disabledLabel1_Click);
			// 
			// arrow1label
			// 
			this.arrow1label.AutoSize = true;
			this.arrow1label.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.arrow1label.Location = new System.Drawing.Point(-18, -5);
			this.arrow1label.Name = "arrow1label";
			this.arrow1label.Size = new System.Drawing.Size(98, 106);
			this.arrow1label.TabIndex = 4;
			this.arrow1label.Text = "G";
			// 
			// storeNameLabel
			// 
			this.storeNameLabel.AutoSize = true;
			this.storeNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storeNameLabel.Location = new System.Drawing.Point(846, 0);
			this.storeNameLabel.Name = "storeNameLabel";
			this.storeNameLabel.Size = new System.Drawing.Size(69, 33);
			this.storeNameLabel.TabIndex = 15;
			this.storeNameLabel.Text = "Store";
			// 
			// storeBuyCol
			// 
			this.storeBuyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.storeBuyCol.HeaderText = "Buy?";
			this.storeBuyCol.Name = "storeBuyCol";
			this.storeBuyCol.ReadOnly = true;
			this.storeBuyCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.storeBuyCol.Text = "Buy";
			this.storeBuyCol.UseColumnTextForButtonValue = true;
			this.storeBuyCol.Width = 37;
			// 
			// storeQuantityCol
			// 
			this.storeQuantityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.storeQuantityCol.DataPropertyName = "qty";
			this.storeQuantityCol.HeaderText = "Qty";
			this.storeQuantityCol.Name = "storeQuantityCol";
			this.storeQuantityCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.storeQuantityCol.Width = 29;
			// 
			// storeItemNameCol
			// 
			this.storeItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.storeItemNameCol.DataPropertyName = "name";
			this.storeItemNameCol.HeaderText = "Item Name";
			this.storeItemNameCol.Name = "storeItemNameCol";
			this.storeItemNameCol.TrackVisitedState = false;
			this.storeItemNameCol.Width = 64;
			// 
			// storePriceCol
			// 
			this.storePriceCol.DataPropertyName = "price";
			this.storePriceCol.HeaderText = "Price (GP)";
			this.storePriceCol.Name = "storePriceCol";
			this.storePriceCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// storeRarityCol
			// 
			this.storeRarityCol.DataPropertyName = "rarity";
			this.storeRarityCol.HeaderText = "Rarity";
			this.storeRarityCol.Name = "storeRarityCol";
			this.storeRarityCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// storeDescriptionCol
			// 
			this.storeDescriptionCol.DataPropertyName = "description";
			this.storeDescriptionCol.HeaderText = "Description";
			this.storeDescriptionCol.Name = "storeDescriptionCol";
			this.storeDescriptionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.storeDescriptionCol.Visible = false;
			// 
			// storeWeightCol
			// 
			this.storeWeightCol.DataPropertyName = "weight";
			this.storeWeightCol.HeaderText = "Weight (lbs)";
			this.storeWeightCol.Name = "storeWeightCol";
			this.storeWeightCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// storeTypeCol
			// 
			this.storeTypeCol.DataPropertyName = "type";
			this.storeTypeCol.HeaderText = "Type";
			this.storeTypeCol.Name = "storeTypeCol";
			this.storeTypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.storeTypeCol.Visible = false;
			// 
			// storeRefCol
			// 
			this.storeRefCol.DataPropertyName = "ref";
			this.storeRefCol.HeaderText = "Reference";
			this.storeRefCol.Name = "storeRefCol";
			this.storeRefCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.storeRefCol.Visible = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 362);
			this.Controls.Add(this.storeNameLabel);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.endingGPTextBox);
			this.Controls.Add(this.scTotalTextBox);
			this.Controls.Add(this.startingGPTextBox);
			this.Controls.Add(this.storeBox);
			this.Controls.Add(this.scBox);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.disabledPanel2);
			this.Controls.Add(this.disabledPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.Text = "Gnome Depot v1.7";
			this.Load += new System.EventHandler(this.Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.storeGridView)).EndInit();
			this.storeBox.ResumeLayout(false);
			this.storeBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scGridView)).EndInit();
			this.scBox.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.disabledPanel2.ResumeLayout(false);
			this.disabledPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet ItemDataSet;
        private System.Windows.Forms.DataGridView storeGridView;
        private System.Windows.Forms.GroupBox storeBox;
        private System.Windows.Forms.DataGridView scGridView;
        private System.Windows.Forms.GroupBox scBox;
        private System.Windows.Forms.TextBox startingGPTextBox;
        private System.Windows.Forms.TextBox scTotalTextBox;
        private System.Windows.Forms.TextBox endingGPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Panel disabledPanel;
		private System.Windows.Forms.Panel disabledPanel2;
		private System.Windows.Forms.Label disabledLabel4;
		private System.Windows.Forms.Label arrow2label;
		private System.Windows.Forms.Label disabledLabel1;
		private System.Windows.Forms.Label arrow1label;
		private System.Windows.Forms.CheckBox randomizePricesCheckBox;
		private System.Windows.Forms.Label shopPricingLevelLabel;
		private System.Windows.Forms.ComboBox shopPricingLevel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem openStoreArchetypeXMLFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveThisGeneratedStoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label storeNameLabel;
		private System.Windows.Forms.DataGridViewButtonColumn scReturnCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scQuantityCol;
		private System.Windows.Forms.DataGridViewLinkColumn scItemNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scPriceCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scRarityCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scDescriptionCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scWeightCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scTypeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn scRefCol;
		private System.Windows.Forms.ToolStripMenuItem editXMLFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem storeNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem randomStoreNameToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem uniqueStoreNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem storeInventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem loadPreGeneratedStoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.DataGridViewButtonColumn storeBuyCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeQuantityCol;
		private System.Windows.Forms.DataGridViewLinkColumn storeItemNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storePriceCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeRarityCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeDescriptionCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeWeightCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeTypeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn storeRefCol;
	}
}

