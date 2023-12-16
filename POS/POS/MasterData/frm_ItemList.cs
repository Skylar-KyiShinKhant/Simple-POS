using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DBA;
//using POS.Report;

namespace POS.MasterData
{
    public partial class frm_ItemList : Form
    {
        public frm_ItemList()
        {
            InitializeComponent();
        }

        clsItem obj_clsItem = new clsItem();
        clsMainDB obj_clsMainDB = new clsMainDB();
        String SPString = "";
        DataTable DT = new DataTable();

        private void ShowData()
        {
            SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            dgvItem.DataSource = obj_clsMainDB.SelectData(SPString);

            dgvItem.Columns[0].Width = (dgvItem.Width / 100) * 10;
            dgvItem.Columns[1].Visible = false;
            dgvItem.Columns[2].Width = (dgvItem.Width / 100) * 40;
            dgvItem.Columns[3].Width = (dgvItem.Width / 100) * 10;
            dgvItem.Columns[4].Width = (dgvItem.Width / 100) * 10;
            dgvItem.Columns[5].Width = (dgvItem.Width / 100) * 30;

            obj_clsMainDB.ToolStripTextBoxData(ref tstSearchWith, SPString, "ItemName");
            tslLabel.Text = "ItemName";
        }

        private void ShowEntry()
        {
            if (dgvItem.CurrentRow.Cells[0].Value.ToString() == String.Empty)
            {
                MessageBox.Show("There Is No Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm_Item frm = new frm_Item();
                frm._ItemID = Convert.ToInt32(dgvItem.CurrentRow.Cells["ItemID"].Value.ToString());
                frm.txtItemName.Text = dgvItem.CurrentRow.Cells["ItemName"].Value.ToString();
                frm.txtQty.Text = dgvItem.CurrentRow.Cells["Qty"].Value.ToString();
                frm.txtPrice.Text = dgvItem.CurrentRow.Cells["Price"].Value.ToString();
                frm._IsEdit = true;
                frm.ShowDialog();
                ShowData();
            }
        }

        private void frm_ItemList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frm_Item frm = new frm_Item();
            frm.ShowDialog();
            ShowData();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            String ItemID = dgvItem.CurrentRow.Cells["ItemID"].Value.ToString();
            if (ItemID == String.Empty)
            {
                MessageBox.Show("There Is No Data.");
            }
            else if(dgvItem.CurrentRow.Cells["Qty"].Value.ToString() != "0")
            {
                MessageBox.Show("This Item Has Qty. Cannot Be Deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    obj_clsItem.ITEMID = Convert.ToInt32(ItemID);
                    obj_clsItem.ACTION = 2;
                    obj_clsItem.SaveData();
                    MessageBox.Show("Successfully Deleted","Successfully", MessageBoxButtons.OK);
                    ShowData();
                }
            }
        }

        private void tsmItemName_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Item Name";
            SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.ToolStripTextBoxData(ref tstSearchWith, SPString, "ItemName");
        }

        private void tsmQty_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Qty";
            SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.ToolStripTextBoxData(ref tstSearchWith, SPString, "Qty");
        }

        private void tsmPrice_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Price";
            SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.ToolStripTextBoxData(ref tstSearchWith, SPString, "Price");
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            if (tslLabel.Text == "Item Name")
            {
                SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", tstSearchWith.Text.Trim().ToString(), "0", "2");
            }
            else if(tslLabel.Text == "Qty")
            {
                SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", tstSearchWith.Text.Trim().ToString(), "0", "3");
            }
            else if(tslLabel.Text == "Price")
            {
                SPString = String.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", tstSearchWith.Text.Trim().ToString(), "0", "4");
            }
            dgvItem.DataSource = obj_clsMainDB.SelectData(SPString);
        }

    }
}
