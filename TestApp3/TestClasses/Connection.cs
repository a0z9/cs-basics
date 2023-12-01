using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace krasn23.a0z9.learning
{
   
    internal class Connection:Object
    {
        public const string IP_DEFAULT = "127.0.0.1";
        public const ushort TCP_PORT_DEFAULT = 1433;

        //private string ipAddress = IP_DEFAULT;
        private readonly string ipAddress;
        //private IPAddress ip;


        private readonly ushort tcpPort; // = TCP_PORT_DEFAULT;

        public ushort TcpPort { get => tcpPort; }
        //{ get;// => tcpPort; 
        //    private set;// => tcpPort=value; 
       // }

        public Connection():this(IP_DEFAULT,TCP_PORT_DEFAULT) { }
        public Connection(string ip) : this(ip, TCP_PORT_DEFAULT) { }
        public Connection(ushort tcpPort) : this(IP_DEFAULT,tcpPort) { }

        public Connection(string ipAddress, ushort tcpPort)
        {
            if (IsIpValid(ipAddress)) this.ipAddress = ipAddress;
            else this.ipAddress = IP_DEFAULT; 
           
            this.tcpPort = tcpPort;
            WriteLine("+++ ctor, " + this);
        }

        public string IpAddress { get => ipAddress; }

    //    {  
     //       get { return ipAddress; } 
     //       private set { 
     //           if(IsIpValid(value))
     //           ipAddress = value; }
     

        private static bool IsIpValid(string ip) {
            if (ip is null) return false;
            if ( ip.StartsWith("10.")  || ip.StartsWith("192.168."))
                // Проверить с regExp весь адрес!!! (а не только начало)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return $"Connection, ipAddress:port=>{IpAddress,16}:{TcpPort,5}, object:{GetHashCode()}";
        }
    }
}
