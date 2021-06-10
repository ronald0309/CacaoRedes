using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    class LTrabajador : Loseta
    {
        private string color="";
        private int[] meples = new int[4] ;
        public static string urlImagen = "Losa";
        public LTrabajador(string nombre, bool isOculta,string color, int[] meples)
            : base(nombre, isOculta){
            this.color = color;
            this.IsOculta = isOculta;
            this.meples = meples;

            voltearLoseta();
        }
        public void voltearLoseta()
        {
            if (this.IsOculta)
            {
                inicializarImageOculta();
            }
            else
            {
                inicializarImagenVisible();
            }
        }
        public void inicializarImageOculta() {
            string meplesColor = "";
            if (this.color == "Amarillo" || this.color == "Amarilla")
            {
                meplesColor = "Reverso4";
            }
            else if (this.color == "Roja" || this.color == "Rojo")
            {
                meplesColor = "Reverso3";
            }
            else if (this.color == "Blanca" || this.color == "Blanco")
            {
                meplesColor = "Reverso5";
            }
            else if (this.color == "Morada" || this.color == "Morado")
            {
                meplesColor = "Reverso2";
            }
            Load(Application.StartupPath + @"\Recursos\" + meplesColor + ".png");
            Location = new System.Drawing.Point(0, 0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new System.Drawing.Size(150, 150);

        }
        public void inicializarImagenVisible()
        {
            string meplesColor = "";
            if (this.color == "Amarillo" || this.color == "Amarilla")
            {
                meplesColor = "Amarilla"; urlImagen += meplesColor;
            }
            if (this.color == "Roja" || this.color == "Rojo")
            {
                meplesColor = "Roja"; urlImagen += meplesColor;
            }
            if (this.color == "Blanca" || this.color == "Blanco")
            {
                meplesColor = "Blanca"; urlImagen += meplesColor;
            }
            if (this.color == "Morada" || this.color == "Morado")
            {
                meplesColor = "Morada"; urlImagen += meplesColor;
            }

            //Carga la imagen de la loseta con el color
            Load(Application.StartupPath + @"\Recursos\" + urlImagen + ".png");
            Location = new System.Drawing.Point(0, 0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new System.Drawing.Size(150, 150);

            //carga la imagen de los meples con el color y la distribucion correspondiente
            PictureBox m = new PictureBox();
            if (meples[0] == 1 && meples[1] == 1 && meples[2] == 1 && meples[3] == 1)
            {
                m.Load(Application.StartupPath + @"\Recursos\" + "Losa" + meplesColor + "P1.png");
            }
            if (meples[0] == 1 && meples[1] == 2 && meples[2] == 1 && meples[3] == 0)
            {
                m.Load(Application.StartupPath + @"\Recursos\" + "Losa" + meplesColor + "P2.png");
            }
            if (meples[0] == 0 && meples[1] == 3 && meples[2] == 1 && meples[3] == 0)
            {
                m.Load(Application.StartupPath + @"\Recursos\" + "Losa" + meplesColor + "P3.png");
            }
            if (meples[0] == 1 && meples[1] == 3 && meples[2] == 0 && meples[3] == 0)
            {
                m.Load(Application.StartupPath + @"\Recursos\" + "Losa" + meplesColor + "P4.png");
            }
            m.Location = new System.Drawing.Point(0, 0);
            // m.SizeMode = PictureBoxSizeMode.CenterImage;
            m.SizeMode = PictureBoxSizeMode.Zoom;
            //m.Height = this.Height ;
            //m.Width = this.Width ;
            m.ClientSize = new Size(150, 150);
            m.BackColor = Color.Transparent;

            m.Parent = this;

        }

    }
}
