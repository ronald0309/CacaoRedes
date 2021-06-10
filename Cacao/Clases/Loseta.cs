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
          
        }
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
