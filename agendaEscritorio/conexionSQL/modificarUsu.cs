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
    public partial class modificarUsu : Form
    {
        public modificarUsu()
        {
            InitializeComponent();
            autocompletar();
        }
        DataTable datos = new DataTable();

        private void modificarUsu_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();

            string consulta = "SELECT* FROM db_owner.usuarioSCHARP where nombreUsuario = '"+txtBuscarUsu.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion.conectardb);
            conexion.abrir();
            SqlDataReader lector = comando.ExecuteReader();
            if(lector.Read() == true)
            {
                txtNombre.Text = lector["nombre"].ToString();
                txtApaterno.Text = lector["aPaterno"].ToString();
                txtAmaterno.Text = lector["aMaterno"].ToString();
                txtFechaNac.Text = Convert.ToDateTime(lector["fechaNac"]).ToString("yyy/MM/dd");
                txtTCuenta.Text = lector["tipoCuenta"].ToString();
                txtNombreUsu.Text = lector["nombreUsuario"].ToString();
                txtPassword.Text = lector["clave"].ToString();
            }
            else
            {
                MessageBox.Show("El nobre de usuario no existe");
                txtBuscarUsu.Clear();
            }
            conexion.cerrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        public void habilitar()
        {
            txtNombre.Enabled = true;
            txtApaterno.Enabled = true;
            txtAmaterno.Enabled = true;
            txtFechaNac.Enabled = true;
            txtTCuenta.Enabled = true;
            txtNombreUsu.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            string consulta = "UPDATE db_owner.usuarioSCHARP SET nombre = '"+txtNombre.Text+"', aPaterno = '"+txtApaterno.Text+"', aMaterno='"+txtAmaterno.Text+"',fechaNac = '"+txtFechaNac.Text+"', tipoCuenta='"+txtTCuenta.Text+"',nombreUsuario='"+txtNombreUsu.Text+"', clave='"+txtPassword.Text+"' where nombreUsuario='"+txtBuscarUsu.Text+"';";
            SqlCommand comando = new SqlCommand(consulta,conexion.conectardb);
            conexion.abrir();
            SqlDataReader lector = comando.ExecuteReader();
            MessageBox.Show("Los datos de actualizaron");
            conexion.cerrar();
            limpiar();
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            String consulta = "DELETE  FROM db_owner.usuarioSCHARP WHERE nombreUsuario='"+txtBuscarUsu.Text+"';";
            SqlCommand comando = new SqlCommand(consulta, conexion.conectardb);
            conexion.abrir();
            SqlDataReader lector = comando.ExecuteReader();
            MessageBox.Show("Los datos se borraron correctamente");
            conexion.cerrar();
            limpiar();
        }

        public void limpiar()
        {
            txtBuscarUsu.Clear();
            txtNombre.Clear();
            txtApaterno.Clear();
            txtAmaterno.Clear();
            txtFechaNac.Clear();
            txtTCuenta.Clear();
            txtNombreUsu.Clear();
            txtPassword.Clear();
        }

        public void autocompletar()
        {
            conexionbd conexion = new conexionbd();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            String consulta = "SELECT * FROM db_owner.usuarioSCHARP";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion.conectardb);
            adaptador.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["nombreUsuario"].ToString());
            }
            txtBuscarUsu.AutoCompleteCustomSource = lista;
        }
    }
}
