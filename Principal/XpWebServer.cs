using System;
using System.Net;
using System.Net.Sockets;

namespace XPlaneWeb
{
    public sealed class XPlaneServer
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static XPlaneServer _i;

        private UdpClient _udpClient;

        public static XPlaneServer i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new XPlaneServer();

                return _i;
            }
        }

        private UdpClient udpListener
        {
            get
            {
                if (_udpClient != null)
                {
                    return _udpClient;
                }

                _udpClient = new UdpClient(49001);

                return _udpClient;
            }
        }

        #endregion Atributos

        #region Construtores

        private XPlaneServer()
        {
        }

        #endregion Construtores

        #region Métodos

        internal void escutar()
        {
            while (true)
            {
                var remoteEP = new IPEndPoint(IPAddress.Any, 0);

                if (udpListener.Available < 1)
                {
                    continue;
                }

                var data = udpListener.Receive(ref remoteEP);

                Console.WriteLine("Receive data: ");

                for (int i = 9; i < data.Length; i += 4)
                {
                    float fltValor = BitConverter.ToSingle(data, i);

                    Console.Write(fltValor);
                    Console.Write(" ");
                }

                Console.WriteLine();

            }
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}