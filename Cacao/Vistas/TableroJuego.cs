using Cacao.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Vistas
{
    public partial class TableroJuego : UserControl
    {

        public PictureBox[,] matrizTablero;
        public int matX = 18;
        public int matY = 11;

        public TableroJuego()
        {
            InitializeComponent();
            cargarVista();
        }

        public void cargarVista()
        {

            
            matrizTablero = new PictureBox[matX, matY];
            int[] k = { 1, 1, 1, 1 };

            this.flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            //this.flowLayoutPanel1.BringToFront();
            

        }

        private void control_mouse_al_terminar_arrastre(object sendr, DragEventArgs e, int v)
        {
            PictureBox pic = (PictureBox)sendr;
            PictureBox org = Singlenton.Instance.SELECCIONADA;

            if (pic.Image != org.Image)
            {

                pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                org.Image = null;
                Singlenton.Instance.SELECCIONADA=null;
                Singlenton.Instance.fueMovida = true;
            }
        }

        private void control_mouse_al_arrastrar(object sendr, DragEventArgs e, int v)
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

        private void control_mouse_al_presionar(object sendr, MouseEventArgs e, int v)
        {
            //Mouse Down

            //PictureBox pic = (PictureBox)sendr;
            //Singlenton.Instance.SELECCIONADA = (LTr)sendr;


            //if (e.Button == MouseButtons.Left)
            //{
            //    {
            //        if (pic.Image != null)
            //        {
            //            pic.DoDragDrop(pic.Image, DragDropEffects.Move);

            //        }
            //    }
            //}
        }

        private void ClickLoseta(object sender, EventArgs e)
        {
            
            if (Singlenton.Instance.SELECCIONADA != null)
            {
                MessageBox.Show("Auch... Pinchaste la posición ["+ flowLayoutPanel1.Controls.GetChildIndex((PictureBox) sender)+"]");
                //flowLayoutPanel1.Controls.Remove((Control)sender);
                //flowLayoutPanel1.Refresh();
                //flowLayoutPanel1.ResumeLayout();
                flowLayoutPanel1.Controls.Add(Singlenton.Instance.SELECCIONADA);// .SetChildIndex(Singlenton.Instance.SELECCIONADA, flowLayoutPanel1.Controls.GetChildIndex((PictureBox)sender));
               // Singlenton.Instance.SELECCIONADA.SeleccionarLoseta();

                Singlenton.Instance.SELECCIONADA = null;
                //VistaJuego.car
            }
            else {
                //flowLayoutPanel1.SuspendLayout();
                MessageBox.Show("Auch... ["+ flowLayoutPanel1.Controls.GetChildIndex((PictureBox) sender)+"]");

            }
        }

        private void Loseta_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        public FlowLayoutPanel obtenerMesa() {

            return flowLayoutPanel1;
        }

    }
}
