namespace POS.Sale
{
    partial class frm_Sale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sale));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuNew_Click = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPayment_Click = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave_Click = new System.Windows.Forms.ToolStripLabel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleVoucher = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuPayment,
            this.mnuSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 142);
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuNew.Size = new System.Drawing.Size(260, 46);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click_1);
            // 
            // mnuPayment
            // 
            this.mnuPayment.Name = "mnuPayment";
            this.mnuPayment.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuPayment.Size = new System.Drawing.Size(260, 46);
            this.mnuPayment.Text = "Payment";
            this.mnuPayment.Click += new System.EventHandler(this.mnuPayment_Click_1);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuSave.Size = new System.Drawing.Size(260, 46);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Tomato;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew_Click,
            this.toolStripSeparator1,
            this.mnuPayment_Click,
            this.toolStripSeparator2,
            this.mnuSave_Click});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2655, 75);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuNew_Click
            // 
            this.mnuNew_Click.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuNew_Click.ForeColor = System.Drawing.Color.Yellow;
            this.mnuNew_Click.Name = "mnuNew_Click";
            this.mnuNew_Click.Size = new System.Drawing.Size(451, 72);
            this.mnuNew_Click.Text = "New Voucher (F1)";
            this.mnuNew_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 75);
            // 
            // mnuPayment_Click
            // 
            this.mnuPayment_Click.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuPayment_Click.ForeColor = System.Drawing.Color.Yellow;
            this.mnuPayment_Click.Name = "mnuPayment_Click";
            this.mnuPayment_Click.Size = new System.Drawing.Size(337, 72);
            this.mnuPayment_Click.Text = "Payment (F2)";
            this.mnuPayment_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 75);
            // 
            // mnuSave_Click
            // 
            this.mnuSave_Click.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuSave_Click.ForeColor = System.Drawing.Color.Yellow;
            this.mnuSave_Click.Name = "mnuSave_Click";
            this.mnuSave_Click.Size = new System.Drawing.Size(242, 72);
            this.mnuSave_Click.Text = "Save (F3)";
            this.mnuSave_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSale
            // 
            this.dgvSale.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSale.Location = new System.Drawing.Point(61, 200);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowTemplate.Height = 40;
            this.dgvSale.Size = new System.Drawing.Size(1788, 684);
            this.dgvSale.TabIndex = 2;
            this.dgvSale.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellEnter);
            this.dgvSale.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSale_EditingControlShowing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(131, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sale Voucher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(1100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(1872, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(1872, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 63);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tax :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(1872, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 63);
            this.label5.TabIndex = 7;
            this.label5.Text = "Grand Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(1872, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 63);
            this.label6.TabIndex = 8;
            this.label6.Text = "Payment :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(1872, 768);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 63);
            this.label7.TabIndex = 9;
            this.label7.Text = "Change :";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPayment.Location = new System.Drawing.Point(2275, 631);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(309, 68);
            this.txtPayment.TabIndex = 10;
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1318, 100);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(346, 68);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblSaleVoucher
            // 
            this.lblSaleVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaleVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSaleVoucher.Location = new System.Drawing.Point(571, 100);
            this.lblSaleVoucher.Name = "lblSaleVoucher";
            this.lblSaleVoucher.Size = new System.Drawing.Size(394, 64);
            this.lblSaleVoucher.TabIndex = 12;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(2275, 228);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(309, 68);
            this.lblTotalAmount.TabIndex = 13;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTax.Location = new System.Drawing.Point(2275, 366);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(309, 68);
            this.lblTax.TabIndex = 14;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblGrandTotal.Location = new System.Drawing.Point(2275, 501);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(309, 68);
            this.lblGrandTotal.TabIndex = 15;
            // 
            // lblRefund
            // 
            this.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRefund.Location = new System.Drawing.Point(2275, 767);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(309, 68);
            this.lblRefund.TabIndex = 16;
            // 
            // frm_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2655, 961);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblSaleVoucher);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Sale";
            this.Text = "Sale Voucher";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frm_Sale_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel mnuNew_Click;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel mnuPayment_Click;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel mnuSave_Click;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSaleVoucher;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblRefund;
    }
}
