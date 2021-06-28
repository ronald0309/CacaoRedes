using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class Singlenton
    {
        private static Singlenton instance = null;
        public bool salir = false;
        protected Singlenton() { }
        public static Singlenton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singlenton();
                return instance;

            }
        }

        public Loseta SELECCIONADA = null;
        public bool fueMovida = true;

        public int CANTJUGADORES;
        public Label lblUsuarios;
    }
}
