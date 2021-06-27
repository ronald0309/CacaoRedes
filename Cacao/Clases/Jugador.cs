using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cacao.Clases
{
    class Jugador{
        //Jugador datos
        private Cliente cliente;
        private string nombre;
        private int edad;
        private string color;
        //Jugador.  juego se altera por cantidad de jugadores
        private LTrabajador[] losetasTrabajadores;
        //por defecto
        private Meeple meeple;
        private TableroPoblado tableroPoblado;
        private FCacao[] fichasCacao;
        private FSol[] fichasSol;
        private Moneda[] monedas;
        public LTrabajador[] mazoMano = new LTrabajador[3];

        public string Nombre
        {get { return nombre; }set { nombre = value; }}
        public int Edad
        {get { return edad; }set { edad = value; }}
        public string Color{get { return color; }set { color = value; }}

        public TableroPoblado TPoblado
        { get { return tableroPoblado; } set { tableroPoblado = value; } }
        public LTrabajador[] LosetasTrabajadores
        { get { return losetasTrabajadores; } set { losetasTrabajadores = value; } }
        public Meeple Meeple
        { get { return meeple; } set { meeple = value; } }
        public FCacao[] FichasCacao
        { get { return fichasCacao; } set { fichasCacao = value; } }
        public FSol[] FichasSol
        { get { return fichasSol; } set { fichasSol = value; } }
        public Moneda[] Monedas
        { get { return monedas; } set { monedas = value; } }

        public Jugador() { 
        }
        public Jugador(string nombre, int edad, string color, int cantidadJugadores) {

            this.nombre = nombre;
            this.edad = edad;
            this.color = color;
            this.fichasCacao = new FCacao[5];
            this.fichasSol = new FSol[3];
            this.monedas = new Moneda[48];
            this.tableroPoblado = new TableroPoblado(this.color);
            this.meeple = new Meeple(this.color);
            inicializarPorJugadores(cantidadJugadores);
        }
        private void inicializarPorJugadores(int cantidadJugadores){
            if (cantidadJugadores == 2) {
                this.losetasTrabajadores = new LTrabajador[11];
            } else if (cantidadJugadores == 3) {
                this.losetasTrabajadores = new LTrabajador[10];
            } else if (cantidadJugadores == 4) {
                this.losetasTrabajadores = new LTrabajador[9];
            }

            //for (int i=0;i<mazoMano.Length;i++) {
            //    mazoMano[i] = new LTrabajador();
            //}
        }
        
    }
}
