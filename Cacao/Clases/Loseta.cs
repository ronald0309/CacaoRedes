using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class Loseta : PictureBox
    {
        
        private string nombre;
        private bool isOculta;
        public Loseta(string nombre, bool isOculta){
            this.nombre = nombre;
            this.isOculta = isOculta;
            this.Margin = new Padding(0,0,0,0);
            this.Padding = new Padding(0, 0, 0, 0);
            this.Size = new System.Drawing.Size(79, 79);
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public Loseta() { }
        public string Nombre{
            get { return nombre; }
            set { nombre = value; }
        }
        public bool IsOculta
        {
            get { return isOculta; }
            set { isOculta = value; }
        }
    }
}
