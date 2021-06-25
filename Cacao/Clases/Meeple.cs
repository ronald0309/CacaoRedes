using Cacao.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class Meeple : PictureBox
    {
        private string color;

        public Meeple(string color) {
            this.color = color;
            inicializarMepple(); 

        }
        private void inicializarMepple() {
            string urlImage = "meeple" + Colores.seleccionarColor(this.color);

            Load(Application.StartupPath + @"\Recursos\"+urlImage+".png");
            Location = new System.Drawing.Point(0,0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new System.Drawing.Size(50, 50);

        }
    }
}
