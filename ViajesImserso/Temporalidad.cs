using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    internal abstract class Temporalidad: Viajes
    {
        private int idTemporada;
        private string nombreTemporada;
        private bool climaApto;

        public bool ClimaApto { get => climaApto; }
    }

}
