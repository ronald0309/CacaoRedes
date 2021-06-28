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
    public partial class VistaCliente : Form
    {
        Jugador jugador;
        public VistaCliente()
        {
            this.jugador = new Jugador();

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
            cbxColor.Items.Add("Verde Claro");
            cbxColor.Items.Add("Verde Oscuro");
            cbxColor.Items.Add("Rojo");
            cbxColor.Items.Add("Amarillo");
        }
        int accion = 1;
        private Cliente cliente;
        private void actBtnUnirse(object sender, EventArgs e)
        {

            //cliente.();
            Cliente nuevoCliente = new Cliente(txtIP.Text, 8080);
            jugador = new Jugador(nuevoCliente, txtNombre.Text, 18, cbxColor.SelectedItem.ToString());
            jugador.cliente.Start();
            jugador.cliente.sendObject(jugador);
            //bool bandera = false;
            //accion = 1;
            //if (ValidarDatos() && bandera == false){
            //    if (accion == 1) { 

            //    cliente.Send("Número de jugadores");
            //    cliente.serverReceive();
            //        accion += 1;
            //    }
            //    if (accion == 2) { 









            //}


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
            if (txtNombre.Text.Length > 0)
            {
                //jugador.Nombre = txtNombre.Text;
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");

            }
            if (dtpFechaNacimiento.Value.Year < DateTime.Now.Date.Year)
            {
                //(Me todo para calcular la edad)
                //jugador .Edad = ?
                contador++;
            }
            else
            {
                MessageBox.Show("Ingrese una fecha de nacimiento valida");
            }
            if (cbxColor.Text.Length > 0)
            {
                jugador.Color = cbxColor.SelectedItem.ToString();

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

        private void VerificarDatos_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                cliente = new Cliente(txtIP.Text, 8080);
                cliente.Start();
                cliente.Send("Cantidad jugadores");
                Singlenton.Instance.CANTJUGADORES = Convert.ToInt32(cliente.serverReceive());

            }
        }
    }
}
