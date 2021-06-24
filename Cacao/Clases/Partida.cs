using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cacao.Clases
{
    class Partida
    {
        private Servidor server;
        //Cliente[] clientes; // ?? Seguro ??
        string nombre;
        int tiempo;
        //int cantidadJugadores;

        Jugador[] jugadores;
        public LTrabajador[] losetasTrabajadores;
        TableroPoblado[] tablerosPoblados;
        public LJungla[] losetasJungla;
        FCacao[] fichasCacao;
        FSol[] fichasSol;
        Moneda[] monedas;

        public Partida(Servidor server, string nombre, int tiempo, Jugador[] jugadores)
        {
            this.server = server;
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.jugadores = jugadores;

            crearJuego();

        }

        private void crearJuego()
        {
            //this.jugadores = new Jugador[this.cantidadJugadores];
            this.losetasTrabajadores = new LTrabajador[44];
            this.tablerosPoblados = new TableroPoblado[4];
            this.losetasJungla = new LJungla[28];
            this.fichasCacao = new FCacao[20];
            this.fichasSol = new FSol[12];
            this.monedas = new Moneda[48];

            inicializarLosetasTrabajadores();
            inicializarTablerosPoblados();
            inicializarLosetasJungla();
            inicializarFichasCacao();
            inicializarFichasSol();
            inicializarMonedas();

            validarJuego();

            inicializarBarajasJugadores();

        }

        private void inicializarLosetasTrabajadores()
        {
            int[] posicionesCartasTrabajadores = new int[4];
            int contador = 0;
            for (int i = 0; i < jugadores.Length; i++)
            {
                for (int j = 0; j < 11; j++)
                {

                    if (j >= 0 && j < 4)
                    {
                        //4 cartas {1,1,1,1}
                        posicionesCartasTrabajadores[0] = 1; posicionesCartasTrabajadores[1] = 1;
                        posicionesCartasTrabajadores[2] = 1; posicionesCartasTrabajadores[3] = 1;
                    }
                    else if (j >= 4 && j < 9)
                    {
                        //5 cartas {1,2,1,0}
                        posicionesCartasTrabajadores[0] = 1; posicionesCartasTrabajadores[1] = 2;
                        posicionesCartasTrabajadores[2] = 1; posicionesCartasTrabajadores[3] = 0;
                    }
                    else if (j >= 9 && j < 10)
                    {
                        //1 carta {0,3,1,0}
                        posicionesCartasTrabajadores[0] = 0; posicionesCartasTrabajadores[1] = 3;
                        posicionesCartasTrabajadores[2] = 1; posicionesCartasTrabajadores[3] = 0;
                    }
                    else if (j == 10)
                    {
                        //1 carta {1,3,0,0}
                        posicionesCartasTrabajadores[0] = 1; posicionesCartasTrabajadores[1] = 3;
                        posicionesCartasTrabajadores[2] = 0; posicionesCartasTrabajadores[3] = 0;
                    }

                    losetasTrabajadores[contador] = new LTrabajador("Loseta Trabajador", false, jugadores[i].Color, posicionesCartasTrabajadores);

                    contador += 1;
                }

            }
        }
        private void inicializarTablerosPoblados()
        {
            for (int i = 0; i < jugadores.Length; i++)
            {
                tablerosPoblados[i] = new TableroPoblado(jugadores[i].Color);
            }
        }
        private void inicializarLosetasJungla()
        {
            bool bandera = false;
            for (int i = 0; i < 28; i++)
            {

                // Plantaciones simple x6
                if (i < 6)
                {
                    losetasJungla[i] = new LJungla("plantacion simple", bandera);
                }
                else
                // Plantaciones doble x2
                if (i >= 6 && i < 8)
                {
                    losetasJungla[i] = new LJungla("plantacion doble", bandera);
                }
                else
                // Mercado precio 2 x2
                if (i >= 8 && i < 10)
                {
                    losetasJungla[i] = new LJungla("mercado 2", bandera);
                }
                else
                // Mercado precio 3 x4
                if (i >= 10 && i < 14)
                {
                    losetasJungla[i] = new LJungla("mercado 3", bandera);
                }
                else
                // Mercado precio 4 x1
                if (i >= 14 && i < 15)
                {
                    losetasJungla[i] = new LJungla("mercado 4", bandera);
                }
                else
                // Mina 1 x2
                if (i >= 15 && i < 17)
                {
                    losetasJungla[i] = new LJungla("mina de oro 1", bandera);
                }
                else
                // Mina 2 x1
                if (i >= 17 && i < 18)
                {
                    losetasJungla[i] = new LJungla("mina de oro 2", bandera);
                }
                else
                // Agua x3
                if (i >= 18 && i < 21)
                {
                    losetasJungla[i] = new LJungla("agua", bandera);
                }
                else
                //Adoracion al sol x2
                if (i >= 21 && i < 23)
                {
                    losetasJungla[i] = new LJungla("adoracion al sol", bandera);
                }
                else
                // templos x5
                if (i >= 23 && i < 28)
                {
                    losetasJungla[i] = new LJungla("templo", bandera);
                }
            }
        }
        private void inicializarFichasCacao()
        {
            for (int i = 0; i < 20; i++)
            {
                fichasCacao[i] = new FCacao();
            }
        }
        private void inicializarFichasSol()
        {
            for (int i = 0; i < 12; i++)
            {
                fichasSol[i] = new FSol();
            }
        }
        private void inicializarMonedas()
        {
            for (int i = 0; i < 0; i++)
            {
                //monedas de 1 x24
                if (i > 24)
                {
                    monedas[i] = new Moneda(1);
                }
                else
                //monedas de 5 x12
                if (i >= 24 && i < 36)
                {
                    monedas[i] = new Moneda(5);
                }
                else
                //monedas de 10 x12
                if (i >= 36 && i < 48)
                {
                    monedas[i] = new Moneda(10);
                }

            }
        }

        private LJungla[] eliminarLosetaJungla(LJungla[] lj, int posToDelete)
        {
            LJungla[] ljungla = new LJungla[lj.Length - 1];
            int cont = 0;
            int i = posToDelete;
            while (i < lj.Length - 1)
            {
                lj[i] = lj[i + 1];
                i++;
            }
            lj[lj.Length - 1] = null;
            foreach (LJungla l in lj)
            {
                if (l != null)
                {
                    ljungla[cont] = l;
                    cont += 1;
                }
            }
            lj = ljungla;
            return lj;
        }
        private LTrabajador[] eliminarLosetaTrabajdor(LTrabajador[] lj, int posToDelete)
        {
            LTrabajador[] ltrabajador = new LTrabajador[lj.Length - 1];
            int cont = 0;
            int i = posToDelete;
            while (i < lj.Length - 1)
            {
                lj[i] = lj[i + 1];
                i++;
            }
            lj[lj.Length - 1] = null;
            foreach (LTrabajador l in lj)
            {
                if (l != null)
                {
                    ltrabajador[cont] = l;
                    cont += 1;
                }
            }
            lj = ltrabajador;
            return lj;
        }
        private void validarJuego()
        {
            //actualizar juego para 2 jugadores
            if (this.jugadores.Length == 2)
            {
                eliminarLosetaJungla(losetasJungla, 5);
                eliminarLosetaJungla(losetasJungla, 4);
                eliminarLosetaJungla(losetasJungla, 10);
                eliminarLosetaJungla(losetasJungla, 13);
                eliminarLosetaJungla(losetasJungla, 16);
                eliminarLosetaJungla(losetasJungla, 17);
                eliminarLosetaJungla(losetasJungla, 20);

            }
            else if (this.jugadores.Length == 3)
            {
                eliminarLosetaTrabajdor(losetasTrabajadores, 0);
                eliminarLosetaTrabajdor(losetasTrabajadores, 12);
                eliminarLosetaTrabajdor(losetasTrabajadores, 22);
            }
            else if (this.jugadores.Length == 4)
            {
                //cartas jugador1
                eliminarLosetaTrabajdor(losetasTrabajadores, 0);
                eliminarLosetaTrabajdor(losetasTrabajadores, 6);

                //cartas jugador1
                eliminarLosetaTrabajdor(losetasTrabajadores, 10);
                eliminarLosetaTrabajdor(losetasTrabajadores, 15);

                //cartas jugador1
                eliminarLosetaTrabajdor(losetasTrabajadores, 21);
                eliminarLosetaTrabajdor(losetasTrabajadores, 24);

                //cartas jugador1
                eliminarLosetaTrabajdor(losetasTrabajadores, 29);
                eliminarLosetaTrabajdor(losetasTrabajadores, 32);

            }



            //} else 
            ////actualizar juego para 3 jugadores
            //if () {

            //} else 
            ////actualizar juego para 4 jugadores
            //if (){

            //}



        }
        // Barajar las cartas
        private void barajar()
        {

        }

        private void inicializarBarajasJugadores()
        {
           
            for (int i = 0; i < this.jugadores.Length; i++)
            {int contador = 0;
                //for (int j = 0; j < this.jugadores[i].LosetasTrabajadores.Length; j++)
                //{
                foreach (LTrabajador l in losetasTrabajadores)
                {

                    if (l != null && l.Colors == jugadores[i].Color)
                    {
                        jugadores[i].LosetasTrabajadores[contador] = l;
                        contador += 1;
                        //}

                    }

                }

            }

        }

    }
}
