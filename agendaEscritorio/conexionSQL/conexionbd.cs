using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conexionSQL
{
    class conexionbd
    {
        String cadena = "Data Source=LAPTOP-OBEL3V1L; Initial Catalog= usuarioAgenda; Integrated Security= True";
        public SqlConnection conectardb = new SqlConnection();
        
        public conexionbd()
        {
            conectardb.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectardb.Open();
                Console.WriteLine("Conexion abrierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir " + ex.Message); 
            }
        }
        public void cerrar()
        {
            try
            {
                conectardb.Close();
                Console.WriteLine("Se cerro la conexion");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puedo cerrar" + ex.Message);
            }
            
        }
    }
}
