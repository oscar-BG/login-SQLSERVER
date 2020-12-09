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

        private void verTodaLaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Enlazar el DataGridView al bindinSource1 y cargar los datos de la base de datos
            dtgMostrarDatos.DataSource = bindingSource1;
            obtenerDatos("select * from db_owner.usuarioSCHARP;");
        }
        private void tiposDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Enlazar el DataGridView al bindinSource1 y cargar los datos de la base de datos
            dtgMostrarDatos.DataSource = bindingSource1;
            obtenerDatos("select tipoCuenta, count(*) as cantidad from db_owner.usuarioSCHARP group by tipoCuenta;");
        }
        private void obtenerDatos(string comandoSelect)
        {
            try
            {
                //Especificar la cadena de conexion
                conexionbd conexion = new conexionbd();
                //Crear un nuevo adaptador de datos basado en la consulta especifica;
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(comandoSelect, conexion.conectardb);

                //llamar a una nueva tabla de datos y enlazarlo a bindingSource

                DataTable tabla = new DataTable();
                adaptadorDatos.Fill(tabla);
                bindingSource1.DataSource = tabla;

                //Cambiar el tamañ de las columnas DataGridView para adaptarse al contenido recién cargada.
                dtgMostrarDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error0");
            }
        }

    }
}
