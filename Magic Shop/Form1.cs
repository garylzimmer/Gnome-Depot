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

        string XMLfilePath = @"C:\Users\Champ66\Desktop\ShopAssist\TestItems.xml";
        private DataSet itemsDS;
        Random rndQty = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {


            itemsDS = new DataSet("ItemDataSet");

            //attempt to load XML path on form load, doesn't work, don't know why
            itemsDS.ReadXml(XMLfilePath);

            //attempt to turn off autogenerating columns, doesn't work, don't know why
            storeGridView.AutoGenerateColumns = false;
            storeGridView.DataSource = ItemDataSet;
            storeGridView.DataMember = "item";
            DataGridViewLinkColumn itemColumn = new DataGridViewLinkColumn();
            itemColumn.DataPropertyName = "name";
            itemColumn.HeaderText = "Item Name";
            storeGridView.AllowUserToAddRows = false;
            scGridView.AllowUserToAddRows = false;
            scGridView.AutoGenerateColumns = false;

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
                int Qty = rndQty.Next(5, 10);
                return Qty;
            }

            if (Rarity == "Uncommon")
            {

                int Qty = rndQty.Next(0, 5);
                return Qty;
            }
            else
                return 0;
        }

        private void ReadXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openXMLDialog = new OpenFileDialog();
            openXMLDialog.Filter = "XML File | *.xml";
            openXMLDialog.Title = "Select a(n) XML file with a list of items";
            if (openXMLDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openXMLDialog.FileName;


                //XMLfilePath = openXMLDialog.FileName;
                FilePathTextBox.Text = sFileName;
                ItemDataSet.ReadXml(sFileName);
                storeGridView.AutoGenerateColumns = false;
                storeGridView.DataSource = ItemDataSet;
                storeGridView.DataMember = "item";
                ReadXMLButton.Enabled = false;
                scGridView.AllowUserToAddRows = false;
                scGridView.AutoGenerateColumns = false;
                
                //set all store item quantities to 0
                for (int row = 0; row < storeGridView.Rows.Count; row++)
                {
                    storeGridView.Rows[row].Cells["storeQuantityCol"].Value = 0;
                }
                    
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
        	DataGridViewRow tempRow = (DataGridViewRow) CloneWithValues(storeGridView.Row(storeItemRowNum));
        	scGridView.AddRow();
        	scGridView.row[scGridView.RowCount - 1] = tempRow;
        	scGridView.row[scGridView.RowCount - 1].Cell["scQuantity"].Value = 1;
        	return;
        }
        
        public void HideRowIfZero(int itemRowNum)
        {
        	if(storeGridView.Rows[itemRowNum].Cells["storeQuantityCol"] <= 0)
        	{
        		storeGridView.Rows[itemRowNum].Cells["storeQuantityCol"].Visible = False;
        	}
        }


        private void BuyItemFromStore(int storeItemRowNum)
        {
            //find the name of the item in that row
        	string storeItemName = (string)storeGridView.Rows[storeItemRowNum].Cells["storeItemNameCol"].Value;
			//find the qty of the item in that row
        	int storeItemQty = (int)storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value;
			//decrement the qty of the item
        	storeItemQty--;
        	//update the qty in the row
        
            storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value = storeItemQty;
           
            if(scGridView.Rows[0]==null) //if shopping cart is empty
            {
            	BuyFirstItem(storeItemRowNum);
            	HideRowIfZero(storeItemRowNum);
            	return;
            }
            else //shopping cart not empty
            {
            	//iterate through the table
            	//initialize the index where a duplicate MIGHT be found
            	int cartItemDuplicateIndex = -1;
            	for(int i = 0; i<scGridView.Rows.Count; i++;)
            	{
            		if(storeItemName.Equals(scGridView.Rows[i].Cells["scItemNameCol"].Value)
            		   {
            		   	//use var to find the index of the possible dupe
            		   	cartItemDuplicateIndex = i;
            		   }
            	}
            	if(cartItemDuplicateIndex > -1) //cart not empty, item is a dupe
            	{
            		   	//add 1 to the qty of cartItemDuplicateIndex's qty
            		   	HideRowIfZero(storeItemRowNum);
            		   	return;
            	}
	            //shopping cart not empty but did not find duplicate
	            
	            		BuyFirstItem(storeItemRowNum);
	            		HideRowIfZero(storeItemRow);
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
        		int storeDupeQty = storeGridView.Rows[storeDupeIndex].Cells["storeQuantity"].Value;
        		storeDupeQty++;
        		storeGridView.Rows[storeDupeIndex].Cells["storeQuantity"].Value = storeDupeQty;
        		storeGridView.Rows[storeDupeIndex].Visible = True;
        		return;
        	}
        	else //returned item wasn't found in the store...
        		//how'd you get here?
        		return;
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
                string clickedItemDescrip = (string)storeGridView.Rows[e.RowIndex].Cells["storeDescriptionCol"].Value;
                System.Windows.Forms.MessageBox.Show(clickedItemDescrip);
            }
            if (clickedColName == "storeBuyCol")
            {
                int storeItemRowNum = storeGridView.CurrentCell.RowIndex;
                BuyItemFromStore(storeItemRowNum);
            }

            else
                return;

        }

        private void randomizeQty_Click(object sender, EventArgs e)
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
        }

        //clicking on sc return or item name for descript method
        private void scGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string clickedColName = scGridView.Columns[e.ColumnIndex].Name;

            if(e.RowIndex<0)
                return;
            else if (clickedColName == "scItemNameCol")
            {
                string clickedItemDescrip = (string)scGridView.Rows[e.RowIndex].Cells["scDescriptionCol"].Value;
                System.Windows.Forms.MessageBox.Show(clickedItemDescrip);
            }
            else if (clickedColName == "scReturnCol")
            {
                string scReturnItemName = (string)scGridView.Rows[e.RowIndex].Cells["scItemNameCol"].Value;
                ReturnItemToStore(scReturnItemName);
            }

            else
                return;

        }

    }





}
