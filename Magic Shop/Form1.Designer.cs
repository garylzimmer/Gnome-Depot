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
            this.ItemDataSet = new System.Data.DataSet();
            this.storeGridView = new System.Windows.Forms.DataGridView();
            this.storeBuyCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.storeQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeItemNameCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.storeDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storePriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBox = new System.Windows.Forms.GroupBox();
            this.scGridView = new System.Windows.Forms.DataGridView();
            this.scBox = new System.Windows.Forms.GroupBox();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ReadXMLButton = new System.Windows.Forms.Button();
            this.randomizeQty = new System.Windows.Forms.Button();
            this.scReturnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scItemNameCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.scDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGridView)).BeginInit();
            this.storeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGridView)).BeginInit();
            this.scBox.SuspendLayout();
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
            this.storeGridView.AutoGenerateColumns = false;
            this.storeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeBuyCol,
            this.storeQuantityCol,
            this.storeItemNameCol,
            this.storeDescriptionCol,
            this.storePriceCol,
            this.storeRarityCol});
            this.storeGridView.DataSource = this.ItemDataSet;
            this.storeGridView.Location = new System.Drawing.Point(6, 25);
            this.storeGridView.Name = "storeGridView";
            this.storeGridView.ReadOnly = true;
            this.storeGridView.RowHeadersVisible = false;
            this.storeGridView.Size = new System.Drawing.Size(529, 289);
            this.storeGridView.TabIndex = 0;
            this.storeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storeGridView_CellContentClick);
            // 
            // storeBuyCol
            // 
            this.storeBuyCol.HeaderText = "Buy?";
            this.storeBuyCol.Name = "storeBuyCol";
            this.storeBuyCol.ReadOnly = true;
            this.storeBuyCol.Text = "Buy";
            this.storeBuyCol.UseColumnTextForButtonValue = true;
            // 
            // storeQuantityCol
            // 
            this.storeQuantityCol.HeaderText = "Quantity";
            this.storeQuantityCol.Name = "storeQuantityCol";
            this.storeQuantityCol.ReadOnly = true;
            // 
            // storeItemNameCol
            // 
            this.storeItemNameCol.DataPropertyName = "name";
            this.storeItemNameCol.HeaderText = "Item Name";
            this.storeItemNameCol.Name = "storeItemNameCol";
            this.storeItemNameCol.ReadOnly = true;
            // 
            // storeDescriptionCol
            // 
            this.storeDescriptionCol.DataPropertyName = "description";
            this.storeDescriptionCol.HeaderText = "Description";
            this.storeDescriptionCol.Name = "storeDescriptionCol";
            this.storeDescriptionCol.ReadOnly = true;
            this.storeDescriptionCol.Visible = false;
            // 
            // storePriceCol
            // 
            this.storePriceCol.DataPropertyName = "price";
            this.storePriceCol.HeaderText = "Price (GP)";
            this.storePriceCol.Name = "storePriceCol";
            this.storePriceCol.ReadOnly = true;
            // 
            // storeRarityCol
            // 
            this.storeRarityCol.DataPropertyName = "rarity";
            this.storeRarityCol.HeaderText = "Rarity";
            this.storeRarityCol.Name = "storeRarityCol";
            this.storeRarityCol.ReadOnly = true;
            // 
            // storeBox
            // 
            this.storeBox.Controls.Add(this.storeGridView);
            this.storeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBox.Location = new System.Drawing.Point(746, 225);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(544, 314);
            this.storeBox.TabIndex = 1;
            this.storeBox.TabStop = false;
            this.storeBox.Text = "Store Inventory";
            this.storeBox.Enter += new System.EventHandler(this.storeBox_Enter);
            // 
            // scGridView
            // 
            this.scGridView.AllowUserToDeleteRows = false;
            this.scGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scReturnCol,
            this.scQuantityCol,
            this.scItemNameCol,
            this.scDescriptionCol,
            this.scPriceCol,
            this.scRarityCol});
            this.scGridView.Location = new System.Drawing.Point(6, 21);
            this.scGridView.Name = "scGridView";
            this.scGridView.ReadOnly = true;
            this.scGridView.RowHeadersVisible = false;
            this.scGridView.Size = new System.Drawing.Size(503, 289);
            this.scGridView.TabIndex = 2;
            this.scGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scGridView_CellContentClick);
            // 
            // scBox
            // 
            this.scBox.Controls.Add(this.scGridView);
            this.scBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scBox.Location = new System.Drawing.Point(225, 225);
            this.scBox.Name = "scBox";
            this.scBox.Size = new System.Drawing.Size(515, 327);
            this.scBox.TabIndex = 3;
            this.scBox.TabStop = false;
            this.scBox.Text = "Shopping Cart";
            this.scBox.Enter += new System.EventHandler(this.scBox_Enter);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(843, 199);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(438, 20);
            this.FilePathTextBox.TabIndex = 4;
            this.FilePathTextBox.Text = "File Path Here";
            // 
            // ReadXMLButton
            // 
            this.ReadXMLButton.Location = new System.Drawing.Point(66, 211);
            this.ReadXMLButton.Name = "ReadXMLButton";
            this.ReadXMLButton.Size = new System.Drawing.Size(133, 64);
            this.ReadXMLButton.TabIndex = 5;
            this.ReadXMLButton.Text = "Read XML";
            this.ReadXMLButton.UseVisualStyleBackColor = true;
            this.ReadXMLButton.Click += new System.EventHandler(this.ReadXMLButton_Click);
            // 
            // randomizeQty
            // 
            this.randomizeQty.Location = new System.Drawing.Point(66, 312);
            this.randomizeQty.Name = "randomizeQty";
            this.randomizeQty.Size = new System.Drawing.Size(133, 64);
            this.randomizeQty.TabIndex = 6;
            this.randomizeQty.Text = "Give Items Random Quantities";
            this.randomizeQty.UseVisualStyleBackColor = true;
            this.randomizeQty.Click += new System.EventHandler(this.randomizeQty_Click);
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
            this.scQuantityCol.HeaderText = "Quantity";
            this.scQuantityCol.Name = "scQuantityCol";
            this.scQuantityCol.ReadOnly = true;
            // 
            // scItemNameCol
            // 
            this.scItemNameCol.HeaderText = "Item Name";
            this.scItemNameCol.Name = "scItemNameCol";
            this.scItemNameCol.ReadOnly = true;
            // 
            // scDescriptionCol
            // 
            this.scDescriptionCol.HeaderText = "Description";
            this.scDescriptionCol.Name = "scDescriptionCol";
            this.scDescriptionCol.ReadOnly = true;
            this.scDescriptionCol.Visible = false;
            // 
            // scPriceCol
            // 
            this.scPriceCol.HeaderText = "Price (GP)";
            this.scPriceCol.Name = "scPriceCol";
            this.scPriceCol.ReadOnly = true;
            // 
            // scRarityCol
            // 
            this.scRarityCol.HeaderText = "Rarity";
            this.scRarityCol.Name = "scRarityCol";
            this.scRarityCol.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 545);
            this.Controls.Add(this.randomizeQty);
            this.Controls.Add(this.ReadXMLButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.storeBox);
            this.Controls.Add(this.scBox);
            this.Name = "MainWindow";
            this.Text = "RPG Magic Item Shop";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeGridView)).EndInit();
            this.storeBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGridView)).EndInit();
            this.scBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet ItemDataSet;
        private System.Windows.Forms.DataGridView storeGridView;
        private System.Windows.Forms.GroupBox storeBox;
        private System.Windows.Forms.DataGridView scGridView;
        private System.Windows.Forms.GroupBox scBox;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button ReadXMLButton;
        private System.Windows.Forms.Button randomizeQty;
        private System.Windows.Forms.DataGridViewButtonColumn storeBuyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeQuantityCol;
        private System.Windows.Forms.DataGridViewLinkColumn storeItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn storePriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeRarityCol;
        private System.Windows.Forms.DataGridViewButtonColumn scReturnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scQuantityCol;
        private System.Windows.Forms.DataGridViewLinkColumn scItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scRarityCol;
    }
}

