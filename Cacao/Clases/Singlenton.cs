using System;
using System.Collections.Generic;
using System.Text;

namespace Cacao.Clases
{
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
    }
}
