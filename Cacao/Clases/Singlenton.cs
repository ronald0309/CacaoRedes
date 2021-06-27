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

        //public Jugador nj = new Jugador("J", 10, "rojo", 3);
        public LTrabajador SELECCIONADA = null;
        public bool fueMovida = true;

        public Label lblUsuarios;


    }
}
