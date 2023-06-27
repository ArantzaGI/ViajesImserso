using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    internal class Montes : Tematicas
    {
        private string nombreGuiaMontania;
        private int altitudMaxima;
        private string gradoDificultad;

        public void asignarGuiaMontaniaCiudad(string nombreGuiaMontania)
        {
            this.nombreGuiaMontania = nombreGuiaMontania;
        }


    }

    internal class MontesT : Temporalidad
    {
        private string nombreGuiaMontania;
        private int altitudMaxima;
        private string gradoDificultad;

        public void asignarGuiaMontaniaCiudad(string nombreGuiaMontania)
        {
            this.nombreGuiaMontania = nombreGuiaMontania;
        }

        public bool climaAdecuado()
        {
            if (ClimaApto) return true;
            else return false;
        }

    }
}
