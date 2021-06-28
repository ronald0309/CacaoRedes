using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class Partida
    {
        public Servidor server;
        public string nombre;
        public int tiempo;

        public Jugador[] jugadores;
        public LosetaTrabajador[] losetasTrabajadores;
        TableroPoblado[] tablerosPoblados;
        public LosetaJungla[] losetasJungla;
        FichaCacao[] fichasCacao;
        FichaSol[] fichasSol;
        Moneda[] monedas;



        int cartaActual;

        public Random numerosAleatorios;

        public Partida(Servidor server, string nombre, int tiempo, Jugador[] jugadores)
        {
            this.server = server;
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.jugadores = jugadores;
            cartaActual = 0;
            numerosAleatorios = new Random();
            crearJuego();

        }

        private void crearJuego()
        {
            this.losetasTrabajadores = new LosetaTrabajador[44];
            this.tablerosPoblados = new TableroPoblado[4];
            this.losetasJungla = new LosetaJungla[28];
            this.fichasCacao = new FichaCacao[20];
            this.fichasSol = new FichaSol[12];
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

                    losetasTrabajadores[contador] = new LosetaTrabajador("Loseta Trabajador", false, jugadores[i].Color, posicionesCartasTrabajadores);

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
                    losetasJungla[i] = new LosetaJungla("plantacion simple", bandera);
                }
                else
                // Plantaciones doble x2
                if (i >= 6 && i < 8)
                {
                    losetasJungla[i] = new LosetaJungla("plantacion doble", bandera);
                }
                else
                // Mercado precio 2 x2
                if (i >= 8 && i < 10)
                {
                    losetasJungla[i] = new LosetaJungla("mercado 2", bandera);
                }
                else
                // Mercado precio 3 x4
                if (i >= 10 && i < 14)
                {
                    losetasJungla[i] = new LosetaJungla("mercado 3", bandera);
                }
                else
                // Mercado precio 4 x1
                if (i >= 14 && i < 15)
                {
                    losetasJungla[i] = new LosetaJungla("mercado 4", bandera);
                }
                else
                // Mina 1 x2
                if (i >= 15 && i < 17)
                {
                    losetasJungla[i] = new LosetaJungla("mina de oro 1", bandera);
                }
                else
                // Mina 2 x1
                if (i >= 17 && i < 18)
                {
                    losetasJungla[i] = new LosetaJungla("mina de oro 2", bandera);
                }
                else
                // Agua x3
                if (i >= 18 && i < 21)
                {
                    losetasJungla[i] = new LosetaJungla("agua", bandera);
                }
                else
                //Adoracion al sol x2
                if (i >= 21 && i < 23)
                {
                    losetasJungla[i] = new LosetaJungla("adoracion al sol", bandera);
                }
                else
                // templos x5
                if (i >= 23 && i < 28)
                {
                    losetasJungla[i] = new LosetaJungla("templo", bandera);
                }
            }
        }
        
        
    private void inicializarFichasCacao()
        {
            for (int i = 0; i < 20; i++)
            {
                fichasCacao[i] = new FichaCacao();
            }
        }
        private void inicializarFichasSol()
        {
            for (int i = 0; i < 12; i++)
            {
                fichasSol[i] = new FichaSol();
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
        private LosetaJungla[] eliminarLosetaJungla(LosetaJungla[] lj, int posToDelete)
        {
            LosetaJungla[] ljungla = new LosetaJungla[lj.Length - 1];
            int cont = 0;
            int i = posToDelete;
            while (i < lj.Length - 1)
            {
                lj[i] = lj[i + 1];
                i++;
            }
            lj[lj.Length - 1] = null;
            foreach (LosetaJungla l in lj)
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
        private LosetaTrabajador[] eliminarLosetaTrabajdor(LosetaTrabajador[] lj, int posToDelete)
        {
            LosetaTrabajador[] ltrabajador = new LosetaTrabajador[lj.Length - 1];
            int cont = 0;
            int i = posToDelete;
            while (i < lj.Length - 1)
            {
                lj[i] = lj[i + 1];
                i++;
            }
            lj[lj.Length - 1] = null;
            foreach (LosetaTrabajador l in lj)
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

        }
        // Barajar las cartas
        private void barajar(int numeroJugadores)
        {
            int numero = 0;
            if(numeroJugadores == 4)
            {
                numero = 36;
            }
            else
            {
                if (numeroJugadores == 3)
                {
                    numero = 30;
                }
                else
                {
                    numero = 22;
                }
            }

            cartaActual = 0;
            MessageBox.Show(losetasTrabajadores.Length.ToString());
            for (int primera = 0; primera < losetasTrabajadores.Length; primera++)
            {
                int segunda = numerosAleatorios.Next(numero);
                if (losetasTrabajadores[segunda] != null && losetasTrabajadores[primera]!=null);
                {
                    LosetaTrabajador temporal = losetasTrabajadores[primera];
                    losetasTrabajadores[primera] = losetasTrabajadores[segunda];
                    losetasTrabajadores[segunda] = temporal;
                }

            }
            MessageBox.Show(losetasTrabajadores.Length.ToString());
        }

        private void inicializarBarajasJugadores()
        {
           
            for (int i = 0; i < this.jugadores.Length; i++)
            {int contador = 0;
                foreach (LosetaTrabajador l in losetasTrabajadores)
                {
                    
                    if (l != null && l.Colors == jugadores[i].Color && contador<jugadores[i].LosetasTrabajadores.Length)
                    {
                        jugadores[i].LosetasTrabajadores[contador] = l;
                        contador += 1;
                    }
 
                }

            }

        }

    }
}
