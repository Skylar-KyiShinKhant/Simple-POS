namespace POS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfitLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tomato;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMasterData,
            this.mnuProcess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1590, 79);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.Tomato;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogIn,
            this.mnuExit});
            this.mnuFile.ForeColor = System.Drawing.Color.Yellow;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(122, 75);
            this.mnuFile.Text = "File";
            // 
            // mnuLogIn
            // 
            this.mnuLogIn.BackColor = System.Drawing.Color.Tomato;
            this.mnuLogIn.ForeColor = System.Drawing.Color.Yellow;
            this.mnuLogIn.Name = "mnuLogIn";
            this.mnuLogIn.Size = new System.Drawing.Size(251, 76);
            this.mnuLogIn.Text = "LogIn";
            this.mnuLogIn.Click += new System.EventHandler(this.mnuLogIn_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuExit.ForeColor = System.Drawing.Color.Yellow;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(251, 76);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuMasterData
            // 
            this.mnuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem,
            this.mnuSupplier,
            this.mnuUser});
            this.mnuMasterData.ForeColor = System.Drawing.Color.Yellow;
            this.mnuMasterData.Name = "mnuMasterData";
            this.mnuMasterData.Size = new System.Drawing.Size(327, 75);
            this.mnuMasterData.Text = "Master Data";
            // 
            // mnuItem
            // 
            this.mnuItem.BackColor = System.Drawing.Color.Tomato;
            this.mnuItem.ForeColor = System.Drawing.Color.Yellow;
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(312, 76);
            this.mnuItem.Text = "Item";
            this.mnuItem.Click += new System.EventHandler(this.mnuItem_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuSupplier.ForeColor = System.Drawing.Color.Yellow;
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(312, 76);
            this.mnuSupplier.Text = "Supplier";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuUser
            // 
            this.mnuUser.BackColor = System.Drawing.Color.Tomato;
            this.mnuUser.ForeColor = System.Drawing.Color.Yellow;
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(312, 76);
            this.mnuUser.Text = "User";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // mnuProcess
            // 
            this.mnuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurchase,
            this.mnuSale,
            this.mnuProfitLoss});
            this.mnuProcess.ForeColor = System.Drawing.Color.Yellow;
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(217, 75);
            this.mnuProcess.Text = "Process";
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.BackColor = System.Drawing.Color.Tomato;
            this.mnuPurchase.ForeColor = System.Drawing.Color.Yellow;
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(472, 76);
            this.mnuPurchase.Text = "Purchase";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // mnuSale
            // 
            this.mnuSale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuSale.ForeColor = System.Drawing.Color.Yellow;
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(472, 76);
            this.mnuSale.Text = "Sale";
            this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
            // 
            // mnuProfitLoss
            // 
            this.mnuProfitLoss.BackColor = System.Drawing.Color.Tomato;
            this.mnuProfitLoss.ForeColor = System.Drawing.Color.Yellow;
            this.mnuProfitLoss.Name = "mnuProfitLoss";
            this.mnuProfitLoss.Size = new System.Drawing.Size(472, 76);
            this.mnuProfitLoss.Text = "Profit And Loss";
            this.mnuProfitLoss.Click += new System.EventHandler(this.mnuProfitLoss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(889, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1655, 334);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point of Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(1000, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(989, 334);
            this.label2.TabIndex = 2;
            this.label2.Text = "System";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1590, 982);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Point of Sale System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLogIn;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterData;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuProcess;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuProfitLoss;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

