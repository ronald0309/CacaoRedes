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
        Servidor ss = new Servidor("192.168.100.45", 8080,4);
        Jugador[] js = new Jugador[4];
        Partida p;
        public int numeroJugador;

        public VistaJuego()
        {

            numeroJugador = 2;
            js[0] = new Jugador("Far",22,"Rojo",js.Length);
            js[1] = new Jugador("Farlol", 22, "Azul", js.Length);
            js[2] = new Jugador("Farrrrr", 12, "Blanco", js.Length);
            js[3] = new Jugador("Farrr xdr", 12, "Lima", js.Length);

            p = new Partida(ss,"JAJA",0,js);

            
            InitializeComponent();

            
            inicializarMatrizJuego();
            cMazo();
            cLosetaJungla();
            foreach (Control c in tableroJuego1.Controls) { 

            //c.MouseUp += (sendr, EventArgs) => { control_mouse_al_soltar_mouse(sendr, EventArgs); };
            }
        }

                                                                            //INICIO MATRIZ TABLERO//

        public void inicializarMatrizJuego() {

            for (int i = 0; i < this.tableroJuego1.matX; i++)
            {
                for (int j = 0; j < this.tableroJuego1.matY; j++)
                {
                    this.tableroJuego1.matrizTablero[i, j] = new PictureBox();
                    this.tableroJuego1.matrizTablero[i, j].Margin = new Padding(0, 0, 0, 0);
                    this.tableroJuego1.matrizTablero[i, j].Padding = new Padding(0, 0, 0, 0);
                    this.tableroJuego1.matrizTablero[i, j].Size = new Size(79, 79);
                    this.tableroJuego1.matrizTablero[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    this.tableroJuego1.matrizTablero[i, j].AllowDrop = true;
                    this.tableroJuego1.matrizTablero[i, j].BorderStyle = BorderStyle.Fixed3D;
                    this.tableroJuego1.matrizTablero[i, j].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar_matriz_tablero(sendr, EventArgs, 0); };
                    this.tableroJuego1.matrizTablero[i, j].DragDrop += (sendr, EventArgs) => { control_mouse_al_terminar_arrastre_matriz_tablero(sendr, EventArgs, 0); };

                    this.tableroJuego1.obtenerMesa().Controls.Add(this.tableroJuego1.matrizTablero[i, j]);
                }
            }
        }
        private void control_mouse_al_terminar_arrastre_matriz_tablero(object sendr, DragEventArgs e, int v)
        {
            PictureBox pic = (PictureBox)sendr;
            PictureBox org = Singlenton.Instance.SELECCIONADA;

            if (pic.Image != org.Image)
            {

                pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                org.Image = null;
                Singlenton.Instance.SELECCIONADA = null;
                Singlenton.Instance.fueMovida = true;
                cargarMazoMano();
                cargarLosetaJungla();
            }
            else {

                Singlenton.Instance.fueMovida = false;
            }
        }


        private void control_mouse_al_arrastrar_matriz_tablero(object sendr, DragEventArgs e, int v)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void cLosetaJungla()
        {
            LJungla[] losetas = new LJungla[2];
            int cont = 0;
            {
                foreach (LJungla L in losetas)
                {

                    if (L == null)
                    {
                        for (int i = 0; i < p.losetasJungla.Length; i++)
                        {
                            if (p.losetasJungla[i] != null)
                            {
                                losetas[cont] = p.losetasJungla[i];
                                p.losetasJungla[i] = null;
                                losetas[cont].AllowDrop = true;
                                losetas[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                                losetas[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                                losetas[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                                losetas[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };



                                break;
                            }
                        }
                    }
                    flpLosetaJungla.Controls.Add(losetas[cont]);
                    cont += 1;

                }
            }



        }

        private void cargarLosetaJungla()
        {
            LJungla[] losetas = new LJungla[2];
            int cont = 0;
            {
                foreach (LJungla L in flpLosetaJungla.Controls)
                {

                    if (L.Image == null)
                    {
                        for (int i = 0; i < p.losetasJungla.Length; i++)
                        {
                            if (p.losetasJungla[i] != null)
                            {
                                losetas[cont] = p.losetasJungla[i];
                                p.losetasJungla[i] = null;
                                losetas[cont].AllowDrop = true;
                                losetas[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                                losetas[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                                losetas[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                                losetas[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };
                                break;
                            }
                        }
                    }
                    else
                    {
                        losetas[cont] = L;
                    }


                    cont += 1;

                }
                flpLosetaJungla.Controls.Clear();
                for (int i = 0; i < 2; i++)
                {
                    flpLosetaJungla.Controls.Add(losetas[i]);
                }
            }

        }                                                                             //INICIO MATRIZ TABLERO//

        private void cMazo() {
            int cont = 0;
            {
                foreach (LTrabajador L in p.jugadores[numeroJugador].mazoMano)
                {

                    if (L == null)
                    {
                        for (int i = 0; i < p.jugadores[numeroJugador].LosetasTrabajadores.Length; i++)
                        {
                            if (p.jugadores[numeroJugador].LosetasTrabajadores[i] != null)
                            {
                                p.jugadores[numeroJugador].mazoMano[cont] = p.jugadores[numeroJugador].LosetasTrabajadores[i];
                                p.jugadores[numeroJugador].LosetasTrabajadores[i] = null;
                                p.jugadores[numeroJugador].mazoMano[cont].AllowDrop = true;
                                p.jugadores[numeroJugador].mazoMano[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                                p.jugadores[numeroJugador].mazoMano[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                                p.jugadores[numeroJugador].mazoMano[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                                p.jugadores[numeroJugador].mazoMano[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };



                                break;
                            }
                        }
                    }
                    flpMazoMano.Controls.Add(p.jugadores[numeroJugador].mazoMano[cont]);
                    cont += 1;

                }
            }



        }

        private void cargarMazoMano()
        {
            
            int cont = 0;
            {
                    foreach (LTrabajador L in flpMazoMano.Controls) {

                if (L.Image == null) {
                    for (int i = 0; i < p.jugadores[numeroJugador].LosetasTrabajadores.Length; i++)
                    {
                        if (p.jugadores[numeroJugador].LosetasTrabajadores[i] != null)
                        {
                            p.jugadores[numeroJugador].mazoMano[cont] = p.jugadores[numeroJugador].LosetasTrabajadores[i];
                            p.jugadores[numeroJugador].LosetasTrabajadores[i]= null;
                            p.jugadores[numeroJugador].mazoMano[cont].AllowDrop = true;
                            p.jugadores[numeroJugador].mazoMano[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                            p.jugadores[numeroJugador].mazoMano[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                            p.jugadores[numeroJugador].mazoMano[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                            p.jugadores[numeroJugador].mazoMano[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };
                            break;
                        }
                    }
                }
                    
                
                cont += 1;
            
            }
            flpMazoMano.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                    flpMazoMano.Controls.Add(p.jugadores[numeroJugador].mazoMano[i]);
                }
            }
            
        }

        private void control_mouse_sale(object sendr, EventArgs eventArgs)
        {
            Cursor = Cursors.Default;
        }

        private void control_mouse_sobre(object sendr, EventArgs eventArgs)
        {

            Cursor = Cursors.Hand;

        }


        private void control_mouse_al_arrastrar(object sendr, DragEventArgs e, int v, int cont)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void control_mouse_al_presionar(object sendr, MouseEventArgs e, int v, int cont)
        {
           //Mouse Down

            PictureBox pic = (Loseta) sendr;
            Singlenton.Instance.SELECCIONADA = (Loseta) sendr;


            if (e.Button == MouseButtons.Left) {
                {
                    if (pic.Image != null) {
                        pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                    }
                }
            }

        }

        
    }
}
