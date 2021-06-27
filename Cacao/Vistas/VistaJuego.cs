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
            
            js[0] = new Jugador("Far",22,"Rojo",js.Length);
            js[1] = new Jugador("Farlol", 22, "Azul", js.Length);
            js[2] = new Jugador("Farrrrr", 12, "Blanco", js.Length);
            js[3] = new Jugador("Farrr xdr", 12, "Lima", js.Length);
            p = new Partida(ss,"JAJA",0,js);

            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[0]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[1]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[2]);
            //tableroJuego1.obtenerMesa().Cursor = new Cursor(Cursor.GetType(),"Select");
            //if (tableroJuego1.obtenerMesa()) {
            //    MessageBox.Show("AUCH...");
            //};
            InitializeComponent();

            
            inicializarMatrizJuego();
            cMazo();
            //p.jugadores[0].mazoMano[0].Draggable(true);
            //ControlExtension.Draggable(p.jugadores[0].mazoMano[0], true);
            //ControlExtension.Draggable();
            //flpMazoMano.Controls.Add(js[3].mazoMano[1]);
            //flpMazoMano.Controls.Add(js[3].mazoMano[2]);
            //flpMazoMano.Controls.Add(js[3].mazoMano[0]);
            //this.Controls.Add(js[0].TPoblado);
            //this.Controls.Add(js[1].TPoblado);
            //this.Controls.Add(js[2].TPoblado);
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
                    // matrizTablero[i, j] = new LTrabajador("Loseta Trabajador",true,"Lima",k);
                    this.tableroJuego1.matrizTablero[i, j] = new PictureBox();
                    this.tableroJuego1.matrizTablero[i, j].Margin = new Padding(0, 0, 0, 0);
                    this.tableroJuego1.matrizTablero[i, j].Padding = new Padding(0, 0, 0, 0);
                    this.tableroJuego1.matrizTablero[i, j].Size = new Size(79, 79);
                    this.tableroJuego1.matrizTablero[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    this.tableroJuego1.matrizTablero[i, j].AllowDrop = true;
                    this.tableroJuego1.matrizTablero[i, j].BorderStyle = BorderStyle.Fixed3D;

                    //$$%%&&l[i, j].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0); };
                    this.tableroJuego1.matrizTablero[i, j].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar_matriz_tablero(sendr, EventArgs, 0); };
                    this.tableroJuego1.matrizTablero[i, j].DragDrop += (sendr, EventArgs) => { control_mouse_al_terminar_arrastre_matriz_tablero(sendr, EventArgs, 0); };

                    this.tableroJuego1.obtenerMesa().Controls.Add(this.tableroJuego1.matrizTablero[i, j]);
                    //l[i, j].Image = null;
                    //l[i, j].Click += (sendr, EventArgs) => { ClickLoseta(sendr, EventArgs); };
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

                                                                                     //INICIO MATRIZ TABLERO//

        private void cMazo() {
            int cont = 0;
            //if (Singlenton.Instance.fueMovida)
            {
                foreach (LTrabajador L in p.jugadores[0].mazoMano)
                {

                    if (L == null)
                    {
                        for (int i = 0; i < p.jugadores[0].LosetasTrabajadores.Length; i++)
                        {
                            if (p.jugadores[0].LosetasTrabajadores[i] != null)
                            {
                                p.jugadores[0].mazoMano[cont] = p.jugadores[0].LosetasTrabajadores[i];
                                p.jugadores[0].LosetasTrabajadores[i] = null;
                                p.jugadores[0].mazoMano[cont].AllowDrop = true;
                                p.jugadores[0].mazoMano[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                                p.jugadores[0].mazoMano[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                                //p.jugadores[0].mazoMano[cont].DragDrop += (sendr, EventArgs) => { control_mouse_al_terminar_arrastre(sendr, EventArgs, 0, cont); };
                                p.jugadores[0].mazoMano[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                                p.jugadores[0].mazoMano[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };
                                //p.jugadores[0].mazoMano[cont].QueryContinueDrag  += (sendr, EventArgs) => { control_mouse_change(sendr, EventArgs); };



                                break;
                            }
                        }
                    }
                    flpMazoMano.Controls.Add(p.jugadores[0].mazoMano[cont]);
                    cont += 1;

                }


                //Singlenton.Instance.fueMovida = false;
            }



        }

        private void cargarMazoMano()
        {
            
            int cont = 0;
            //if (Singlenton.Instance.fueMovida)
            {
                    foreach (LTrabajador L in flpMazoMano.Controls) {

                if (L.Image == null) {
                    for (int i = 0; i < p.jugadores[0].LosetasTrabajadores.Length; i++)
                    {
                        if (p.jugadores[0].LosetasTrabajadores[i] != null)
                        {
                            p.jugadores[0].mazoMano[cont] = p.jugadores[0].LosetasTrabajadores[i];
                            p.jugadores[0].LosetasTrabajadores[i]= null;
                            p.jugadores[0].mazoMano[cont].AllowDrop = true;
                            p.jugadores[0].mazoMano[cont].MouseDown += (sendr, EventArgs) => { control_mouse_al_presionar(sendr, EventArgs, 0, cont); };
                            p.jugadores[0].mazoMano[cont].DragEnter += (sendr, EventArgs) => { control_mouse_al_arrastrar(sendr, EventArgs, 0, cont); };
                            //p.jugadores[0].mazoMano[cont].DragDrop += (sendr, EventArgs) => { control_mouse_al_terminar_arrastre(sendr, EventArgs, 0, cont); };
                            p.jugadores[0].mazoMano[cont].MouseHover += (sendr, EventArgs) => { control_mouse_sobre(sendr, EventArgs); };
                            p.jugadores[0].mazoMano[cont].MouseLeave += (sendr, EventArgs) => { control_mouse_sale(sendr, EventArgs); };
                            //p.jugadores[0].mazoMano[cont].QueryContinueDrag  += (sendr, EventArgs) => { control_mouse_change(sendr, EventArgs); };

                            
                            
                            break;
                        }
                    }
                }
                    
                
                cont += 1;
            
            }
            flpMazoMano.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                    flpMazoMano.Controls.Add(p.jugadores[0].mazoMano[i]);
                }
                //Singlenton.Instance.fueMovida = false;
            }
            
        }


        //private void control_mouse_change(object sendr, EventArgs eventArgs)
        //{
        //    if (Singlenton.Instance.fueMovida) {
        //        cargarMazoMano();
        //        Singlenton.Instance.fueMovida = false;
        //    }
        //}

        private void control_mouse_sale(object sendr, EventArgs eventArgs)
        {
            Cursor = Cursors.Default;
        }

        private void control_mouse_sobre(object sendr, EventArgs eventArgs)
        {

            Cursor = Cursors.Hand;

        }

        //private void control_mouse_al_soltar_mouse(object sendr, EventArgs eventArgs)
        //{
        //    if (Singlenton.Instance.SELECCIONADA == null && p.jugadores[0].mazoMano[0] == null ||
        //        p.jugadores[0].mazoMano[1] == null || p.jugadores[0].mazoMano[2] == null) {

        //        cargarMazoMano();
        //    }
        //}

        //private void control_mouse_al_terminar_arrastre(object sendr, DragEventArgs e, int v, int cont)
        //{
        //    PictureBox pic = (PictureBox)sendr;
        //        PictureBox org = (PictureBox) Singlenton.Instance.SELECCIONADA;

        //    if (pic.Name != org.Name) {

        //        pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

        //        org.Image = null;
        //        //Singlenton.Instance.SELECCIONADA = null;
        //        //cargarMazoMano();
        //    }
           
        //}

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

            PictureBox pic = (LTrabajador) sendr;
            Singlenton.Instance.SELECCIONADA = (LTrabajador) sendr;


            if (e.Button == MouseButtons.Left) {
                {
                    if (pic.Image != null) {
                        pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                    }
                }
            }

        }

        //private void inicializarMazoVisible()
        //{

        //    for (int i = 0; i < p.jugadores.Length; i++)
        //    {
        //        if (p.jugadores[i] != null)
        //        {
        //            for (int j = 0; j < p.jugadores[i].LosetasTrabajadores.Length; j++)
        //            {

        //                for (int k = 0; k < 3; k++)
        //                {
        //                    if (p.jugadores[i].mazoMano[k] != null)
        //                    {
        //                        p.jugadores[i].mazoMano[k] = new LTrabajador();
        //                        p.jugadores[i].mazoMano[k] = p.jugadores[i].LosetasTrabajadores[j];
        //                        p.jugadores[i].LosetasTrabajadores[j] = null;
        //                        //jugadores[i].mazoMano[k].Click
        //                        //p.jugadores[i].mazoMano[k].IsOculta = true;
        //                        //p.jugadores[i].mazoMano[k].voltearLoseta();
        //                        p.jugadores[i].mazoMano[k].Click += (sendr, EventArgs) => { ClickMazoVisible(sendr, EventArgs, i, k); };
                                
        //                        //p.jugadores[i].mazoMano[k].Padding = new Padding(3, 3, 3, 3);
        //                        //p.jugadores[i].mazoMano[k].BackColor = Color.Blue;

        //                        //p.
        //                        //break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void VistaJuego_MouseDown(object sender, MouseEventArgs e, int i, int k)
        //{
        //    p.jugadores[i].mazoMano[k].DoDragDrop(p.jugadores[0].mazoMano[0], DragDropEffects.Copy | DragDropEffects.Move);
        //    ControlExtension.Draggable(p.jugadores[i].mazoMano[k],true);
        //    MessageBox.Show("Auch... Pinchaste la posición [" + flpMazoMano.Controls.GetChildIndex((PictureBox)sender) + "]");
        //}

        private void ClickMazoVisible(object sendr, EventArgs eventArgs, int i, int k)
        {
            //p.jugadores[i].mazoMano[k].MouseDown += (sendr, EventArgs) => { VistaJuego_MouseDown(sendr, EventArgs, i, k); };


            //p.jugadores[0].mazoMano[0].DoDragDrop(p.jugadores[0].mazoMano[0], DragDropEffects.Copy | DragDropEffects.Move);
            //MessageBox.Show("Auch... Pinchaste la posición [" + flpMazoMano.Controls.GetChildIndex((PictureBox)sendr) + "]");


            //if (Singlenton.Instance.SELECCIONADA == null)
            //{
            //    foreach (LTrabajador ll in p.jugadores[i ].mazoMano) {
            //        if (ll == null) { 
            //        cargarMazoMano();
            //        }

            //    }

            //    MessageBox.Show("Auch... Pinchaste la posición [" + flpMazoMano.Controls.GetChildIndex((PictureBox)sendr) + "]");
            //    //p.jugadores[i - 1].mazoMano[k].SeleccionarLoseta();
            //    Singlenton.Instance.SELECCIONADA = p.jugadores[i].mazoMano[k];
            //    p.jugadores[i].mazoMano[k] = null;
            //    }
            //else {
            //    MessageBox.Show("-------------------------------" + flpMazoMano.Controls.GetChildIndex((PictureBox)sendr) + "]");
            //    p.jugadores[i].mazoMano[k]= Singlenton.Instance.SELECCIONADA;
            //    p.jugadores[i].mazoMano[k].SeleccionarLoseta();
            //    //cargarMazoMano(i, k);
            //    Singlenton.Instance.SELECCIONADA=null;
            //}


            //Singlenton.Instance.SELECCIONADA = p.jugadores[i - 1].mazoMano[k];

            //p.jugadores[i].mazoMano[k]
            // 
            // p.jugadores[i].mazoMano[k].BackColor = Color.Blue;
        }

        //public void cargarMazoMano(int i, int k) {
        //    foreach (LTrabajador l in p.jugadores[i - 1].LosetasTrabajadores)
        //    {
        //        if(l != null && p.jugadores[i - 1].mazoMano[k] == null)
        //        {
        //            p.jugadores[i - 1].mazoMano[k] = l;
        //            flpMazoMano.Controls.Add(p.jugadores[i - 1].mazoMano[k]);
        //            p.jugadores[i-1].mazoMano[k].Click += (sendr, EventArgs) => { ClickMazoVisible(sendr, EventArgs, i, k); };
        //            //break;
        //        }
        //    }
        //}


        //public FlowLayoutPanel devolverPosicionCartasVisibles() {
        //    return flpMazoMano;
        //}

        //public void ActualizarMazoMano() { 
        
        
        //}
        
    }
}
