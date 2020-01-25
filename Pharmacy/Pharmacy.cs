using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine adm = new AddMedicine();
            adm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
