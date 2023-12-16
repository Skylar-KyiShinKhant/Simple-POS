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

namespace POS.MasterData
{
    public partial class frm_Supplier : Form
    {
        public frm_Supplier()
        {
            InitializeComponent();
        }

        clsSupplier obj_clsSupplier = new clsSupplier();
        clsMainDB obj_clsMainDB = new clsMainDB();

        String SPString = "";
        public int _SupplierID = 0;
        public bool _IsEdit = false;
        DataTable DT = new DataTable();

        private void frm_Supplier_Load(object sender, EventArgs e)
        {
            String Month = String.Format("{0:D2}", DateTime.Now.Month);
            String Day = String.Format("{0:D2}", DateTime.Now.Day);
            String Year = String.Format("{0:D2}", DateTime.Now.Year);
            lblUpdateDate.Text = Month + "/" + Day + "/" + Year;
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtAddress.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if (txtPhone.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else
            {
                SPString=String.Format("SP_Select_Supplier N'{0}', N'{1}', N'{2}'", txtName.Text.Trim().ToString(), txtAddress.Text.Trim().ToString(), "1");
                DT=obj_clsMainDB.SelectData(SPString);
                if((DT.Rows.Count>0) && (DT.Rows[0]["SupplierID"].ToString()!=_SupplierID.ToString()))
                {
                    MessageBox.Show("This Supplier Is Already Existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    obj_clsSupplier.SID=Convert.ToInt32(_SupplierID);
                    obj_clsSupplier.SNAME=txtName.Text;
                    obj_clsSupplier.ADDRESS=txtAddress.Text;
                    obj_clsSupplier.PHONE=txtPhone.Text;
                    obj_clsSupplier.UPDATE=lblUpdateDate.Text;

                    if(_IsEdit)
                    {
                        obj_clsSupplier.ACTION=1;
                        obj_clsSupplier.SaveData();
                        MessageBox.Show("Successfully Edited", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        obj_clsSupplier.ACTION=0;
                        obj_clsSupplier.SaveData();
                        MessageBox.Show("Successfully Added", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }                
    }
}
