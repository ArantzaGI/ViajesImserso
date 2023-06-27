using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class LosClientes
    {
        private Cliente[] tClientes;
        private int nMaxClientes;
        private int nClientes;

        public Cliente[] TClientes { get => tClientes; set => tClientes = value; }
        public int NClientes { get => nClientes; set => nClientes = value; }

        public LosClientes(int nMaxClientes)
        {
            this.tClientes = new Cliente[nMaxClientes];
            this.nMaxClientes = nMaxClientes;
            this.nClientes = 0;

        }
        public void aniadirCliente(Cliente c)
        {
            if (c != null && nClientes < tClientes.Length)
            {
                tClientes[nClientes] = c;
                nClientes++;
            }
        }

        public void sumarUnoAcliente()
        {

            nClientes++;

        }

        public void mostrarClientes()
        {
            for (int i = 0; i < nClientes; i++)
            {
                //Console.WriteLine(tClientes[i].IdCliente+ToString());
                Console.WriteLine(tClientes[i].ToString());
            }
        }

        public void eliminarCliente(Cliente c)
        {
            if (c != null && nClientes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < nClientes; i++)
                {
                    if (c.IdCliente == tClientes[i].IdCliente)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el Clientee");
                }
                else
                {
                    tClientes[posicion] = null;

                    for (int i = posicion; i < nClientes; i++)
                    {
                        tClientes[i] = tClientes[i + 1];

                    }
                    tClientes[nClientes] = null;
                    nClientes--;

                }

            }
        }
        public Cliente buscarCliente(int idCliente)
        {
            if (nClientes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < nClientes; i++)
                {
                    if (idCliente == tClientes[i].IdCliente)
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
                    return (tClientes[posicion]);


                }

            }
            else
            {//No hay Clientes en el tClientes

                return null;

            }
        }
    }
}
