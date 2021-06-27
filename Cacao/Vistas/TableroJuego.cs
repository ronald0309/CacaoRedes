using Cacao.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Vistas
{
    public partial class TableroJuego : UserControl
    {
        public PictureBox[,] l;
        public TableroJuego()
        {
            InitializeComponent();
            cargarVista();
        }

        public void cargarVista()
        {
            int matX = 18;
            int matY = 11;
            l = new PictureBox[matX, matY];
        }
        
        public FlowLayoutPanel obtenerMesa() {
            
            return flowLayoutPanel1;
        }

    }
}
