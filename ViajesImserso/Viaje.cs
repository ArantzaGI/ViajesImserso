using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class Viaje : Viajes
    {
        private int idViaje;
        private string nombreViaje;
        private Cliente[] personasViaje;
        private int nTotalPersonas;
        private int nPersonasApuntadas;
        private DateTime fechaSalida;
        private DateTime fechaLlegada;
        private string nombreHotel;
        private string nombreCiudad;
        private bool viajeCompleto;

        public int IdViaje { get => idViaje; set => idViaje = value; }
        public string NombreViaje { get => nombreViaje; set => nombreViaje = value; }
        internal Cliente[] PersonasViaje { get => personasViaje; set => personasViaje = value; }
        public int NTotalPersonas { get => nTotalPersonas; set => nTotalPersonas = value; }
        public int NPersonasApuntadas { get => nPersonasApuntadas; set => nPersonasApuntadas = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public string NombreHotel { get => nombreHotel; set => nombreHotel = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }
        public bool ViajeCompleto { get => viajeCompleto; set => viajeCompleto = value; }

        public Viaje(int idViaje, string nombreViaje, int nTotalPersonas, DateTime fechaSalida, DateTime fechaLlegada, string nombreHotel, string nombreCiudad, bool viajeCompleto)
        {
            this.idViaje = idViaje;
            this.nombreViaje = nombreViaje;
            this.personasViaje = new Cliente[nTotalPersonas];
            this.nTotalPersonas = nTotalPersonas;
            this.nPersonasApuntadas = 0;
            this.fechaSalida = fechaSalida;
            this.fechaLlegada = fechaLlegada;
            this.nombreHotel = nombreHotel;
            this.nombreCiudad = nombreCiudad;
            this.viajeCompleto = viajeCompleto;
        }

        public void aniadirClienteViaje(Cliente c)
        {
            if (c != null && nPersonasApuntadas < personasViaje.Length)
            {
                personasViaje[nPersonasApuntadas] = c;
                nPersonasApuntadas++;
            }
        }


        public void eliminarClienteViaje(Cliente c)
        {
            if (c != null && nPersonasApuntadas != 0)
            {

                int posicion = -1;
                for (int i = 0; i < nPersonasApuntadas; i++)
                {
                    if (c.IdCliente == personasViaje[i].IdCliente)
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
                    personasViaje[posicion] = null;

                    for (int i = posicion; i < nPersonasApuntadas; i++)
                    {
                        personasViaje[i] = personasViaje[i + 1];

                    }
                    personasViaje[nPersonasApuntadas] = null;
                    nPersonasApuntadas--;

                }

            }
        }
        public Cliente buscarClienteViaje(int idCliente)
        {
            if (nPersonasApuntadas != 0)
            {

                int posicion = -1;
                for (int i = 0; i < nPersonasApuntadas; i++)
                {
                    if (idCliente == personasViaje[i].IdCliente)
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
                    return (personasViaje[posicion]);


                }

            }
            else
            {//No hay Clientes en el PersonasViaje

                return null;

            }
        }

        public bool viajeCompletado()
        {
            if (nPersonasApuntadas < nTotalPersonas)
                 return false;
            else return true;
        }

        public int darPlazasLibres()
        {
            return nTotalPersonas - nPersonasApuntadas ;
        }

        public void apuntarseViaje(Cliente cliente)
        {
            if (cliente != null && nPersonasApuntadas < personasViaje.Length)
            {
                personasViaje[nPersonasApuntadas] = cliente;
                nPersonasApuntadas++;
            }
        }
    }
}
