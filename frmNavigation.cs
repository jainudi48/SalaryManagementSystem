using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(new Form1()).Show();
        }

        private void btnPayFixation_Click(object sender, EventArgs e)
        {
            frmPayFixation FrmPayFixation = new frmPayFixation();
           
        }
    }
}
