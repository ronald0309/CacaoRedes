using Cacao.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class LosetaTrabajador : Loseta
    {
        private string color=""; 
        
        private int[] meples = new int[4];
        public static string urlImagenOculta = "Reverso";
        public static string urlImagenVisible = "Losa";
        public bool isSeleccionada = false;
        public LosetaTrabajador(string nombre, bool isOculta,string color, int[] meples)
            : base(nombre, isOculta){
            this.color = color;
            this.IsOculta = isOculta;
            this.meples = meples;

            voltearLoseta();
        }


        public LosetaTrabajador():base()
        {
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
        public void SeleccionarLoseta()
        {

            if (isSeleccionada)
            {
                isSeleccionada = false;
                BorderStyle = BorderStyle.None;

                Padding = new Padding(0, 0, 0, 0);
                BackColor = Color.Transparent;


            }
            else
            {
                isSeleccionada = true;
                BorderStyle = BorderStyle.Fixed3D;
                Padding = new Padding(5, 5, 5, 5);
                BackColor = Color.Black;
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
            SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox m = new PictureBox();
            Load(Application.StartupPath + @"\Recursos\" + meplesColor + ".png");
            Location = new System.Drawing.Point(0, 0);
            

            //carga la imagen de los meples con el color y la distribucion correspondiente
            
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
                m.Load(Application.StartupPath + @"\Recursos\" + meplesColor + "P3.png");
             
            }
            
            m.BackColor = Color.Black;
            m.Location = new System.Drawing.Point(0, 0);
            m.Margin = new Padding(0, 0, 0, 0);
            m.Padding = new Padding(0, 0, 0, 0);
            m.Size = new System.Drawing.Size(79, 79);
            m.SizeMode = PictureBoxSizeMode.Zoom;
            Graphics grfx = Graphics.FromImage(this.Image);
            grfx.DrawImage(m.Image,0,0);
            //BringToFront();

            this.Parent = m;
            m.BackColor = Color.Transparent;
        }
        public string Colors { get { return color; } set { color = value; } }
    }
}
