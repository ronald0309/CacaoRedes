using System;
using System.Collections.Generic;
using System.Text;

namespace Cacao.Utils
{
    public static class Colores
    {
        
        public static string seleccionarColor(string color)
        {
            string meplesColor = "";
            switch (color)
            {
                case "Amarillo":
                    meplesColor = "Amarillo";
                    break;
                case "Azul":
                    meplesColor = "Azul";
                    break;
                case "Azul Oscuro":
                    meplesColor = "AzulOscuro";
                    break;
                case "Blanco":
                    meplesColor = "Blanco";
                    break;
                case "Cafe":
                    meplesColor = "Cafe";
                    break;
                case "Celeste":
                    meplesColor = "Celeste";
                    break;
                case "Cyan":
                    meplesColor = "Cyan";
                    break;
                case "Fusia":
                    meplesColor = "Fusia";
                    break;
                case "Gris":
                    meplesColor = "Gris";
                    break;
                case "Lima":
                    meplesColor = "Lima";
                    break;
                case "Morado":
                    meplesColor = "Morado";
                    break;
                case "Morado Oscuro":
                    meplesColor = "MoradoOscuro";
                    break;
                case "Naranja":
                    meplesColor = "Naranja";
                    break;
                case "Piel":
                    meplesColor = "Piel";
                    break;
                case "Rojo":
                    meplesColor = "Rojo";
                    break;
                case "Rosa":
                    meplesColor = "Rosa";
                    break;
                case "Verde":
                    meplesColor = "Verde";
                    break;
                case "Verde Claro":
                    meplesColor = "VerdeClaro";
                    break;
                case "Verde Oscuro":
                    meplesColor = "VerdeOscuro";
                    break;
                case "Vino":
                    meplesColor = "Vino";
                    break;
                default:

                    break;
            }
            return meplesColor;
        }
    }
}
