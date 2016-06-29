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
    public partial class MainWindow : Form
    {
        private DataSet itemsDS;
        Random rndQty = new Random();
		string windowTitle;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
			windowTitle = this.Text;
			itemsDS = new DataSet("ItemDataSet");

            //attempt to load XML path on form load, doesn't work, don't know why
            //itemsDS.ReadXml(XMLfilePath);

            //attempt to turn off autogenerating columns, doesn't work, don't know why
            //storeGridView.AutoGenerateColumns = false;
            //storeGridView.DataSource = ItemDataSet;
           // storeGridView.DataMember = "item";
            //DataGridViewLinkColumn itemColumn = new DataGridViewLinkColumn();
            //storeGridView.AllowUserToAddRows = false;
           // scGridView.AllowUserToAddRows = false;
            //scGridView.AutoGenerateColumns = false;
			//disabledPanel.Visible = true;
			//disabledPanel.BringToFront();

		}

        private string GetItemRarity(int RowNum)
        {
            //get item rarity by looking in column named 'storeRarityCol' for that cell
            string itemRarity = (string)storeGridView.Rows[RowNum].Cells["storeRarityCol"].Value;
            return itemRarity;
        }

        private int SetItemQuantity(string Rarity)
        {


            if (Rarity == "Common")
            {
                int Qty = rndQty.Next(5, 11);
                return Qty;
            }

            else if (Rarity == "Uncommon")
            {

                int Qty = rndQty.Next(0, 6);
                return Qty;
            }
            else if (Rarity == "Rare")
            {
                int Qty = rndQty.Next(0, 2);
                return Qty;

            }
            else if (Rarity == "Very Rare")
            {
                int dropRate = rndQty.Next(1, 11);
                if (dropRate == 10)
                {
                    return 1;

                }
                else return 0;

            }
            else if (Rarity == "Legendary")
            {
                int dropRate = rndQty.Next(1, 51);
                if (dropRate == 50)
                {
                    return 1;
                }
                else return 0;
            }
            else
                return 0;
        }

		public void ReadXML()
        {
            OpenFileDialog openXMLDialog = new OpenFileDialog();
            openXMLDialog.Filter = "XML File | *.xml";
            openXMLDialog.Title = "Select a(n) XML file with a list of items";
			ItemDataSet.Clear();
			if (openXMLDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openXMLDialog.FileName;


				this.Text = windowTitle + " - " + sFileName;
                ItemDataSet.ReadXml(sFileName);
                storeGridView.AutoGenerateColumns = false;
                storeGridView.DataSource = ItemDataSet;
                storeGridView.DataMember = "item";
                scGridView.AllowUserToAddRows = false;
                scGridView.AutoGenerateColumns = false;
                
                //set all store item quantities to 0
                for (int row = 0; row < storeGridView.Rows.Count; row++)
                {
                    storeGridView.Rows[row].Cells["storeQuantityCol"].Value = 0;
                }
				calculateButton.Enabled = true;
				generateShopMenuItem.Enabled = true;
				scGridView.Enabled = true;
				storeGridView.Enabled = true;
				disabledLabel1.Enabled = false;
				disabledLabel1.Text = "";
				disabledLabel2.Enabled = false;
				disabledLabel2.Text = "";
				disabledPanel.Visible = false;
				disabledLabel4.Visible = true;
				arrow1label.Visible = false;
				arrow2label.Visible = true;

				this.Activate();

            }

        }

        public DataGridViewRow CloneWithValues(DataGridViewRow row)
        {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
            //index starts at 2 to avoid copying the buy/return and qty columns
            for (Int32 i = 2; i < row.Cells.Count; i++)
            {
                clonedRow.Cells[i].Value = row.Cells[i].Value;
            }
            return clonedRow;
        }
        
        public void BuyFirstItem(int storeItemRowNum)
        {
            //create a new temporary row that clones the values from the store (not including the the first 3 values)
            DataGridViewRow tempRow = (DataGridViewRow) CloneWithValues(storeGridView.Rows[storeItemRowNum]);
            tempRow.Cells[1].Value = 1;
            scGridView.Rows.Add(tempRow);
        	return;
        }
        
        public void HideRowIfZero(int itemRowNum)
        {
        	if((int)storeGridView.Rows[itemRowNum].Cells["storeQuantityCol"].Value <= 0)
        	{
                storeGridView.CurrentCell = null;
                storeGridView.Rows[itemRowNum].Visible = false;
        	}
        }


        private void BuyItemFromStore(int storeItemRowNum)
        {
            //find the name of the item in that row
        	string storeItemName = (string)storeGridView.Rows[storeItemRowNum].Cells["storeItemNameCol"].Value;
			//find the qty of the item in that row
        	int storeItemQty = (int)storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value;

           if(storeItemQty == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please \"Generate Shop\" first before buying items. \n This is just to show that the items XML file loaded properly.");
                return;
            }

            //decrement the qty of the item
            storeItemQty--;
            //update the qty in the row

            storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value = storeItemQty;

            if (scGridView.RowCount==0) //if shopping cart is empty
            {
            	BuyFirstItem(storeItemRowNum);
            	HideRowIfZero(storeItemRowNum);
                calculateButton.PerformClick();
                return;
            }
            else //shopping cart not empty
            {
            	//iterate through the table
            	//initialize the index where a duplicate MIGHT be found
            	int cartItemDuplicateIndex = -1;
            	for(int i = 0; i<scGridView.Rows.Count; i++)
            	{
            		if(storeItemName.Equals(scGridView.Rows[i].Cells["scItemNameCol"].Value))
            		   {
            		   	//use var to find the index of the possible dupe
            		   	cartItemDuplicateIndex = i;
            		   }
            	}
            	if(cartItemDuplicateIndex > -1) //cart not empty, item is a dupe
            	{
                    //add 1 to the qty of cartItemDuplicateIndex's qty
                    int DupeItemQty = (int)scGridView.Rows[cartItemDuplicateIndex].Cells["scQuantityCol"].Value;
                    DupeItemQty++;
                    scGridView.Rows[cartItemDuplicateIndex].Cells["scQuantityCol"].Value = DupeItemQty;
                    HideRowIfZero(storeItemRowNum);
                    calculateButton.PerformClick();
            		   	return;
            	}
	            //shopping cart not empty but did not find duplicate
	            
	            		BuyFirstItem(storeItemRowNum);
	            		HideRowIfZero(storeItemRowNum);
                        calculateButton.PerformClick();
                        return;
            }

        }
        private void ReturnItemToStore(int scItemRowNum)
        {
        	//find the name of the item in the store's item row
        	string scItemName = (string)scGridView.Rows[scItemRowNum].Cells["scItemNameCol"].Value;
        	//find qty of of the item in the store's item row
        	int scItemQty = (int)scGridView.Rows[scItemRowNum].Cells["scQuantityCol"].Value;
        	//decrement qty
        	scItemQty--;
        	//update qty
        	scGridView.Rows[scItemRowNum].Cells["scQuantityCol"].Value = scItemQty;
       		//HideRowIfZero(scItemRowNum);
        	
        	//initialize dupe check index
        	int storeDupeIndex = -1;
        	//iterate through the store to look for duplicates
        	for(int i = 0; i<storeGridView.Rows.Count; i++)
        	{
        		if(scItemName.Equals(storeGridView.Rows[i].Cells["storeItemNameCol"].Value))
        		{
        			storeDupeIndex = i;
        		}
        	}
        	
        	if(storeDupeIndex > -1)
        	{
        		//add 1 to the qty of storeDupeIndex's qty
        		int storeDupeQty = (int) storeGridView.Rows[storeDupeIndex].Cells["storeQuantityCol"].Value;
        		storeDupeQty++;
        		storeGridView.Rows[storeDupeIndex].Cells["storeQuantityCol"].Value = storeDupeQty;
        		storeGridView.Rows[storeDupeIndex].Visible = true;
                calculateButton.PerformClick();

            }
            else //returned item wasn't found in the store...
        		//how'd you get here?
        		return;
            if ((int)scGridView.Rows[scItemRowNum].Cells["scQuantityCol"].Value <= 0)
            {
                scGridView.CurrentCell = null;
                scGridView.Rows.RemoveAt(scItemRowNum);
                calculateButton.PerformClick();

            }
        }
        //clicking on store button or item name for descript method
        private void storeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //check if clicking on the proper column for item name, if not, don't do anything
            string clickedColName = storeGridView.Columns[e.ColumnIndex].Name;
            if (clickedColName == "storeItemNameCol")
            {
				ItemDetails ItemDetailsPop = new ItemDetails();
				ItemDetailsPop.itemnametext.Text = storeGridView.Rows[e.RowIndex].Cells["storeItemNameCol"].Value.ToString();
				ItemDetailsPop.itemtypetext.Text = storeGridView.Rows[e.RowIndex].Cells["storeTypeCol"].Value.ToString();
				ItemDetailsPop.itemraritytext.Text = storeGridView.Rows[e.RowIndex].Cells["storeRarityCol"].Value.ToString();
				ItemDetailsPop.itemweighttext.Text = storeGridView.Rows[e.RowIndex].Cells["storeWeightCol"].Value.ToString();
				ItemDetailsPop.itempricetext.Text = storeGridView.Rows[e.RowIndex].Cells["storePriceCol"].Value.ToString();
				ItemDetailsPop.itemreftext.Text = storeGridView.Rows[e.RowIndex].Cells["storeRefCol"].Value.ToString();
				ItemDetailsPop.itemdescriptext.Text = storeGridView.Rows[e.RowIndex].Cells["storeDescriptionCol"].Value.ToString();
				ItemDetailsPop.ShowDialog();
			}
            if (clickedColName == "storeBuyCol")
            {
                int storeItemRowNum = storeGridView.CurrentCell.RowIndex;
                BuyItemFromStore(storeItemRowNum);
            }

            else
                return;

        }

        public void randomizeQty()
        {
            //ideally, want this button to go row by row:
            // 1. get the rarity from the item
            // 2. generate a random quantity from the rarity
            // 3. set the quantity in the first column to that random quantity
            int numOfRows = storeGridView.RowCount;
            for (int i = 0; i < numOfRows; i++)
            {
                storeGridView.Rows[i].Visible = true;
                string itemRarity = GetItemRarity(i);
                int itemQuantity = SetItemQuantity(itemRarity);
                storeGridView.Rows[i].Cells["storeQuantityCol"].Value = itemQuantity;
                if (itemQuantity == 0)
                {
                    storeGridView.CurrentCell = null;
                    storeGridView.Rows[i].Visible = false;

                }
            }
			disabledLabel4.Visible = false;
			disabledPanel2.Visible = false;
			arrow2label.Visible = false;
        }

        //clicking on sc return or item name for descript method
        private void scGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string clickedColName = scGridView.Columns[e.ColumnIndex].Name;

            if(e.RowIndex<0)
                return;
            else if (clickedColName == "scItemNameCol")
            {
                //build strings for the item details pop up

                ItemDetails ItemDetailsPop = new ItemDetails();
                ItemDetailsPop.itemnametext.Text = scGridView.Rows[e.RowIndex].Cells["scItemNameCol"].Value.ToString();
                ItemDetailsPop.itemtypetext.Text = scGridView.Rows[e.RowIndex].Cells["scTypeCol"].Value.ToString();
                ItemDetailsPop.itemraritytext.Text = scGridView.Rows[e.RowIndex].Cells["scRarityCol"].Value.ToString();
                ItemDetailsPop.itemweighttext.Text = scGridView.Rows[e.RowIndex].Cells["scWeightCol"].Value.ToString();
                ItemDetailsPop.itempricetext.Text = scGridView.Rows[e.RowIndex].Cells["scPriceCol"].Value.ToString();
                ItemDetailsPop.itemreftext.Text = scGridView.Rows[e.RowIndex].Cells["scRefCol"].Value.ToString();
                ItemDetailsPop.itemdescriptext.Text = scGridView.Rows[e.RowIndex].Cells["scDescriptionCol"].Value.ToString();
                ItemDetailsPop.ShowDialog();

            }
            else if (clickedColName == "scReturnCol")
            {
                ReturnItemToStore(e.RowIndex);
            }

            else
                return;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int totalInCart = 0;
            int numOfSCRows = scGridView.RowCount;
            if(numOfSCRows>0)
            {
                for (int i = 0; i < numOfSCRows; i++)
                {
                    int priceInRow = Int32.Parse(scGridView.Rows[i].Cells["scPriceCol"].Value.ToString());
                    int qtyInRow = Int32.Parse(scGridView.Rows[i].Cells["scQuantityCol"].Value.ToString());
                    int totalInRow = priceInRow * qtyInRow;
                    totalInCart += totalInRow;
                }
                scTotalTextBox.Text = totalInCart.ToString();
                try
                {
                    int endingGP = Int32.Parse(startingGPTextBox.Text) - totalInCart;
                    endingGPTextBox.Text = endingGP.ToString();
                    return;
                }
                catch (FormatException f)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a number for \"Starting GP\"!:\n\n" + f);

                }

                return;
            }
            return;
            
        }

        //go to github page when clicked
        private void aboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/garylzimmer/Magic-Shop/");
        }

        // below causes too many pop ups
		//whenever a row is added to the shopping cart, recalculate
        //private void scGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    calculateButton.PerformClick();
       // }
        //whenever a row is removed from the shopping cart, recalculate
        //private void scGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    calculateButton.PerformClick();
        //}

		private void readXMLFileMenuItem_Click(object sender, EventArgs e)
		{
			ReadXML();
		}

		private void generateShopMenuItem_Click(object sender, EventArgs e)
		{
			randomizeQty();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Magic Shop \n version 1.1 \n by Gary Zimmer \n https://github.com/garylzimmer/Magic-Shop/");
			About myAbout = new About();
			myAbout.ShowDialog();

		}

		private void editXMLFileMenuItem_Click(object sender, EventArgs e)
		{
			EditXML myEditXML = new EditXML();
			myEditXML.Show();
		}
	}





}
