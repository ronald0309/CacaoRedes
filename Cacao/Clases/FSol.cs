using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class FSol : PictureBox
    {
        private static string urlImagen ="FichadeSol.png";
        public FSol() {
            Load(Application.StartupPath + @"\Recursos\"+urlImagen);
            Location = new System.Drawing.Point(15, 15);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;

            Size = new System.Drawing.Size(70, 70);


        }
    }
}
