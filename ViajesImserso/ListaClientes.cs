using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class ListaClientes
    {
        private List<Cliente> listaDeClientes;
        // no lo ponemos porque utilizaremos .count private int nClientes;

        public List<Cliente> ListaDeClientes { get => listaDeClientes; set => listaDeClientes = value; }

        public ListaClientes()
        {
            this.listaDeClientes = new List<Cliente>();
        }

        public void aniadirCliente(Cliente c)
        {
            if (c != null )
            {
                listaDeClientes.Add(c);
                // nClientes++; no lo ponemos porque utilizaremos .count
            }
        }

        public void mostrarClientes()
        {
            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                //Console.WriteLine(tClientes[i].IdCliente+ToString());
                Console.WriteLine(listaDeClientes[i].ToString());
            }
        }

        public void eliminarCliente(Cliente c)
        {
            if (c != null && listaDeClientes.Count != 0)
            {
                listaDeClientes.Remove(c);
            }
        }

        //var index = nombres.IndexOf("Felipe");
        public Cliente buscarCliente(int idCliente)
        {
            if (listaDeClientes.Count != 0)
            {

                int posicion = -1;
                //var index = listaDeClientes.IndexOf(listaDeClientes.IdCliente);
                for (int i = 0; i < listaDeClientes.Count; i++)
                {
                    if (idCliente == listaDeClientes[i].IdCliente)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el Cliente");
                    return null;
                }
                else
                {
                    return (listaDeClientes[posicion]);
                }
            }
            else
            {//No hay Clientes en el tClientes
                return null;
            }
        }
    }
}
