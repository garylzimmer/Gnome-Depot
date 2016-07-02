using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Shop
{
	public partial class EditXML : Form
	{
		public EditXML()
		{
			InitializeComponent();
		}

		string origWindowTitle;

		public string sFileName = "";

		public void openToEditXML()
		{
			
			OpenFileDialog openToEditXMLDialog = new OpenFileDialog();
			openToEditXMLDialog.Filter = "XML File | *.xml";
			openToEditXMLDialog.Title = "Select a(n) XML file with a list of items";
			if (openToEditXMLDialog.ShowDialog() == DialogResult.OK)
			{
				editDataSet.Clear();
				sFileName = openToEditXMLDialog.FileName;
				this.Text = origWindowTitle + " - " + sFileName;
				try
				{
					editDataSet.ReadXml(sFileName);
				}
				catch(Exception e)
				{
					MessageBox.Show("Problem reading XML file, probably malformed. \n Details: \n" + e);
				}
				editDGV.AutoGenerateColumns = true;
				editDGV.DataSource = editDataSet;
				editDGV.DataMember = "item";
				editDGV.AllowUserToAddRows = true;
				editDGV.AllowUserToDeleteRows = true;
				this.Activate();
			}
		}

		private void saveXMLFile()
		{
			if(editDataSet == null) { return;}

			//Create the FileStream to write with.
			SaveFileDialog saveXMLDialog = new SaveFileDialog();
			saveXMLDialog.Filter = "XML File | *.xml";
			saveXMLDialog.Title = "Save the XML File";
			saveXMLDialog.ShowDialog();

			if (saveXMLDialog.FileName != "")
			{
				try
				{
					System.IO.FileStream stream = new System.IO.FileStream(saveXMLDialog.FileName, System.IO.FileMode.Create);
					editDataSet.WriteXml(stream);
					stream.Close();
					MessageBox.Show("File Saved.");
					
				}
				catch (Exception ioErr)
				{
					MessageBox.Show("IO Error. You file is already open. Probably. \n" + ioErr);

				}
			}

		}

		private void openXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openToEditXML();
		}

		private void saveXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveXMLFile();
		}

		private void EditXML_Load(object sender, EventArgs e)
		{
			origWindowTitle = this.Text;
		}
	}
}


