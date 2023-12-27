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

namespace POS.Purchase
{
    public partial class frm_Purchase : Form
    {
        clsPurchase obj_clsPurchase = new clsPurchase();
        clsPurchaseDetail obj_clsPurchaseDetail = new clsPurchaseDetail();
        clsItem obj_clsItem = new clsItem();
        clsMainDB obj_clsMainDB = new clsMainDB();

        DataTable DT = new DataTable();
        DataTable DTPurchase = new DataTable();
        int _PurchaseID = 0;
        String SPString = "";
        int Count = 0;

        public frm_Purchase()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CreateTable()
        {
            DTPurchase.Rows.Clear();
            DTPurchase.Columns.Clear();
            DTPurchase.Columns.Add("ItemID");
            DTPurchase.Columns.Add("ItemName");
            DTPurchase.Columns.Add("Qty");
            DTPurchase.Columns.Add("Price");
            DTPurchase.Columns.Add("Total");
            dgvPurchase.DataSource = DTPurchase;
            dgvPurchase.Columns[0].Width = dgvPurchase.Width / 100 * 15;
            dgvPurchase.Columns[1].Width = dgvPurchase.Width / 100 * 20;
            dgvPurchase.Columns[2].Width = dgvPurchase.Width / 100 * 20;
            dgvPurchase.Columns[3].Width = dgvPurchase.Width / 100 * 20;
            dgvPurchase.Columns[4].Width = dgvPurchase.Width / 100 * 20;
        }

        public void ShowData()
        {
            SPString = string.Format("SP_Select_Supplier N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.AddCombo(ref cboSupplier, SPString, "SupplierName", "SupplierID");

            SPString = string.Format("SP_Select_Item N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.AddCombo(ref cboItem, SPString, "ItemName", "ItemID");

            SPString = string.Format("SP_Select_UserSetting N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            obj_clsMainDB.AddCombo(ref cboStaff, SPString, "UserName", "UserID");
        }

        private void frm_Purchase_Load(object sender, EventArgs e)
        {
            CreateTable();
            ShowData();
        }

        private void CalculateTotal()
        {
            int Total = 0;
            if (DTPurchase.Rows.Count > 0)
            {
                foreach (DataRow DR in DTPurchase.Rows)
                {
                    Total += Convert.ToInt32(DR["Total"]);
                }
            }
            lblTotalAmount.Text = Total.ToString();
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQty.Text = "";
            txtPrice.Text = "";
            txtQty.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Ok = 0;
            if (Convert.ToInt32(cboItem.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboItem.Focus();
            }
            else if (txtQty.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Qty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
            }
            else if (int.TryParse(txtQty.Text, out Ok) == false)
            {
                MessageBox.Show("Qty Should Be Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
                txtQty.SelectAll();
            }
            else if (Convert.ToInt32(txtQty.Text.Trim().ToString()) <= 0 || Convert.ToInt32(txtQty.Text.Trim().ToString()) > 10000)
            {
                MessageBox.Show("Qty Should Be Between 1 And 10 Thounsand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
                txtQty.SelectAll();
            }
            else if (txtPrice.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
            }
            else if (int.TryParse(txtPrice.Text, out Ok) == false)
            {
                MessageBox.Show("Price Should Be Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
            else if (Convert.ToInt32(txtPrice.Text.Trim().ToString()) < 1 || Convert.ToInt32(txtPrice.Text.Trim().ToString()) > 10000)
            {
                MessageBox.Show("Price Should Be Between 1 And 10000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
            else
            {
                if (DTPurchase.Rows.Count > 0)
                {
                    DataRow[] Arr_DR = DTPurchase.Select("ItemID='" + cboItem.SelectedValue.ToString() + "'");
                    Count = Arr_DR.Length;
                    if (Count != 0)
                    {
                        MessageBox.Show("This Record Is Already Existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataRow DR = DTPurchase.NewRow();
                DR["ItemID"] = cboItem.SelectedValue.ToString();
                DR["ItemName"] = cboItem.Text;
                DR["Qty"] = txtQty.Text;
                DR["Price"] = txtPrice.Text;
                DR["Total"] = Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text);
                DTPurchase.Rows.Add(DR);
                dgvPurchase.DataSource = DTPurchase;
                cboItem.SelectedIndex = 0;
                CalculateTotal();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DTPurchase.Rows.Count <= 0)
            {
                MessageBox.Show("There Is No Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow[] Arr_DR = DTPurchase.Select("ItemID='" + dgvPurchase.CurrentRow.Cells["ItemID"].Value.ToString() + "'");
                DataRow DR = Arr_DR[0];
                DR.Delete();
                dgvPurchase.DataSource = DTPurchase;
                CalculateTotal();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SPString = string.Format("SP_Select_Purchase N'{0}', N'{1}', N'{2}'", dtpDate.Text, "0", "2");
            DT = obj_clsMainDB.SelectData(SPString);
            int DateDiff = Convert.ToInt32(DT.Rows[0]["No"]);
            if (DateDiff > 0)
            {
                MessageBox.Show("Please Check Purchase Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Text = DateTime.Now.ToShortDateString();
            }
            else if (DateDiff <= -7)
            {
                MessageBox.Show("Please Check Purchase Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please Choose Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSupplier.Focus();
            }
            else if (cboStaff.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please Choose Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStaff.Focus();
            }
            else if (DTPurchase.Rows.Count <= 0)
            {
                MessageBox.Show("There Is No Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                obj_clsPurchase.PDATE = dtpDate.Text;
                obj_clsPurchase.SUPID = Convert.ToInt32(cboSupplier.SelectedValue.ToString());
                obj_clsPurchase.TOTALAMT = Convert.ToInt32(lblTotalAmount.Text);
                obj_clsPurchase.USERID = Convert.ToInt32(cboStaff.SelectedValue.ToString());
                obj_clsPurchase.ACTION = 0;
                obj_clsPurchase.SaveData();

                SPString = string.Format("SP_Select_Purchase N'{0}', N'{1}', N'{2}'", "0", "0", "1");
                DT = obj_clsMainDB.SelectData(SPString);
                _PurchaseID = Convert.ToInt32(DT.Rows[0]["PurchaseID"].ToString());

                for (int i = 0; i < DTPurchase.Rows.Count; i++)
                {
                    obj_clsPurchaseDetail.PID = _PurchaseID;
                    obj_clsPurchaseDetail.ITEMID = DTPurchase.Rows[i]["ItemID"].ToString();
                    obj_clsPurchaseDetail.PQTY = Convert.ToInt32(DTPurchase.Rows[i]["Qty"].ToString());
                    obj_clsPurchaseDetail.PPRICE = Convert.ToInt32(DTPurchase.Rows[i]["Price"].ToString());
                    obj_clsPurchaseDetail.ACTION = 0;
                    obj_clsPurchaseDetail.SaveData();

                    obj_clsItem.ITEMID = Convert.ToInt32(DTPurchase.Rows[i]["ItemID"].ToString());
                    obj_clsItem.QTY = Convert.ToInt32(DTPurchase.Rows[i]["Qty"].ToString());
                    obj_clsItem.PRICE = Convert.ToInt32(DTPurchase.Rows[i]["Price"].ToString());
                    obj_clsItem.ACTION = 3;
                    obj_clsItem.SaveData();
                }
                MessageBox.Show("Successfully Saved", "Successfully", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
