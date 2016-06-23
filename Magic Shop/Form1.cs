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


        private void BuyItemFromStore(int storeItemRowNum)
        {
            string storeItemName = (string)storeGridView.Rows[storeItemRowNum].Cells["storeItemNameCol"].Value;
            string searchedSCItemName = "place holder";
            int scRow = 0;

            if (scGridView.CurrentCell != null)
            {
                for (scRow = 0; scGridView.Rows[scRow]; scRow++)
                {
                    //store the name of the item in the iterated row

                    System.Windows.Forms.MessageBox.Show("Searching for " + searchedSCItemName);


                }
                //check if we already have an item with that name in shopping cart
                if (storeItemName.Equals(searchedSCItemName))
                {
                    //if we do, tell us about the match
                    System.Windows.Forms.MessageBox.Show("Found that: Store's " + storeItemName + " matches Shopping Cart's " + searchedSCItemName);
                    //now that we know that the item appears in both the store and the shopping cart

                    //find the quantity that we already have in the shopping cart of that item
                    int scItemQty = (int)scGridView.Rows[scRow].Cells["scQuantityCol"].Value;
                    //increment the quantity
                    scItemQty++;
                    //update the quantity
                    scGridView.Rows[scRow].Cells["scQuantityCol"].Value = scItemQty;

                }
                System.Windows.Forms.MessageBox.Show("Did not find that item in the shopping cart");
                //if we don't find the bought item from the store in the shopping cart...
                //make new row variable that clones the store item's row
                DataGridViewRow newSCRow = CloneWithValues(storeGridView.Rows[storeItemRowNum]);
                //add that row to the end of the shopping cart table
                scGridView.Rows.Add(newSCRow);
                //set the qty of that item's row to 1
                scGridView[1, scGridView.RowCount - 1].Value = 1;
                //find the qty of the item in the store
                System.Windows.Forms.MessageBox.Show("Passed the for and if else loops");
                int storeItemQty = (int)storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value;
                //decrement it
                storeItemQty--;
                //update qty
                storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value = storeItemQty;

                if (storeItemQty <= 0)
                {
                    storeGridView.CurrentCell = null;
                    storeGridView.Rows[storeItemRowNum].Visible = false;
                }
            }
        }
        private void ReturnItemToStore(string scItemName)
        {
            //iterate through the store's rows
            for (int storeRow = 0; storeRow<storeGridView.Rows.Count; storeRow++)
            {
                //store the iterated row's item name
                string searchedStoreItemName = (string) storeGridView.Rows[storeRow].Cells["storeItemNameCol"].Value;
                if(scItemName.Equals(searchedStoreItemName))
                {
                    System.Windows.Forms.MessageBox.Show("Found that: Shopping Cart's " + scItemName + " matches Store's " + searchedStoreItemName);
                    //get row for the found store item based on iterated row and item name col
                    int foundStoreItemRowIndex = storeGridView.Rows[storeRow].Cells["storeItemNameCol"].RowIndex;
                    
                    //get int qty of found store item based on above and quantity col
                    int foundStoreItemQty = (int)storeGridView.Rows[foundStoreItemRowIndex].Cells["storeQuantityCol"].Value;
                    //increment store item qty value
                    foundStoreItemQty++;
                    //update store item qty value
                    storeGridView.Rows[foundStoreItemRowIndex].Cells["storeQuantityCol"].Value = foundStoreItemQty;
                    storeGridView.Rows[storeRow].Visible = true;

                    //find row of the sc item
                    for (int scRow = 0; scRow < scGridView.Rows.Count; scRow++)
                    {
                        if (scItemName.Equals(scGridView.Rows[scRow].Cells["scItemNameCol"].Value))
                        {
                            //from scRow, get the quantity of the item
                            int scItemQty = (int)scGridView.Rows[scRow].Cells["scQuantityCol"].Value;
                            //decrement qty
                            scItemQty--;
                            //update qty in cell
                            scGridView.Rows[scRow].Cells["scQuantityCol"].Value = scItemQty;

                            //hide scRow if qty <=0
                            if(scItemQty<=0)
                            {
                                scGridView.CurrentCell = null;
                                scGridView.Rows[scRow].Visible = false;
                            }

                            
                        }
                    }
                }

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
