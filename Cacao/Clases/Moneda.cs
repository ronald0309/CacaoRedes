using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class Moneda:PictureBox
    {
        
        public Moneda()
        {
            
            Load(Application.StartupPath+@"\Recursos\meepleVioleta.png");
            Location = new System.Drawing.Point(15, 15);
            SizeMode = PictureBoxSizeMode.CenterImage;
            SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
