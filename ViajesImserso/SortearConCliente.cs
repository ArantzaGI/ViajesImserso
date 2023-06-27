using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    internal class SortearConCliente
    {
        Random rndClientes;//objeto capaz de generar un número aleatorio
        //int[] _misNumeros;//Tabla de números
        //int tablaClientes.NClientes;//Cuantos números hay actualmente en la tabla
        //int _limite;//Cantidad max de números en la tabla

        public SortearConCliente()
        {
            rndClientes = new Random();

        }
        public void aniadirCliente(LosClientes tablaClientes, Cliente clt)
        {
            if (tablaClientes.NClientes < tablaClientes.TClientes.Length)
            {
                tablaClientes.TClientes[tablaClientes.NClientes] = clt;
                tablaClientes.NClientes++;
            }
        }
        public void eliminarNumero(LosClientes tablaClientes, Cliente clt)
        {
            if (tablaClientes.NClientes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < tablaClientes.NClientes; i++)
                {
                    if (clt.IdCliente == tablaClientes.TClientes[i].IdCliente)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el número");
                }
                else
                {
                    tablaClientes.TClientes[posicion] = new Cliente();

                    for (int i = posicion; i < tablaClientes.NClientes; i++)
                    {
                        tablaClientes.TClientes[i] = tablaClientes.TClientes[i + 1];

                    }

                    tablaClientes.NClientes--;

                }

            }
        }



        public void mostrarNumeros(LosClientes tablaClientes)
        {
            for (int i = 0; i < tablaClientes.NClientes; i++)
            {
                Console.WriteLine(tablaClientes.TClientes[i] + "\n");

            }
        }
        public void sortearCliente(LosClientes tablaClientes)
        {

            //return (tablaClientes[ClienteAleatorio(tablaClientes))]);
            
            System.Console.WriteLine(ClienteAleatorio(tablaClientes).ToString());
            /*int num = this.rndClientes.Next(tablaClientes.NClientes);
            System.Console.WriteLine(tablaClientes.TClientes[num].ToString());*/

        }
        public Cliente ClienteAleatorio(LosClientes tablaClientes)
        {
            int num = this.rndClientes.Next(tablaClientes.NClientes);
            return tablaClientes.TClientes[num];
        }
        public Cliente NumeroDeLaPosicionPos(LosClientes tablaClientes, int pos)
        {
            return tablaClientes.TClientes[pos];
        }
    }
}
