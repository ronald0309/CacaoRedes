using Cacao.Clases;
using Cacao.Sock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao
{
    public partial class VistaJuego : Form
    {
        Servidor ss = new Servidor("192.168.100.45", 8080);
        Jugador[] js = new Jugador[4];
        Partida p;
        
        
        public VistaJuego()
        {
            InitializeComponent();
            js[0] = new Jugador("Far",22,"Rojo",js.Length);
            js[1] = new Jugador("Farlol", 22, "Azul", js.Length);
            js[2] = new Jugador("Farrrrr", 12, "Blanco", js.Length);
            js[3] = new Jugador("Farrr xdr", 12, "Lima", js.Length);
            p = new Partida(ss,"JAJA",0,js);

            InicializarMatriz();
            CargarMatriz();
            flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[0]);
            flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[1]);
            flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[2]);

            this.Controls.Add(js[0].TPoblado);
        }
        public void InicializarMatriz()
        {
            p.matrizJuego = new LTrabajador[p.tamanoMatrizX][];
            for (int i = 0; i < p.tamanoMatrizX; i++)
            {
                p.matrizJuego[i] = new LTrabajador[p.tamanoMatrizY];
            }
            for (int i = 0; i < p.tamanoMatrizX; i++)
            {
                for (int j = 0; j < p.tamanoMatrizY; j++)
                {
                    int[] posicionesCartasTrabajadores = { 1, 1, 1, 1 };
                    p.matrizJuego[i][j] = new LTrabajador("Loseta Trabajador", true, "Rojo", posicionesCartasTrabajadores);
                    p.matrizJuego[i][j].Click += (sendr, EventArgs) => { Partida_Click(sendr, EventArgs, i, j); };
                }
            }
        }
        private void Partida_Click(object sender, EventArgs e, int i, int j)
        {
            p.matrizJuego[i - 1][j - 1] = p.losetasTrabajadores[0];
            p.matrizJuego[i - 1][j - 1].IsOculta = false;
            tableroJuego1.obtenerMesa().Controls.Clear();
            CargarMatriz();
            return;
        }
        public void CargarMatriz()
        {
            for (int i = 0; i < p.tamanoMatrizX; i++)
            {
                for (int j = 0; j < p.tamanoMatrizY; j++)
                {
                    tableroJuego1.obtenerMesa().Controls.Add(p.matrizJuego[i][j]);
                }
            }
        }
    }
}
