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
            
            FCacao f = new FCacao();
            FSol s = new FSol();
            int[] n = { 1, 3, 0,0};
            LTrabajador lt = new LTrabajador("L1",false,"Roja",n);
            LJungla lj = new LJungla("templo",false);
            Meeple m = new Meeple("amarillo");
            Moneda mn = new Moneda(10);
            //prueba.Controls.Add(f);
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
