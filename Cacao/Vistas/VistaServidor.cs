using Cacao.Clases;
using Cacao.Sock;
using Cacao.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cacao.Vistas
{

    public partial class VistaServidor : Form
    {
        Servidor servidor;
        Partida partida;
        public VistaServidor()
        {
            InitializeComponent();
            cantidadJugadores();

            Clases.Singlenton.Instance.lblUsuarios = this.lblUsuarios;
            
        }
        private void cantidadJugadores() {
            cbxNumeroJugadores.Items.Add(2);
            cbxNumeroJugadores.Items.Add(3);
            cbxNumeroJugadores.Items.Add(4);
        }
        private bool ValidarDatos()
        {
            bool permiso = false;
            int contador = 0;
            if (txtIP.Text.Length > 0)
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese una dirección IP");

            }
            if (txtNombrePartida.Text.Length > 0)
            {
               // partida.nombre = txtNombre.Text;
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");

            }
            if (cbxNumeroJugadores.Text.Length > 0)
            {
                Singlenton.Instance.CANTJUGADORES = Convert.ToInt32(cbxNumeroJugadores.SelectedItem.ToString());


                //Singlenton.Instance.customDomain.SetData("numJug", numJug);
                //AppDomain.setda
                //AppContext.SetSwitch("num", Enabled);

                //Singlenton.Instance.CANTJUGADORES = (this.cbxNumeroJugadores);
                //l.Refresh();
                contador++;
            }
            else
            {
                MessageBox.Show("Seleccione la cantidad de jugadores.");
            }
            if (contador == 3)
            {
                permiso = true;
            }
            return permiso;
        }
    
        private void btnCrear_MouseClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            if (ValidarDatos())
            {
                servidor = new Servidor(txtIP.Text, 8080, Singlenton.Instance.CANTJUGADORES);
                servidor.Start();
                //Thread.Sleep(5);
                lblUsuarios.Text = servidor.clientReceive();

            }
            else {
                MessageBox.Show("aqui" );
            }
            }
            //catch (Exception exc) {

            //    MessageBox.Show("aqui"+exc.Message.ToString());
            //}
           
        
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                if (servidor != null && servidor.IniciarPartida())
                {
                    partida = new Partida(this.servidor, txtNombrePartida.Text, 0, this.servidor.jugadores);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Faltan jugadores por ingresar");
            }

        }
    }
}

