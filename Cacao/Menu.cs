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
namespace Cacao
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();
            Monedas monedas = new Monedas();
            this.Controls.Add(monedas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor ser = new Servidor();
            ser.Conect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Conect();
        } 
    }
}
