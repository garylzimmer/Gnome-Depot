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
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void githublinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/garylzimmer/Gnome-Depot");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Easter Egg!");
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://game-icons.net");
		}
	}
}
