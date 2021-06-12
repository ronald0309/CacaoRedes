using Cacao.Clases;
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
            FCacao f = new FCacao();
            FSol s = new FSol();
            // 1,1,1,1 // 1,2,1,0 // 0,3,1,0 // 1,3,0,0
            int[] n = { 1, 1, 1, 1 };

            LTrabajador lt1 = new LTrabajador("L1", false, "Amarillo", n);
            LTrabajador lt2 = new LTrabajador("L1", false, "Azul", n);
            LTrabajador lt3 = new LTrabajador("L1", false, "Azul Oscuro", n);
            LTrabajador lt4 = new LTrabajador("L1", false, "Blanco", n);
            LTrabajador lt5 = new LTrabajador("L1", false, "Cafe", n);
            LTrabajador lt6 = new LTrabajador("L1", false, "Celeste", n);
            LTrabajador lt7 = new LTrabajador("L1", false, "Cyan", n);
            LTrabajador lt8 = new LTrabajador("L1", false, "Fusia", n);
            LTrabajador lt9 = new LTrabajador("L1", false, "Gris", n);
            LTrabajador lt10 = new LTrabajador("L1", false, "Lima", n);
            LTrabajador lt11 = new LTrabajador("L1", false, "Morado", n);
            LTrabajador lt12 = new LTrabajador("L1", false, "Morado Oscuro", n);
            LTrabajador lt13 = new LTrabajador("L1", false, "Naranja", n);
            LTrabajador lt14 = new LTrabajador("L1", false, "Piel", n);
            LTrabajador lt15 = new LTrabajador("L1", false, "Rojo", n);
            LTrabajador lt16 = new LTrabajador("L1", false, "Rosa", n);
            LTrabajador lt17 = new LTrabajador("L1", false, "Verde", n);
            LTrabajador lt18 = new LTrabajador("L1", false, "Verde Claro", n);
            LTrabajador lt19 = new LTrabajador("L1", false, "Verde Oscuro", n);
            LTrabajador lt20 = new LTrabajador("L1", false, "Vino", n);
            LJungla lj = new LJungla("templo", false);
            //Meeple m = new Meeple("amarillo");
            Moneda mn = new Moneda(10);
            //prueba.Controls.Add(f);


            Jugador nj = new Jugador("J", 10, "Amarillo", 3);
            //prueba.Controls.Add(nj.Meeple);
            tableroJuego1.obtenerMesa().Controls.Add(lt1);
            tableroJuego1.obtenerMesa().Controls.Add(lt2);
            tableroJuego1.obtenerMesa().Controls.Add(lt3);
            tableroJuego1.obtenerMesa().Controls.Add(lt4);
            tableroJuego1.obtenerMesa().Controls.Add(lt5);
            tableroJuego1.obtenerMesa().Controls.Add(lt6);
            tableroJuego1.obtenerMesa().Controls.Add(lt7);
            tableroJuego1.obtenerMesa().Controls.Add(lt8);
            tableroJuego1.obtenerMesa().Controls.Add(lt9);
            tableroJuego1.obtenerMesa().Controls.Add(lt10);
            tableroJuego1.obtenerMesa().Controls.Add(lt11);
            tableroJuego1.obtenerMesa().Controls.Add(lt12);
            tableroJuego1.obtenerMesa().Controls.Add(lt13);
            tableroJuego1.obtenerMesa().Controls.Add(lt14);
            tableroJuego1.obtenerMesa().Controls.Add(lt15);
            tableroJuego1.obtenerMesa().Controls.Add(lt16);
            tableroJuego1.obtenerMesa().Controls.Add(lt17);
            tableroJuego1.obtenerMesa().Controls.Add(lt18);
            tableroJuego1.obtenerMesa().Controls.Add(lt19);
            tableroJuego1.obtenerMesa().Controls.Add(lt20);
            //prueba.Controls.Add(lt);
        }

        private void tableroJuego1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
