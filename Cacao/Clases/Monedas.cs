using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class Monedas: PictureBox
    {
        public Monedas()
        {
            Image = System.Drawing.Image.FromFile("../Moneda.jpg");
            Location = new System.Drawing.Point(15, 15);
        }
    }
}
