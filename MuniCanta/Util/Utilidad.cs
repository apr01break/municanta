using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MuniCanta.Util
{
    public class Utilidad
    {
        public static string ObtenerIpv4()
        {
            String localIp;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIp = endPoint.Address.ToString();
            }
            return localIp;
        }
        public static string SinTilde(string texto)
        {
            var reg = new Regex("[^a-zA-Z0-9]");
            //byte[] tempBytes;
            //tempBytes = System.Text.Encoding.GetEncoding("ISO - 8859 - 8").GetBytes(texto);
            return reg.Replace(texto.Normalize(NormalizationForm.FormD), "");
            //string asciiStr = System.Text.Encoding.UTF8.GetString(tempBytes);
            //return asciiStr;
        }
    }
}
