using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cacao.Sock;
using Cacao.Clases;
using System.Drawing.Imaging;

namespace Cacao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            
            InitializeComponent();
        }            

        private void ActCrear(object sender, EventArgs e)
        {
            Servidor servidor = new Servidor("192.168.8.103", 1234);
            servidor.Start();
        }

        private void ActUnirse(object sender, EventArgs e)
        {
            VCliente vCliente = new VCliente();
            this.Hide();
            vCliente.ShowDialog();
            this.Close();
        }
    }
}
