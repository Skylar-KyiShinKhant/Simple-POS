﻿using System;
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
    public partial class frm_UserSettingList : Form
    {
        public frm_UserSettingList()
        {
            InitializeComponent();
        }

        clsMainDB obj_clsMainDB = new clsMainDB();
        clsUserSetting obj_clsUserSetting = new clsUserSetting();
        frm_UserSetting frm = new frm_UserSetting();
        String SPString = "";

        private void ShowData()
        {
            SPString = string.Format("SP_Select_UserSetting N'{0}', N'{1}', N'{2}'", "0", "0", "0");
            dgvUserSetting.DataSource = obj_clsMainDB.SelectData(SPString);

            dgvUserSetting.Columns[0].Width = (dgvUserSetting.Width / 100) * 5;
            dgvUserSetting.Columns[1].Visible = false;
            dgvUserSetting.Columns[2].Width = (dgvUserSetting.Width / 100) * 30;
            dgvUserSetting.Columns[3].Visible = false;
            dgvUserSetting.Columns[4].Width = (dgvUserSetting.Width / 100) * 45;
            dgvUserSetting.Columns[5].Width = (dgvUserSetting.Width / 100) * 20;

            obj_clsMainDB.ToolStripTextBoxData(ref tstSearchWith, SPString, "UserName");
        }

        private void ShowEntry()
        {
            if (dgvUserSetting.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There Is No Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm.UserID = Convert.ToInt32(dgvUserSetting.CurrentRow.Cells["UserID"].Value.ToString());
                frm.txtUserName.Text = dgvUserSetting.CurrentRow.Cells["UserName"].Value.ToString();
                frm.txtPassword.Text = dgvUserSetting.CurrentRow.Cells["Password"].Value.ToString();
                frm.txtConfirmPassword.Text = dgvUserSetting.CurrentRow.Cells["Password"].Value.ToString();
                frm.UserLevel = dgvUserSetting.CurrentRow.Cells["UserLevel"].Value.ToString();
                frm._IsEdit = true;
                frm.ShowDialog();
                ShowData();
            }
        }
        private void frm_UserSettingList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            ShowData();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void dgvUserSetting_DoubleClick(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvUserSetting.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There Is No Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obj_clsUserSetting.USERID = Convert.ToInt32(dgvUserSetting.CurrentRow.Cells["UserID"].Value.ToString());
                    obj_clsUserSetting.ACTION = 2;
                    obj_clsUserSetting.SaveData();
                    MessageBox.Show("Successfully Deleted","Successfully",MessageBoxButtons.OK);
                    ShowData();
                }
            }
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            SPString = String.Format("SP_Select_UserSetting N'{0}', N'{1}', N'{2}'", tstSearchWith.Text.Trim().ToString(), "0", "2");
            dgvUserSetting.DataSource = obj_clsMainDB.SelectData(SPString);
        }
    }
}
