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
            this.scReturnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scItemNameCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.scDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scBox = new System.Windows.Forms.GroupBox();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ReadXMLButton = new System.Windows.Forms.Button();
            this.randomizeQty = new System.Windows.Forms.Button();
            this.startingGPTextBox = new System.Windows.Forms.TextBox();
            this.scTotalTextBox = new System.Windows.Forms.TextBox();
            this.endingGPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
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
            this.storeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBox.Location = new System.Drawing.Point(746, 225);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(544, 314);
            this.storeBox.TabIndex = 1;
            this.storeBox.TabStop = false;
            this.storeBox.Text = "Store Inventory";
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
            this.scQuantityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.scQuantityCol.HeaderText = "Quantity";
            this.scQuantityCol.Name = "scQuantityCol";
            this.scQuantityCol.ReadOnly = true;
            this.scQuantityCol.Width = 50;
            // 
            // scItemNameCol
            // 
            this.scItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // scBox
            // 
            this.scBox.Controls.Add(this.scGridView);
            this.scBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scBox.Location = new System.Drawing.Point(225, 225);
            this.scBox.Name = "scBox";
            this.scBox.Size = new System.Drawing.Size(515, 327);
            this.scBox.TabIndex = 3;
            this.scBox.TabStop = false;
            this.scBox.Text = "Shopping Cart";
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
            this.ReadXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadXMLButton.Location = new System.Drawing.Point(225, 155);
            this.ReadXMLButton.Name = "ReadXMLButton";
            this.ReadXMLButton.Size = new System.Drawing.Size(133, 64);
            this.ReadXMLButton.TabIndex = 5;
            this.ReadXMLButton.Text = "Read XML File";
            this.ReadXMLButton.UseVisualStyleBackColor = true;
            this.ReadXMLButton.Click += new System.EventHandler(this.ReadXMLButton_Click);
            // 
            // randomizeQty
            // 
            this.randomizeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeQty.Location = new System.Drawing.Point(364, 155);
            this.randomizeQty.Name = "randomizeQty";
            this.randomizeQty.Size = new System.Drawing.Size(133, 64);
            this.randomizeQty.TabIndex = 6;
            this.randomizeQty.Text = "Generate Shop";
            this.randomizeQty.UseVisualStyleBackColor = true;
            this.randomizeQty.Click += new System.EventHandler(this.randomizeQty_Click);
            // 
            // startingGPTextBox
            // 
            this.startingGPTextBox.Location = new System.Drawing.Point(119, 246);
            this.startingGPTextBox.Name = "startingGPTextBox";
            this.startingGPTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingGPTextBox.TabIndex = 7;
            this.startingGPTextBox.Text = "Starting GP";
            this.startingGPTextBox.TextChanged += new System.EventHandler(this.startingGPTextBox_TextChanged);
            // 
            // scTotalTextBox
            // 
            this.scTotalTextBox.Location = new System.Drawing.Point(119, 418);
            this.scTotalTextBox.Name = "scTotalTextBox";
            this.scTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.scTotalTextBox.TabIndex = 8;
            this.scTotalTextBox.Text = "Cart Total";
            // 
            // endingGPTextBox
            // 
            this.endingGPTextBox.Location = new System.Drawing.Point(119, 513);
            this.endingGPTextBox.Name = "endingGPTextBox";
            this.endingGPTextBox.Size = new System.Drawing.Size(100, 20);
            this.endingGPTextBox.TabIndex = 9;
            this.endingGPTextBox.Text = "Ending GP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Starting GP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total in Cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ending GP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Items Generated from XML Source File:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(122, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(12, 26);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(241, 13);
            this.aboutLabel.TabIndex = 15;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "Made by Gary Zimmer. Visit the Github page here.";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Version 1.0.1 -Added cases for all rarity types";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endingGPTextBox);
            this.Controls.Add(this.scTotalTextBox);
            this.Controls.Add(this.startingGPTextBox);
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
        private System.Windows.Forms.TextBox startingGPTextBox;
        private System.Windows.Forms.TextBox scTotalTextBox;
        private System.Windows.Forms.TextBox endingGPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridViewButtonColumn scReturnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scQuantityCol;
        private System.Windows.Forms.DataGridViewLinkColumn scItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scRarityCol;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.Label label5;
    }
}

