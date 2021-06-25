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
        public VistaJuego()
        {
            InitializeComponent();
           


            Servidor ss = new Servidor("192.168.100.45",8080);
            Jugador[] js = new Jugador[4];
            js[0] = new Jugador("Far",22,"Rojo",js.Length);
            js[1] = new Jugador("Farlol", 22, "Azul", js.Length);
            js[2] = new Jugador("Farrrrr", 12, "Blanco", js.Length);
            js[3] = new Jugador("Farrr xdr", 12, "Lima", js.Length);
            Partida p = new Partida(ss,"JAJA",0,js);
            //foreach (LTrabajador l in js[0].LosetasTrabajadores) { 
            //tableroJuego1.obtenerMesa().Controls.Add(l);
            //}
            //    foreach (LTrabajador l in js[1].LosetasTrabajadores)
            //{
            //    tableroJuego1.obtenerMesa().Controls.Add(l);
            //}
            int tamanoMatrizX =18;
            int tamanoMatrizY = 11;
            LTrabajador[][] matrizJuego = new LTrabajador[tamanoMatrizX][];
            for(int i =0; i < tamanoMatrizX; i++)
            {
                matrizJuego[i] = new LTrabajador[tamanoMatrizY];
            }
            for (int i = 0; i < tamanoMatrizX; i++)
            {
                for (int j = 0; j < tamanoMatrizY; j++)
                {
                    int[] posicionesCartasTrabajadores = { 1, 1, 1, 1 };
                    matrizJuego[i][j] = new LTrabajador("Loseta Trabajador", true,"Rojo", posicionesCartasTrabajadores);

                }
            }
            for (int i = 0; i < tamanoMatrizX; i++)
            {
                for (int j = 0; j < tamanoMatrizY; j++)
                {
                    tableroJuego1.obtenerMesa().Controls.Add(matrizJuego[i][j]);
                }
            }
            //prueba.Controls.Add(lt);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
