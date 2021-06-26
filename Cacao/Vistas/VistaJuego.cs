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

            //InicializarMatriz();
            //CargarMatriz();
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[0]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[1]);
            //flpMazoMano.Controls.Add(p.jugadores[0].LosetasTrabajadores[2]);
            //tableroJuego1.obtenerMesa().Cursor = new Cursor(Cursor.GetType(),"Select");
            //if (tableroJuego1.obtenerMesa()) {
            //    MessageBox.Show("AUCH...");
            //};
            inicializarMazoVisible();
            flpMazoMano.Controls.Add(js[2].mazoMano[1]);
            flpMazoMano.Controls.Add(js[3].mazoMano[2]);
            flpMazoMano.Controls.Add(js[1].mazoMano[0]);
            this.Controls.Add(js[0].TPoblado);
            //this.Controls.Add(js[1].TPoblado);
            //this.Controls.Add(js[2].TPoblado);
        }

        private void inicializarMazoVisible()
        {

            for (int i = 0; i < p.jugadores.Length; i++)
            {
                if (p.jugadores[i] != null)
                {
                    for (int j = 0; j < p.jugadores[i].LosetasTrabajadores.Length; j++)
                    {

                        for (int k = 0; k < p.jugadores[i].mazoMano.Length; k++)
                        {
                            if (p.jugadores[i].mazoMano[k] != null)
                            {
                                p.jugadores[i].mazoMano[k] = p.jugadores[i].LosetasTrabajadores[j];
                                //p.jugadores[i].LosetasTrabajadores[j]= null;
                                //jugadores[i].mazoMano[k].Click
                                //p.jugadores[i].mazoMano[k].IsOculta = true;
                                //p.jugadores[i].mazoMano[k].voltearLoseta();
                                p.jugadores[i].mazoMano[k].Click += (sendr, EventArgs) => { ClickMazoVisible(sendr, EventArgs,i, k); };
                                //p.jugadores[i].mazoMano[k].Padding = new Padding(3, 3, 3, 3);
                                //p.jugadores[i].mazoMano[k].BackColor = Color.Blue;
                                
                                //p.
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void ClickMazoVisible(object sendr, EventArgs eventArgs, int i, int k)
        {
            if (Singlenton.Instance.SELECCIONADA == null)
            {
                foreach (LTrabajador ll in p.jugadores[i - 1].mazoMano) {
                    if (ll == null) { 
                    cargarMazoMano(i, k);
                    }
                
                }
                
                MessageBox.Show("Auch... Pinchaste la posición [" + flpMazoMano.Controls.GetChildIndex((PictureBox)sendr) + "]");
                p.jugadores[i - 1].mazoMano[k].SeleccionarLoseta();
                Singlenton.Instance.SELECCIONADA = p.jugadores[i - 1].mazoMano[k];
                p.jugadores[i - 1].mazoMano[k] = null;
            }
            else {
                MessageBox.Show("-------------------------------" + flpMazoMano.Controls.GetChildIndex((PictureBox)sendr) + "]");
                p.jugadores[i - 1].mazoMano[k]= Singlenton.Instance.SELECCIONADA;
                p.jugadores[i - 1].mazoMano[k].SeleccionarLoseta();
                cargarMazoMano(i, k);
                Singlenton.Instance.SELECCIONADA=null;
            }
           

            //Singlenton.Instance.SELECCIONADA = p.jugadores[i - 1].mazoMano[k];

            //p.jugadores[i].mazoMano[k]
            // 
            // p.jugadores[i].mazoMano[k].BackColor = Color.Blue;
    }
        public void cargarMazoMano(int i, int k) {
            foreach (LTrabajador l in p.jugadores[i - 1].LosetasTrabajadores)
            {
                if(l != null && p.jugadores[i - 1].mazoMano[k] == null)
                {
                    p.jugadores[i - 1].mazoMano[k] = l;
                    flpMazoMano.Controls.Add(p.jugadores[i - 1].mazoMano[k]);
                    p.jugadores[i-1].mazoMano[k].Click += (sendr, EventArgs) => { ClickMazoVisible(sendr, EventArgs, i, k); };
                    break;
                }
            }
        }


        public FlowLayoutPanel devolverPosicionCartasVisibles() {
            return flpMazoMano;
        }

        public void ActualizarMazoMano() { 
        
        
        }

    }
}
