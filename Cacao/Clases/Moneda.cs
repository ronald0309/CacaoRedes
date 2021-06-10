using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class Moneda:PictureBox
    {
        private int valor;

        public Moneda(int valor)
        {
            this.valor = valor;
            inicializarMoneda();
        }

        public void inicializarMoneda() {
            string urlImagen = "";
            if (this.valor == 1) {
                urlImagen = "moneda1";
            } else if (this.valor == 5) {
                urlImagen = "moneda5";
            } else if (this.valor == 10) {
                urlImagen = "moneda10";
            }

            Load(Application.StartupPath + @"\Recursos\" + urlImagen + ".png");
            Location = new System.Drawing.Point(0, 0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new System.Drawing.Size(75, 75);
        }
    }
}
