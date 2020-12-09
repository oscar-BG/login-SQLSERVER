using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            conexionbd conexion = new conexionbd();

            String consultaUser = "select * from db_owner.usuarioSCHARP where nombreUsuario = " + "'" + txtUsuario.Text + "' and clave = " + "'" + txtPassword.Text + "'";
            SqlCommand comando = new SqlCommand(consultaUser,conexion.conectardb);
            conexion.abrir();
            SqlDataReader lector = comando.ExecuteReader();
            Console.WriteLine(consultaUser);
            if(lector.Read() == true)
            {
                menu mn = new menu();
                mn.ShowDialog();
                conexion.cerrar();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas");
                txtUsuario.Clear();
                txtPassword.Clear();
            }
            conexion.cerrar();
        }

        private void btnNUsuario_Click(object sender, EventArgs e)
        {
            nuevoUsuario nu = new nuevoUsuario();
            nu.ShowDialog();
        }
    }
}
