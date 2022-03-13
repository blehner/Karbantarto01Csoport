using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karbantarto01Csoport
{
    public partial class Admistrator : Form
    {
        public Admistrator()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rendszertervezés korsz. módszerei: 1. Csoport\n\n Szerzők:\n\n Stéber Gábor\n Lehner Béla", "Informáciás ablak", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
