﻿using Cacao.Sock;
using Cacao.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class Jugador{
        //Jugador datos
        [NonSerialized] public Cliente cliente;
        private string nombre;
        private int edad;
        private string color;
        //Jugador.  juego se altera por cantidad de jugadores
        [NonSerialized] private LTrabajador[] losetasTrabajadores;
        //por defecto
        [NonSerialized] private Meeple meeple;
        [NonSerialized] private TableroPoblado tableroPoblado;
        [NonSerialized] private FCacao[] fichasCacao;
        [NonSerialized] private FSol[] fichasSol;
        [NonSerialized] private Moneda[] monedas;
        [NonSerialized] public LTrabajador[] mazoMano = new LTrabajador[3];
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
        public Jugador(string nombre, int edad, string color, int jugadores)
        {

            
            this.nombre = nombre;
            this.edad = edad;
            this.color = color;
            this.fichasCacao = new FCacao[5];
            this.fichasSol = new FSol[3];
            this.monedas = new Moneda[48];
            this.tableroPoblado = new TableroPoblado(this.color);
            this.meeple = new Meeple(this.color);

            InicializarPorJugadores(jugadores);
            CargarMasoMano();

        }
        public Jugador(Cliente cliente, string nombre, int edad, string color) {

            this.cliente = cliente;
            this.nombre = nombre;
            this.edad = edad;
            this.color = color;
            this.fichasCacao = new FCacao[5];
            this.fichasSol = new FSol[3];
            this.monedas = new Moneda[48];
            this.tableroPoblado = new TableroPoblado(this.color);
            this.meeple = new Meeple(this.color);

            int c = Singlenton.Instance.CANTJUGADORES;
            InicializarPorJugadores(c);
            CargarMasoMano();

        }
        public void CargarMasoMano() {

            for (int i=0; i < losetasTrabajadores.Length; i++) {
                if (losetasTrabajadores[i] != null)
                {
                    
                    for (int j = 0; j < 3; j++)
                    {
                        if (mazoMano[j] == null)
                        {
                            mazoMano[j] = new LTrabajador();

                            mazoMano[j] = losetasTrabajadores[i];
                            
                            losetasTrabajadores[i] = null;
                           
                        }
                    }
                    
                }
                
            }
        }
        
        private void InicializarPorJugadores(int cantidadJugadores){
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
