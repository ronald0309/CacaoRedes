using Cacao.Clases;
using Cacao.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao
{
    public partial class TableroPoblado : UserControl
    {
        //TPoblado tpoblado;
        string color;
        int oro;
        Meeple meeple;
        FCacao[] fichaCacao;
        FSol[] fichaSol;
        static string urlImagenVisible = "tablero";
        public TableroPoblado() { }
        public TableroPoblado(string color)
        {
            

          
           
            this.color = color;
            this.meeple = new Meeple(this.color);
            this.fichaCacao = new FCacao[5];
            this.fichaSol = new FSol[3];
            cargarMapa();
            moverMeeple(16);
            actualizarFichasCacao(true);
            actualizarFichasCacao(true);
            actualizarFichasCacao(true);
            actualizarFichasCacao(true);
            actualizarFichasCacao(true);
            actualizarFichasSol(true);

            actualizarFichasSol(true);
            actualizarFichasSol(true);
            actualizarFichasSol(true);
            actualizarFichasSol(true);
            actualizarFichasSol(false);
            actualizarFichasSol(false);
            actualizarFichasSol(true);


            this.Location = new Point(15,100);
            InitializeComponent();
            //Meeple m = new Meeple("Gris");
            //tpoblado = new TPoblado("Gris",m);
            //this.Controls.Add(tpoblado);
        }

        private void actualizarFichasCacao(bool v)
        {
            for (int i = 0; i < fichaCacao.Length; i++){
                if (v){
                    if (fichaCacao[i] == null){
                        fichaCacao[i] = new FCacao();

                        this.fichaCacao[i].Location = obtenerPosFichaCacao(i);
                        this.fichaCacao[i].BackColor = Color.Transparent;
                        //obtenerFocusAguador(v, meeple.Image);
                        this.fichaCacao[i].Parent = this;
                        if (i == 1) {
                            fichaCacao[i].Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                        }else if (i == 2) {
                            fichaCacao[i].Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                        }else if (i == 3) {
                            fichaCacao[i].Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                        }else if (i == 4) {
                            fichaCacao[i].Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                        }

                        this.Controls.Add(this.fichaCacao[i]);
                        break;
                    }
                }else if(!v){
                    if (fichaCacao[i] != null) {
                        this.Controls.Remove(this.fichaCacao[i]);
                        fichaCacao[i] = null;
                        break;
                    }
                }
            }
        }

        private Point obtenerPosFichaCacao(int i)
        {
            switch (i)
            {
                case 0:
                    return new Point(0, 348);
                    break;
                case 1:
                    return new Point(0, 313);
                    break;
                case 2:
                    return new Point(0, 275);
                    break;
                case 3:
                    return new Point(0, 239);
                    break;
                case 4:
                    return new Point(0, 202);
                    break;
                default:
                    return new Point(0, 50);
                    break;
            }
        }

        private void actualizarFichasSol(bool v){
            for (int i = 0; i < fichaSol.Length; i++)
            {
                if (v)
                {
                    if (fichaSol[i] == null)
                    {
                        fichaSol[i] = new FSol();

                        this.fichaSol[i].Location = obtenerPosFichasSol(i);
                        this.fichaSol[i].BackColor = Color.Transparent;
                        //obtenerFocusAguador(v, meeple.Image);
                        this.fichaSol[i].Parent = this;

                        this.Controls.Add(this.fichaSol[i]);
                        break;
                    }
                }
                else if (!v)
                {
                    if (fichaSol[i] != null)
                    {
                        this.Controls.Remove(this.fichaSol[i]);
                        fichaSol[i] = null;
                        break;
                    }
                }
            }
        }

        private Point obtenerPosFichasSol(int i){
            switch (i)
            {
                case 0:
                    return new Point(260, 130);
                    break;
                case 1:
                    return new Point(190,158);
                    break;
                case 2:
                    return new Point(260,230);
                    break;
                default:
                    return new Point(0, 50);
                    break;
            }
        }

        void cargarMapa()
        {
            string tableroColor = urlImagenVisible + Colores.seleccionarColor(this.color);
            Image tableroimagen = new Bitmap(Application.StartupPath + @"\Recursos\" + tableroColor + ".png");
            this.BackgroundImage = tableroimagen;

        }
       
        private void moverMeeple(int v)
        {
            this.oro = v;
            string meepleColor = "meeple" + Colores.seleccionarColor(this.color);
           
            //this.meeple.Size = p.Size;
            //this.meeple.SizeMode = p.SizeMode;
            this.meeple.Location = obtenerFocusAguador(v);

            this.meeple.BackColor = Color.Transparent;

            //obtenerFocusAguador(v, meeple.Image);
           this.meeple.Parent = this;

           this.Controls.Add(meeple);

            //carga la imagen de los meples con el color y la distribucion correspondiente
            //PictureBox m = new PictureBox();


            //m.Load(Application.StartupPath + @"\Recursos\" + meepleColor + ".png");
            //obtenerFocusAguador(v).Location = new System.Drawing.Point(0, 0);
            //// m.SizeMode = PictureBoxSizeMode.CenterImage;
            //obtenerFocusAguador(v).SizeMode = PictureBoxSizeMode.Zoom;
            ////m.Height = this.Height ;
            ////m.Width = this.Width ;
            //obtenerFocusAguador(v).ClientSize = new Size(150, 150);
            //obtenerFocusAguador(v).BackColor = Color.Transparent;

            //obtenerFocusAguador(v).Parent = this;
        }


        public Point obtenerFocusAguador(int oro) {

            switch (oro)
            {
                case -10:
                    return new Point(15,50);
                    break;
                case -4:
                    return new Point(180,41);
                    break;
                case -1:
                    return new Point(319, 41);
                    break;
                case 0:
                    return new Point(348,79);
                    break;
                case 2:
                    return new Point(348,170);
                    break;
                case 4:
                    return new Point(348,289);
                    break;
                case 7:
                    return new Point(319, 319);
                    break;
                case 11:
                    return new Point(197, 320);
                    break;
                case 16:
                    return new Point(91,313);
                    break;
                default:
                    return new Point(0,0);
                    break;
            }
                
        }

       
    }
}
