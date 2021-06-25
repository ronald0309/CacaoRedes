using Cacao.Utils;
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
        
        private int[] meples = new int[4];
        public static string urlImagenOculta = "Reverso";
        public static string urlImagenVisible = "Losa";
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
            
            string meplesColor = urlImagenOculta + Colores.seleccionarColor(this.color);

            Load(Application.StartupPath + @"\Recursos\" + meplesColor + ".png");
            Location = new System.Drawing.Point(0, 0);
            SizeMode = PictureBoxSizeMode.StretchImage;
            //SizeMode = PictureBoxSizeMode.Zoom;
            //Size = new System.Drawing.Size(150, 150);

        }
        public void inicializarImagenVisible()
        {

            string meplesColor = urlImagenVisible + Colores.seleccionarColor(this.color);



            //if (this.color == "Amarillo" || this.color == "Amarilla")
            //{
            //    meplesColor = "Amarilla"; urlImagen += meplesColor;
            //}
            //if (this.color == "Roja" || this.color == "Rojo")
            //{
            //    meplesColor = "Roja"; urlImagen += meplesColor;
            //}
            //if (this.color == "Blanca" || this.color == "Blanco")
            //{
            //    meplesColor = "Blanca"; urlImagen += meplesColor;
            //}
            //if (this.color == "Morada" || this.color == "Morado")
            //{
            //    meplesColor = "Morada"; urlImagen += meplesColor;
            //}

            //urlImagen += meplesColor;

            //Carga la imagen de la loseta con el color
            //Load(Application.StartupPath + @"\Recursos\" + meplesColor + ".png");
            //Location = new System.Drawing.Point(0, 0);
            
            //SizeMode = PictureBoxSizeMode.Zoom;
            //Size = new System.Drawing.Size(80, 80); Se le cambia el tamaño a las imagenes 

            //carga la imagen de los meples con el color y la distribucion correspondiente
            PictureBox m = new PictureBox();
            meplesColor = urlImagenVisible + Colores.seleccionarColor(this.color);
            if (meples[0] == 1 && meples[1] == 1 && meples[2] == 1 && meples[3] == 1)
            {
                m.Load(Application.StartupPath + @"\Recursos\" +  meplesColor + "P1.png");
            }
            if (meples[0] == 1 && meples[1] == 2 && meples[2] == 1 && meples[3] == 0)
            {
                m.Load(Application.StartupPath + @"\Recursos\" +  meplesColor + "P2.png");
            }
            if (meples[0] == 0 && meples[1] == 3 && meples[2] == 1 && meples[3] == 0)
            {
                m.Load(Application.StartupPath + @"\Recursos\" +  meplesColor + "P3.png");
            }
            if (meples[0] == 1 && meples[1] == 3 && meples[2] == 0 && meples[3] == 0)
            {
                //m.Load(Application.StartupPath + @"\Recursos\" + meplesColor + "P4.png");
            }
            m.Location = new System.Drawing.Point(0, 0);
            // m.SizeMode = PictureBoxSizeMode.CenterImage;
            m.Margin = new Padding(0, 0, 0, 0);
            m.Padding = new Padding(0, 0, 0, 0);
            m.Size = new System.Drawing.Size(79, 79);
            m.SizeMode = PictureBoxSizeMode.Zoom;
            //m.Height = this.Height ;
            //m.Width = this.Width ;
            //m.ClientSize = new Size(80, 80); Se le cambia el tamaño a los meples
            m.BackColor = Color.Transparent;

            m.Parent = this;

        }
        public string Colors { get { return color; } set { color = value; } }
    }
}
