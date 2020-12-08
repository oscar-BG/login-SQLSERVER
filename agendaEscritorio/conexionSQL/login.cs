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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.ShowDialog();
        }

        private void btnNUsuario_Click(object sender, EventArgs e)
        {
            nuevoUsuario nu = new nuevoUsuario();
            nu.ShowDialog();
        }
    }
}
