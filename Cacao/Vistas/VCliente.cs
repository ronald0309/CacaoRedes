using Cacao.Clases;
using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao
{
    public partial class VCliente : Form
    {
        public VCliente()
        {
            InitializeComponent();
            Colores();
            
        }
        private void Colores()
        {
            cbxColor.Items.Add("Blanco");
            cbxColor.Items.Add("Negro");
            cbxColor.Items.Add("Azul");
            cbxColor.Items.Add("Celeste");
            cbxColor.Items.Add("Verde");
            cbxColor.Items.Add("Verde claro");
            cbxColor.Items.Add("Verde oscuro");
            cbxColor.Items.Add("Rojo");
            cbxColor.Items.Add("Amarillo");

        }
        private void actBtnUnirse(object sender, EventArgs e)
        {
           // if (ValidarDatos())
          //  {
                Cliente cliente = new Cliente("192.168.56.1", 1234);
                cliente.Start();
                // Clases.Loseta l = new Loseta("Loseta 1", 1);
                //cliente.sendObject(l);
                cliente.recibirLoseta();
           // }
        }
        private bool ValidarDatos()
        {
            bool permiso = false;
            int contador = 0;
            if (txtIP.Text.Length > 0)
            {
                contador++;
            }else
            {
                MessageBox.Show("Ingrese una dirección IP");

            }
            if (txtNombre.Text.Length > 0)
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");

            }
            if(dtpFechaNacimiento.Value.Year< DateTime.Now.Date.Year)
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese una fecha de nacimiento valida");
            }
            if (cbxColor.Text.Length > 0)
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Seleccione un color.");
            }
            if (contador == 4)
            {
                permiso = true;
            }
            return permiso;
        }
    }
}
