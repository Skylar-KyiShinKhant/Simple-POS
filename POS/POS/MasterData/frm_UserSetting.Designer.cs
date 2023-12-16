namespace POS.MasterData
{
    partial class frm_UserSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUserLevel = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(69, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(69, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(69, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(69, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update Date :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUserName.Location = new System.Drawing.Point(604, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(453, 68);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPassword.Location = new System.Drawing.Point(604, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(453, 68);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(604, 295);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(453, 68);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblUpdateDate.Location = new System.Drawing.Point(604, 402);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(453, 64);
            this.lblUpdateDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(1096, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 63);
            this.label5.TabIndex = 8;
            this.label5.Text = "User Level :";
            // 
            // chkUserLevel
            // 
            this.chkUserLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkUserLevel.FormattingEnabled = true;
            this.chkUserLevel.Location = new System.Drawing.Point(1450, 88);
            this.chkUserLevel.Name = "chkUserLevel";
            this.chkUserLevel.Size = new System.Drawing.Size(522, 445);
            this.chkUserLevel.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(674, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(299, 78);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnClose.ForeColor = System.Drawing.Color.Yellow;
            this.BtnClose.Location = new System.Drawing.Point(1138, 585);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(299, 78);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frm_UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2070, 771);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkUserLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 400);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UserSetting";
            this.Text = "User Setting";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frm_UserSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox chkUserLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}