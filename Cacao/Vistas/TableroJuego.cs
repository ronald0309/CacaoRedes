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
        PictureBox[,] l;
        public TableroJuego()
        {
            InitializeComponent();
            cargarVista();
        }

        public void cargarVista()
        {
            int matX = 18;
            int matY = 11;
            l = new PictureBox[matX, matY];
            int[] k = { 1, 1, 1, 1 };

            this.flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            //this.flowLayoutPanel1.BringToFront();
            for (int i = 0; i < matX; i++)
            {
                for (int j = 0; j < matY; j++)
                {
                    l[i, j] = new LTrabajador("Loseta Trabajador",true,"Lima",k);
                    //l[i, j] = new PictureBox();
                    l[i, j].Margin = new Padding(0, 0, 0, 0);
                    l[i, j].Padding = new Padding(0, 0, 0, 0);
                    l[i, j].Size = new Size(79, 79);
                    l[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    l[i, j].BorderStyle = BorderStyle.Fixed3D;
                    this.flowLayoutPanel1.Controls.Add(l[i, j]);
                    //l[i, j].Image = null;
                    l[i, j].Click += (sendr, EventArgs) => { ClickLoseta(sendr, EventArgs); };
                }
            }

        }
        private void ClickLoseta(object sender, EventArgs e)
        {
            MessageBox.Show("Auch... Pinchaste la posición ["+ flowLayoutPanel1.Controls.GetChildIndex((PictureBox) sender)+"]");
            if (Singlenton.Instance.SELECCIONADA != null)
            {
                //flowLayoutPanel1.Controls.Remove((Control)sender);
                //flowLayoutPanel1.Refresh();
                //flowLayoutPanel1.ResumeLayout();
                flowLayoutPanel1.Controls.Add(Singlenton.Instance.SELECCIONADA);// .SetChildIndex(Singlenton.Instance.SELECCIONADA, flowLayoutPanel1.Controls.GetChildIndex((PictureBox)sender));
                Singlenton.Instance.SELECCIONADA.SeleccionarLoseta();

                Singlenton.Instance.SELECCIONADA = null;
            }
            else {
                //flowLayoutPanel1.SuspendLayout();
            }
        }

        


        //public FlowLayoutPanel obtenerMesa() {

        //    return flowLayoutPanel1;
        //}

    }
}
