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

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("192.168.8.103", 1234);
            cliente.Start();
           // Clases.Loseta l = new Loseta("Loseta 1", 1);
            //cliente.sendObject(l);
            cliente.recibirLoseta();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
