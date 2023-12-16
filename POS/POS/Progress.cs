using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        int init = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (init >= 100)
            {
                init = 0;
                progressBar1.Value = init;
                timer1.Stop();
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                init += 1;
                progressBar1.Value=init;
            }
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
