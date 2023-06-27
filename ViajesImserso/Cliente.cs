using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class Cliente : Clientes
    {
        private int idCliente;
        private string nombreCliente;
        private string apellidosCliente;
        private int edadCliente;
        private string dniCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        public Cliente(int idCliente, string nombreCliente, string apellidosCliente, int edadCliente, string dni)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.edadCliente = edadCliente;
            this.dniCliente = dni;
        }

        public Cliente()
        {
            this.idCliente = 0;
            this.nombreCliente = "";
            this.apellidosCliente = "";
            this.edadCliente = 0;
            this.dniCliente = "";
        }
        public override string ToString()
        {
            return " " + this.idCliente + " , " + this.nombreCliente + " , " + this.apellidosCliente + " ," + this.edadCliente +
                   " , " + this.dniCliente + " ";
        }
    }
}
