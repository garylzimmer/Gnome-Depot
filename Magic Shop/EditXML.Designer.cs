namespace Magic_Shop
{
	partial class EditXML
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.newXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editDataSet = new System.Data.DataSet();
			this.editDGV = new System.Windows.Forms.DataGridView();
			this.editXMLItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLRarityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLWeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editXMLRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XMLFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newXMLFileToolStripMenuItem,
            this.openXMLFileToolStripMenuItem,
            this.saveXMLFileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// newXMLFileToolStripMenuItem
			// 
			this.newXMLFileToolStripMenuItem.Name = "newXMLFileToolStripMenuItem";
			this.newXMLFileToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.newXMLFileToolStripMenuItem.Text = "New XML File";
			// 
			// openXMLFileToolStripMenuItem
			// 
			this.openXMLFileToolStripMenuItem.Name = "openXMLFileToolStripMenuItem";
			this.openXMLFileToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.openXMLFileToolStripMenuItem.Text = "Open XML File";
			this.openXMLFileToolStripMenuItem.Click += new System.EventHandler(this.openXMLFileToolStripMenuItem_Click);
			// 
			// saveXMLFileToolStripMenuItem
			// 
			this.saveXMLFileToolStripMenuItem.Name = "saveXMLFileToolStripMenuItem";
			this.saveXMLFileToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.saveXMLFileToolStripMenuItem.Text = "Save XML File";
			// 
			// editDataSet
			// 
			this.editDataSet.DataSetName = "editDataSet";
			// 
			// editDGV
			// 
			this.editDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.editDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editXMLItemNameCol,
            this.editXMLRarityCol,
            this.editXMLDescriptionCol,
            this.editXMLPriceCol,
            this.editXMLTypeCol,
            this.editXMLWeightCol,
            this.editXMLRef});
			this.editDGV.Location = new System.Drawing.Point(0, 26);
			this.editDGV.Name = "editDGV";
			this.editDGV.Size = new System.Drawing.Size(1213, 462);
			this.editDGV.TabIndex = 1;
			// 
			// editXMLItemNameCol
			// 
			this.editXMLItemNameCol.HeaderText = "Item Name";
			this.editXMLItemNameCol.Name = "editXMLItemNameCol";
			// 
			// editXMLRarityCol
			// 
			this.editXMLRarityCol.HeaderText = "Rarity";
			this.editXMLRarityCol.Name = "editXMLRarityCol";
			// 
			// editXMLDescriptionCol
			// 
			this.editXMLDescriptionCol.HeaderText = "Description";
			this.editXMLDescriptionCol.Name = "editXMLDescriptionCol";
			// 
			// editXMLPriceCol
			// 
			this.editXMLPriceCol.HeaderText = "Price (GP)";
			this.editXMLPriceCol.Name = "editXMLPriceCol";
			// 
			// editXMLTypeCol
			// 
			this.editXMLTypeCol.HeaderText = "Type";
			this.editXMLTypeCol.Name = "editXMLTypeCol";
			// 
			// editXMLWeightCol
			// 
			this.editXMLWeightCol.HeaderText = "Weight (lbs)";
			this.editXMLWeightCol.Name = "editXMLWeightCol";
			// 
			// editXMLRef
			// 
			this.editXMLRef.HeaderText = "Reference";
			this.editXMLRef.Name = "editXMLRef";
			// 
			// XMLFilePath
			// 
			this.XMLFilePath.Location = new System.Drawing.Point(371, 0);
			this.XMLFilePath.Name = "XMLFilePath";
			this.XMLFilePath.Size = new System.Drawing.Size(842, 20);
			this.XMLFilePath.TabIndex = 2;
			this.XMLFilePath.Text = "XMLFilePath";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Editing:";
			// 
			// EditXML
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 491);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.XMLFilePath);
			this.Controls.Add(this.editDGV);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "EditXML";
			this.Text = "Item XML Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.editDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newXMLFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openXMLFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveXMLFileToolStripMenuItem;
		private System.Data.DataSet editDataSet;
		private System.Windows.Forms.DataGridView editDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLItemNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLRarityCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLDescriptionCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLPriceCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLTypeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLWeightCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn editXMLRef;
		private System.Windows.Forms.TextBox XMLFilePath;
		private System.Windows.Forms.Label label1;
	}
}