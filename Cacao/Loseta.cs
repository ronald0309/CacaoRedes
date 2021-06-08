using System;
using System.Collections.Generic;
using System.Text;


namespace Cacao
{
    [Serializable]
    class Loseta
    {
        public string nom { get; set; }
        public int num { get; set; }

        public Loseta(string nom, int num) {
            this.nom = nom;
            this.num = num;
        }
    }
}
