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
    public partial class nuevoUsuario : Form
    {   
        string tipoCuenta;
        string fechaNac;
        public nuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Cadena para conectarnos al servidor
            SqlConnection cadenaConexion = new SqlConnection("Data Source=LAPTOP-OBEL3V1L; Initial Catalog= usuarioAgenda; Integrated Security= True");
            //abrimos la conexion
            cadenaConexion.Open();

            if(cbxTipoCuenta.SelectedIndex == 0)
            {
                tipoCuenta = "Administrador";
            }
            if(cbxTipoCuenta.SelectedIndex == 1)
            {
                tipoCuenta = "Invitado";
            }
            fechaNac = dTPFechaNac.Value.Date.ToString("yyy/MM/dd");

            String insertSQL = "insert into db_owner.usuarioSCHARP(nombre, aPaterno, aMaterno, fechaNac, tipoCuenta, nombreUsuario, clave)" +
            "VALUES('"+txtNombre.Text +"', '"+txtAPaterno.Text +"', '"+txtAMaterno.Text+"', '"+fechaNac+"', '"+tipoCuenta+"', '"+txtNUsuario+"', '"+txtCPassword.Text+"')";

            SqlCommand comando = new SqlCommand(insertSQL, cadenaConexion);
            comando.ExecuteNonQuery();
            cadenaConexion.Close();
            Console.WriteLine("Se acompleto la cadena");
            cadenaConexion.Close();
        }
    }
}
