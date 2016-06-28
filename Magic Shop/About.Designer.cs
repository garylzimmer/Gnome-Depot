namespace Magic_Shop
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.aboutTextBox = new System.Windows.Forms.TextBox();
			this.githublinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// aboutTextBox
			// 
			this.aboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutTextBox.Location = new System.Drawing.Point(10, 12);
			this.aboutTextBox.Multiline = true;
			this.aboutTextBox.Name = "aboutTextBox";
			this.aboutTextBox.ReadOnly = true;
			this.aboutTextBox.Size = new System.Drawing.Size(260, 86);
			this.aboutTextBox.TabIndex = 0;
			this.aboutTextBox.Text = "Magic Shop \r\nVersion 1.2\r\nby Gary Zimmer";
			this.aboutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// githublinkLabel1
			// 
			this.githublinkLabel1.AutoSize = true;
			this.githublinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.githublinkLabel1.Location = new System.Drawing.Point(7, 138);
			this.githublinkLabel1.Name = "githublinkLabel1";
			this.githublinkLabel1.Size = new System.Drawing.Size(270, 16);
			this.githublinkLabel1.TabIndex = 1;
			this.githublinkLabel1.TabStop = true;
			this.githublinkLabel1.Text = "https://github.com/garylzimmer/Magic-Shop/";
			this.githublinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublinkLabel1_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "For Comments, Suggestions, Change Logs, and More:";
			// 
			// closeButton
			// 
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(89, 161);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(102, 44);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 66);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 212);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.githublinkLabel1);
			this.Controls.Add(this.aboutTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "About";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox aboutTextBox;
		private System.Windows.Forms.LinkLabel githublinkLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}