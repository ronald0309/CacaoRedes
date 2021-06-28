using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cacao.Clases
{
    [Serializable]
    class LosetaJungla : Loseta
    {
        public LosetaJungla(string nombre, bool isOculta) : base(nombre, isOculta){
            voltearLoseta();
        }
        public void voltearLoseta()
        {
            if (this.IsOculta)
            {
                inicializarImagenOculta();
            }
            else
            {
                inicializarImagenVisible();
            }
        }

        public void inicializarImagenOculta(){
            try{
                Load(Application.StartupPath + @"\Recursos\" + "Reverso7.png");
                Location = new System.Drawing.Point(0, 0);
                SizeMode = PictureBoxSizeMode.StretchImage;
                SizeMode = PictureBoxSizeMode.Zoom;
                Size = new System.Drawing.Size(79, 79);

            }
            catch (System.IO.FileNotFoundException e) {
                MessageBox.Show("Error al cargar alguna imagen.");
            }
        }
        public void inicializarImagenVisible(){
            try{
                string urlImagen = "";
                switch (this.Nombre){
                    case "plantacion simple":
                        urlImagen = "Plantacionsimple";
                        break;
                    case "plantacion doble":
                        urlImagen = "Plantaciondoble";
                        break;
                    case "mercado 2":
                        urlImagen = "mercado2";
                        break;
                    case "mercado 3":
                        urlImagen = "mercado3";
                        break;
                    case "mercado 4":
                        urlImagen = "mercado4";
                        break;
                    case "mina de oro 1":
                        urlImagen = "mina1";
                        break;
                    case "mina de oro 2":
                        urlImagen = "mina2";
                        break;
                    case "agua":
                        urlImagen = "agua";
                        break;
                    case "adoracion al sol":
                        urlImagen = "AdoracionalSol";
                        break;
                    case "templo":
                        urlImagen = "Templo";
                        break;
                    default:

                        break;}

                Load(Application.StartupPath + @"\Recursos\" + urlImagen + ".png");
                Location = new System.Drawing.Point(0, 0);
                SizeMode = PictureBoxSizeMode.StretchImage;
                SizeMode = PictureBoxSizeMode.Zoom;
                Size = new System.Drawing.Size(79, 79);
            }
            catch (System.IO.FileNotFoundException e){
                MessageBox.Show("Error al cargar alguna imagen.");
            }
        }

       


        }

    }

