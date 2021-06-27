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
using Cacao.Vistas;

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
            VistaServidor vServidor = new VistaServidor();
            this.Hide();
            vServidor.ShowDialog();
            this.Close();

        }

        private void ActUnirse(object sender, EventArgs e)
        {
            VistaCliente vCliente = new VistaCliente();
            this.Hide();
            vCliente.ShowDialog();
            this.Close();
        }
    }
}
