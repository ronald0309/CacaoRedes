using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class FCacao : PictureBox
    {
        private static string urlImagen = "cacao2.png";
    public FCacao(){
            Load(Application.StartupPath + @"\Recursos\"+urlImagen);
            Location = new System.Drawing.Point(15, 15);
            SizeMode = PictureBoxSizeMode.CenterImage;
            SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
