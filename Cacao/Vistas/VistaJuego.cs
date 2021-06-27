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
            p.jugadores[0].CargarMasoMano();
            CargarMasoMano();
            ////CargarMatriz();
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[0]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[1]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[2]);
            //tableroJuego1.obtenerMesa().Cursor = new Cursor(Cursor.GetType(),"Select");
            //if (tableroJuego1.obtenerMesa()) {
            //    MessageBox.Show("AUCH...");
            //};
            this.Controls.Add(js[0].TPoblado);
        }

        public void iniMat() {
            foreach (LTrabajador l in p.jugadores[0].LosetasTrabajadores) { 
                //tableroJuego1.
            }
            
        }
        public void CargarMasoMano()
        {
            for (int i = 0; i < 3; i++)
            {
               // p.jugadores[0].masoMano[i] = new PictureBox();
                p.jugadores[0].CargarMasoMano();
                //p.jugadores[0].masoMano[i].IsOculta = true;
                //p.jugadores[0].masoMano[i].voltearLoseta();
                p.jugadores[0].masoMano[i].Click += (sendr, EventArgs) => { ClickMasoMano(sendr, EventArgs); };
                
                flpMazoMano.Controls.Add(p.jugadores[0].masoMano[i]);
            }
        }
        private void ClickMasoMano(object sender, EventArgs e)
        {
            MessageBox.Show("Auch... Pinchaste la posición [" + this.flpMazoMano.Controls.GetChildIndex((LTrabajador)sender) + "]");
        }
        public void InicializarMatriz()
        {
            int matX = 18;
            int matY = 11;
            //int[] k = { 1, 1, 1, 1 };

            this.tableroJuego1.obtenerMesa().BorderStyle = BorderStyle.Fixed3D;
            for (int i = 0; i < matX; i++)
            {
                for (int j = 0; j < matY; j++)
                {
                    //l[i, j] = new LTrabajador("Loseta Trabajador",true,"Lima",k);
                    tableroJuego1.l[i, j] = new PictureBox();
                    tableroJuego1.l[i, j].Margin = new Padding(0, 0, 0, 0);
                    tableroJuego1.l[i, j].Padding = new Padding(0, 0, 0, 0);
                    tableroJuego1.l[i, j].Size = new Size(79, 79);
                    tableroJuego1.l[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    this.tableroJuego1.obtenerMesa().Controls.Add(tableroJuego1.l[i, j]);
                    //l[i, j].Image = null;
                    tableroJuego1.l[i, j].Click += (sendr, EventArgs) => { ClickLoseta(sendr, EventArgs); };
                }
            }
        }
        private void ClickLoseta(object sender, EventArgs e)
        {
            MessageBox.Show("Auch... Pinchaste la posición [" + this.tableroJuego1.obtenerMesa().Controls.GetChildIndex((PictureBox)sender) + "]");
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
