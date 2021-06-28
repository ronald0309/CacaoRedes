using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class FichaCacao : PictureBox
    {
        private static string urlImagen = "cacao.png";
    public FichaCacao(){
            Load(Application.StartupPath + @"\Recursos\"+urlImagen);
            Location = new System.Drawing.Point(15, 15);
            SizeMode = PictureBoxSizeMode.CenterImage;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new System.Drawing.Size(50, 50);
        }

    }
}
