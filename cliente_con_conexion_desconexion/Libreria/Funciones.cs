using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Libreria
{
    public class Funciones
    {
        
        
        public string ConQuienJuego(string Nombre, Socket server)
        {
            string mensaje = "1/" + Nombre;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            /*//Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];*/
            return mensaje;
        }

        public string QuienTieneMasPuntos(string Partida, Socket server)
        {
            string mensaje = "2/" + Partida;
            // Enviamos al servidor el ID de la partida tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            return mensaje;
        }

        public string PartidaMasCorta(Socket server)
        {
            string mensaje = "3/ ";
            // En este caso no es necesario introducir ningún dato extra
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            return mensaje;
        }

        public string LogIn(string Nombre, string Contrasenya, Socket server)
        {
            //Enviamos al servidor el nombre y la contraseña del usuario existente
            string mensaje = "4/" + Nombre + "/" + Contrasenya;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            return mensaje;
        }
        public string SignIn(string Nombre, string Contrasenya, Socket server)
        {
            //Enviamos al servidor el nombre y la contraseña del usuario nuevo
            string mensaje = "5/" + Nombre + "/" + Contrasenya;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            return mensaje;
        }

        public string ListaConectados(Socket server)
        {
            string mensaje = "6/ "; //Afegir espai si no funciona*
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            string[] trozos = mensaje.Split('/');
            int i = 0;
            mensaje = "Hay " + trozos[0] + " usuario(s) conectados";
            while (i < Convert.ToInt32(trozos[0]))
            {
                if (i==0)
                {
                    mensaje = mensaje + ": " + trozos[i + 1];
                }
                else
                    mensaje = mensaje + ", " + trozos[i + 1];

                i = i + 1;
                
            }
            return mensaje;
        }

        public string Servicios(Socket server)
        {
            //Pedir cuantos servicios
            string mensaje = "8/ "; //Afegir espai

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            return mensaje;
            
        }

        
    }
}
