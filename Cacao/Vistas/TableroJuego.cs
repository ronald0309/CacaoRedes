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
       
        public TableroJuego()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel obtenerMesa() {
            return flowLayoutPanel1;
        }
       
    }
}
