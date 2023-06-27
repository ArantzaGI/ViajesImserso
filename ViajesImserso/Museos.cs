using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    internal class Museos : Tematicas
    {
        private string ticketEntrada;
        private string nombreMuseo;

        public void darTicketEntrada(string ticketEntrada, string nombreMuseo)
        {
            this.ticketEntrada = ticketEntrada;
            this.nombreMuseo = nombreMuseo;
        }
    }

    class MuseosT : Temporalidad
    {
        private string ticketEntrada;
        private string nombreMuseo;

        public void darTicketEntrada(string ticketEntrada, string nombreMuseo)
        {
            this.ticketEntrada = ticketEntrada;
            this.nombreMuseo = nombreMuseo;
        }
    }
}
