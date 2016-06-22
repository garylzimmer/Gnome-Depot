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
            //take one from the quantiy
            int storeItemQty = (int)storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value;
            storeItemQty--;
            string boughtItemMsg = "You have purchased 1 " + storeItemName + ". There is/are " + storeItemQty + "remaining.";
            System.Windows.Forms.MessageBox.Show(boughtItemMsg);
            storeGridView.Rows[storeItemRowNum].Cells["storeQuantityCol"].Value = storeItemQty;
            //hide row if qty <= 0
            if (storeItemQty <= 0)
            {
                storeGridView.CurrentCell = null;
                storeGridView.Rows[storeItemRowNum].Visible = false;
            }
            //add to shopping cart

            //first check if any same named items are in SC
            for (int row = 0; row < scGridView.Rows.Count; row++)
            {
                if (storeItemName == (string)scGridView.Rows[row].Cells["scItemNameCol"].Value)
                {
                    int dupeQty = (int)scGridView[1, row].Value;
                    dupeQty++;
                    scGridView[1, row].Value = dupeQty;
                    System.Windows.Forms.MessageBox.Show("Duplicate Loop");

                    return;
                }
            }

            System.Windows.Forms.MessageBox.Show("No Dupe Loop");

            DataGridViewRow newSCRow = CloneWithValues(storeGridView.Rows[storeItemRowNum]);
            scGridView.Rows.Add(newSCRow);
            scGridView[1, scGridView.RowCount - 1].Value = 1;
            return;
            //string[] newrow = new string[] { "return", "qty", "item text", "item descript" };
            //scGridView.Rows.Add(newrow);

            //this is all assuming that the added row is unique and is therefore added to the end of the list


        }

        private void ReturnItemToStore(int scItemRowNum)
        {
            //get sc item name from row number
            object scItemName = scGridView.Rows[scItemRowNum].Cells["scItemNameCol"].Value;
            System.Windows.Forms.MessageBox.Show("You have returned " + scItemName + " to the shop inventory.");
            int scItemQty = (int)scGridView.Rows[scItemRowNum].Cells["scQuantityCol"].Value;
            //decrement sc item qty
            scItemQty--;
            //update sc item qty in list
            scGridView.Rows[scItemRowNum].Cells["scQuantityCol"].Value = scItemQty;
            //check if sc item qty is <=0, if so remove row
            if (scItemQty <= 0)
            {
                scGridView.Rows.RemoveAt(scItemRowNum);
            }
            //check if returned item matches any items in the store list,
            //if so, increment matched store item qty
            //else add row from SC back to store and make qty = 1
            for (int row = 0; row < storeGridView.Rows.Count; row++)
            {
                if (scItemName == (string)storeGridView.Rows[row].Cells["storeItemNameCol"].Value)
                {
                    int dupeQty = (int)storeGridView[1, row].Value;
                    dupeQty++;
                    scGridView[1, row].Value = dupeQty;
                    return;
                }
                else
                {
                    DataGridViewRow newStoreRow = CloneWithValues(scGridView.Rows[scItemRowNum]);
                    storeGridView.Rows.Add(newStoreRow);
                    storeGridView[1, storeGridView.RowCount - 1].Value = 1;
                    return;
                }
            }
            if (scItemQty <= 0)
            {
                scGridView.Rows.RemoveAt(scItemRowNum);
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
            if (clickedColName == "scItemNameCol")
            {
                string clickedItemDescrip = (string)scGridView.Rows[e.RowIndex].Cells["scDescriptionCol"].Value;
                System.Windows.Forms.MessageBox.Show(clickedItemDescrip);
            }
            if (clickedColName == "scReturnCol")
            {
                int scReturnItemRowNum = storeGridView.Columns[e.RowIndex].Index;
                ReturnItemToStore(scReturnItemRowNum);
            }

            else
                return;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void storeBox_Enter(object sender, EventArgs e)
        {

        }

        private void scBox_Enter(object sender, EventArgs e)
        {

        }
    }





}
