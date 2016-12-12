﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.AbmRol;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Base_de_Datos;
using ClinicaFrba.Menu_Principal;
using System.Configuration;
using System.Data.SqlClient;
using ClinicaFrba.Compra_Bono;

namespace ClinicaFrba.Menu_Principal
{
    public partial class HomeAdmin : Form
    {
        //int flag = 1;
        //private string nombreAdmin = "Administrador";
        
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            /*string queryDatosProf = "SELECT nombre ,apellido FROM SELECT_GROUP.Afiliado where numeroDni = '" + Globals.userName + "'";

            DataTable datosProf = new DataTable();

            Conexion.conectar();

            datosProf = Conexion.LeerTabla(queryDatosProf);

            foreach (DataRow datosUnProf in datosProf.Rows)
            {
                nombreAfil = datosUnProf["nombre"].ToString();
                apellidoAfil = datosUnProf["apellido"].ToString();

            }
            label3.Text = nombreAfil + ", " + apellidoAfil; 
            */ //Comentado Hasta que haya base de datos para administradores
            //label2.Text = "Administrador";  Se borro este funcionamiento
        }

        private void btnAltaAfiliado_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.frmAltaAfiliado frmAlta = new Abm_Afiliado.frmAltaAfiliado();
            frmAlta.Home = this; 
            frmAlta.Show();
            this.Hide();
       
        }
        
        private void btnRegistrarLlegada_Click(object sender, EventArgs e)
        {
            Registro_Llegada.Llegada frmRegistrar = new Registro_Llegada.Llegada();
            frmRegistrar.Home = this; 
            frmRegistrar.Show();
            this.Hide();
        }

        private void btnAbmRol_Click(object sender, EventArgs e)
        {
            abmMenuRol frmMenuRol = new abmMenuRol();
            frmMenuRol.Home = this;
            this.Hide();
            frmMenuRol.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Por favor complete el nro de Afiliado");
            }
            else
            {
                string consultaUsername = "SELECT U.nombreUsuario FROM Select_Group.Usuario U JOIN Select_Group.Afiliado A ON A.idUsuario = U.idUsuario WHERE A.nroAfiliado = " + textBox1.Text.ToString().Trim();
                DataTable unUserName = new DataTable();
                Conexion.conectar();
                try
                {

                    unUserName = Conexion.LeerTabla(consultaUsername);

                    foreach (DataRow unUserN in unUserName.Rows)
                    {
                        Globals.userName = unUserN["nombreUsuario"].ToString();

                    }


                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexion.conexion.Close();

                    this.Hide();
                    FrmComprarBonos frmCompra = new FrmComprarBonos();
                    frmCompra.Home = this; 
                    frmCompra.Show();


                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text.Trim();
           textBox1.Text = textBox1.Text.Replace(" ", "");
           textBox1.SelectionStart = textBox1.Text.Length;
        }
        

    
        ///
                
        private void btnCambiarPlan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Por favor complete el nro de Afiliado");
            }
            else
            {
                Abm_Planes.CambiarPlan frmCambiarPlan = new Abm_Planes.CambiarPlan(textBox1.Text);
                frmCambiarPlan.Home = this;
                frmCambiarPlan.Show();
                this.Hide();
            }

            }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Listados.ListadoEstadistico frmListados = new Listados.ListadoEstadistico("Admin");
            frmListados.Home = this;
            frmListados.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login frmNewLog = new Login();
            frmNewLog.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaAfiliado frmBajaAfiliado = new BajaAfiliado();
            frmBajaAfiliado.Home = this;
            frmBajaAfiliado.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarAfiliado frmModAf = new ModificarAfiliado();
            frmModAf.Home = this;
            frmModAf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestituirAfiliado frmRestAfiliado = new RestituirAfiliado();
            frmRestAfiliado.Home = this;
            frmRestAfiliado.Show();
            this.Hide();


        }

        private void btnRegAtencion_Click(object sender, EventArgs e)
        {
            //Hacer funcionalidad

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarDia_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Pedir_Turno.FrmSolTurno frmSolTurno = new Pedir_Turno.FrmSolTurno();
            //frmSolTurno.menuAnterior = "Afiliado";
            frmSolTurno.Home = this;
            frmSolTurno.Show();
            this.Hide();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.CancelacionAfiliado frmCancel = new Cancelar_Atencion.CancelacionAfiliado(txtAfiliado.Text);
            frmCancel.Home = this;
            frmCancel.Show();
            this.Hide();
        }
        }
}

