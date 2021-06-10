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
            string urlImage = "";
            if (this.color == "morada" || this.color == "morado") {
                urlImage = "meepleMorada";
            } else if (this.color == "roja" || this.color =="rojo") {
                urlImage = "meepleRoja";
            } else if (this.color == "amarilla" || this.color == "amarillo") {
                urlImage = "meepleAmarilla";
            } else if (this.color == "blanca" || this.color == "blanco") {
                urlImage = "meepleBlanca";
            }

            Load(Application.StartupPath + @"\Recursos\"+urlImage+".png");
            Location = new System.Drawing.Point(0,0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new System.Drawing.Size(150, 150);

        }
    }
}
