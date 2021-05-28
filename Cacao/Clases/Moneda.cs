using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class Moneda: PictureBox
    {
        public Moneda()
        {
          
            ImageLocation = @"\Recursos\Moneda.jpg";
            Location = new System.Drawing.Point(15, 15);
        }
    }
}
