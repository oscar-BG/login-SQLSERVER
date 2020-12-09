﻿using System;
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

        private void nuevoUsuario_Load(object sender, EventArgs e)
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            if (txtNombre.Text == "" || txtAPaterno.Text == "" || txtAMaterno.Text == "" || cbxTipoCuenta.SelectedIndex <0 || txtNUsuario.Text == "" || txtPassword.Text == "" || txtCPassword.Text == "")
            {
                MessageBox.Show("Faltan campoas por rellenar");
               
            }
            else
            {
                //Cadena para conectarnos al servidor
                //SqlConnection cadenaConexion = new SqlConnection("Data Source=LAPTOP-OBEL3V1L; Initial Catalog= usuarioAgenda; Integrated Security= True");
                
                String consulaNombreUsuario = "SELECT nombreUsuario FROM db_owner.usuarioSCHARP WHERE nombreUsuario = '"+txtNUsuario.Text+"'";
                SqlCommand comando2 = new SqlCommand(consulaNombreUsuario,conexion.conectardb);
                //cadenaConexion.Open();
                conexion.abrir();
                SqlDataReader lector = comando2.ExecuteReader();
                if(lector.Read() == true)
                {
                    MessageBox.Show("El usuario ya existe Eliga Otro");
                    //cadenaConexion.Close();
                    conexion.cerrar();
                    txtNUsuario.Clear();
                    txtPassword.Clear();
                    txtCPassword.Clear();
                }
                else
                {
                    //cerramos la conexion
                    //cadenaConexion.Close();
                    conexion.cerrar();

                    if(txtPassword.Text == txtCPassword.Text)
                    {
                        if (cbxTipoCuenta.SelectedIndex == 0)
                        {
                            tipoCuenta = "Administrador";
                        }
                        if (cbxTipoCuenta.SelectedIndex == 1)
                        {
                            tipoCuenta = "Invitado";
                        }
                        fechaNac = dTPFechaNac.Value.Date.ToString("yyy/MM/dd");
                        //cadenaConexion.Open();
                        conexion.abrir();
                        String insertSQL = "insert into db_owner.usuarioSCHARP(nombre, aPaterno, aMaterno, fechaNac, tipoCuenta, nombreUsuario, clave)" +
                        "VALUES('" + txtNombre.Text + "', '" + txtAPaterno.Text + "', '" + txtAMaterno.Text + "', '" + fechaNac + "', '" + tipoCuenta + "', '" + txtNUsuario.Text + "', '" + txtCPassword.Text + "')";

                        SqlCommand comando = new SqlCommand(insertSQL, conexion.conectardb);
                        comando.ExecuteNonQuery();
                        //cadenaConexion.Close();
                        conexion.cerrar();
                        Console.WriteLine("Se acompleto la cadena");
                        //cadenaConexion.Close();
                        conexion.cerrar();
                        limpiar();
                        MessageBox.Show("Los datos se almacenaron correctamente");
                    }
                    else
                    {
                        txtPassword.Clear();
                        txtCPassword.Clear();
                        MessageBox.Show("Las contraseñas no coinciden, repitelos de nuevo");
                    }
                    
                }
                
            }
            
        }

        //LimpiarComponentes
        private void limpiar()
        {
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            cbxTipoCuenta.SelectedIndex = 0;
            txtNUsuario.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();
        }


    }
}
