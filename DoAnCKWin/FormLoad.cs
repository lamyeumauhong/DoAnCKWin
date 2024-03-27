using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCKWin
{
    public partial class FormLoad : Form
    {
        
        public FormLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progessbar.Value < 100)
            {
                progessbar.Value += 1;
                label.Text = progessbar.Value.ToString() + "%";
                
            }
            else
            {
                timer1.Stop();
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            
        }

        private void progessbar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
