using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexionSQL
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarUsu mu = new modificarUsu();
            mu.ShowDialog();
        }
    }
}
