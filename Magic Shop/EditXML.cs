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

		public void openToEditXML()
		{
			OpenFileDialog openToEditXMLDialog = new OpenFileDialog();
			openToEditXMLDialog.Filter = "XML File | *.xml";
			openToEditXMLDialog.Title = "Select a(n) XML file with a list of items";
			if (openToEditXMLDialog.ShowDialog() == DialogResult.OK)
			{
				string sFileName = openToEditXMLDialog.FileName;

			}
		}


		private void openXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}


