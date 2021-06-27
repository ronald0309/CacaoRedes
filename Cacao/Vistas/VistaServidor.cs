using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Vistas
{
    public partial class VistaServidor : Form
    {
        Servidor servidor;
        public VistaServidor()
        {
            InitializeComponent();
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
            if (contador == 1)
            {
                permiso = true;
            }
            return permiso;
        }

        private void btnCrear_MouseClick(object sender, MouseEventArgs e)
        {
            servidor = new Servidor(txtIP.Text, 80);
            servidor.Start();
        }
    }
}

