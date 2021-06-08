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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor servidor = new Servidor("192.168.100.45",8080);
            servidor.Start();
            //ser.Conect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("192.168.100.45",8080);
            cliente.Start();
            Loseta l = new Loseta("Loseta 1", 1);
            cliente.sendObject(l);
            cliente.recibirLoseta();
           // cliente.Send("Hola server, desde el cliente");
           // MessageBox.Show(cliente.serverReceive());
            // cli.Conect();
        } 
    }
}
