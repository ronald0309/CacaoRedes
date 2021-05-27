﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;               //   Paso 1
using System.Net.Sockets;       //   Paso 1
using System.Windows.Forms;

namespace Cacao.Sock
{
    class Servidor
    {
        public Servidor()
        {

        }
        public void Conect()
        {
            Conectar();
        }
        public static void Conectar() 
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  
            // paso 2 - creamos el socket
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Any, 1234);
            //paso 3 -IPAddress.Any significa que va a escuchar al cliente en toda la red
            try
            {
                // paso 4
                miPrimerSocket.Bind(miDireccion); // Asociamos el socket a miDireccion
                miPrimerSocket.Listen(1); // Lo ponemos a escucha
                Console.WriteLine("Escuchando...");
                MessageBox.Show("Escuchando");
                Socket Escuchar = miPrimerSocket.Accept();
                 //creamos el nuevo socket, para comenzar a trabajar con él
                 //La aplicación queda en reposo hasta que el socket se conecte a el cliente
                 //Una vez conectado, la aplicación sigue su camino 
                Console.WriteLine("Conectado con exito");
                /*Aca ponemos todo lo que queramos hacer con el socket, osea antes de
                
37
                cerrarlo je*/
                MessageBox.Show("Conectado Servidor");
                miPrimerSocket.Close(); //Luego lo cerramos
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();
        }
    }
}
