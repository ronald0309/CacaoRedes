using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net;            //   Paso 1
using System.Net.Sockets;    //   Paso 1
using System.Windows.Forms;
using System.Threading;
using Cacao.Utils;
using Cacao.Clases;
namespace Cacao.Sock
{
    [Serializable]
    class Cliente
    {

        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        static Socket s_Client;
        public Cliente(string ip, int port){
            try
            {
                host = Dns.GetHostEntry(ip);
                ipAddr = host.AddressList[0];
                endPoint = new IPEndPoint(ipAddr, port);

                s_Client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            }
            catch (NullReferenceException ane)
            {
                Console.WriteLine("+++++++++++++" + ane.ToString());
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (Exception e)
            {
                //Console.WriteLine("--------------" + e.ToString());
                MessageBox.Show("Error al conectar, intente nuevamente.");
                //return "Conexión rechazada, intente nuevamente.";
            }
        }

        public string Start()
        {
            string aviso = "Conexión rechazada.";
            try
            {
                if (s_Client != null)
                {

                    s_Client.Connect(endPoint);
                    aviso = "Conexión establecida.";
                    MessageBox.Show("Conexión establecida correctamente."+Singlenton.Instance.CANTJUGADORES);

                    return aviso;
                }
                return aviso;

            }
            catch (SocketException se)
            {
                MessageBox.Show("Conexión rechazada por el socket del servidor, verifiquelo y vuelva a intentar.");
                return "Conexión rechazada,SocketException, intente nuevamente.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Conexión rechazada, intente nuevamente");
                return "Conexión rechazada, intente nuevamente.";
            }
        }

        public void Send(string msj){
            try{
                if (s_Client.Connected){
                    Console.WriteLine("CONECTADO");
                } else {
                    Console.WriteLine("NO CONECTADO");
                }
                s_Client.Send(stringTobyte(msj));
                Console.WriteLine("Mensaje Enviado");
                //s_Client.Close();
            }
            catch (SocketException se){
                Console.WriteLine("ERROR {0}", se.Message);
            }
        }

        public byte[] stringTobyte(string msj){
            msj += "<EOF>";
            byte[] byteMsj = Encoding.ASCII.GetBytes(msj);
            return byteMsj;
        }

        public string serverReceive()
        {
            string recibido= "";
            byte[] buffer = new byte[1024];
            int bytesRec = s_Client.Receive(buffer);
            recibido += Encoding.ASCII.GetString(buffer, 0, bytesRec);
            if (recibido.IndexOf("<EOF>") > -1)
            {
                recibido = recibido.Remove(recibido.Length - 5);
            }
            return recibido;
        }

        public void sendObject(object toSend)
        {
            s_Client.Send(BinSerial.Serializar(toSend));

        }

        public Loseta recibirLoseta()
        {
            Loseta l;
            byte[] buffer = new byte[1024];
            s_Client.Receive(buffer);
            l = (Loseta)BinSerial.Deserializar(buffer);
            MessageBox.Show(l.Nombre + "||" + l.IsOculta);
            return l;

        }

        
    }
}