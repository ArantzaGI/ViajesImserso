using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
     class Ciudades: Tematicas
    {
        private string nombreGuiaCiudad;

        public void asignarGuiaCiudad(string nombreGuiaCiudad)
        {
            this.nombreGuiaCiudad = nombreGuiaCiudad;
        }
    }
    class CiudadesT :  Temporalidad
    {
        private string nombreGuiaCiudad;

        public void asignarGuiaCiudad(string nombreGuiaCiudad)
        {
            this.nombreGuiaCiudad = nombreGuiaCiudad;
        }
    }
}
