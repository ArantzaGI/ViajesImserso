using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class LosViajes
    {
        private Viaje[] tViajes;
        private int nMaxViajes;
        private int viajesActualmente;

        public LosViajes(int nMaxViajes)
        {
            this.tViajes = new Viaje[nMaxViajes];
            this.nMaxViajes = nMaxViajes;
            this.viajesActualmente = 0;

        }


        public void aniadirViaje(Viaje v)
        {
            if (v != null && viajesActualmente < tViajes.Length)
            {
                tViajes[viajesActualmente] = v;
                viajesActualmente++;
            }
        }


        public void eliminarViaje(Viaje v)
        {
            if (v != null && viajesActualmente != 0)
            {

                int posicion = -1;
                for (int i = 0; i < viajesActualmente; i++)
                {
                    if (v.IdViaje == tViajes[i].IdViaje)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el Viaje");
                }
                else
                {
                    tViajes[posicion] = null;

                    for (int i = posicion; i < viajesActualmente; i++)
                    {
                        tViajes[i] = tViajes[i + 1];

                    }
                    tViajes[viajesActualmente] = null;
                    viajesActualmente--;

                }

            }
        }
        public Viaje buscarViaje(int idViaje)
        {
            if (viajesActualmente != 0)
            {

                int posicion = -1;
                for (int i = 0; i < viajesActualmente; i++)
                {
                    if (idViaje == tViajes[i].IdViaje)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el Viaje");
                    return null;
                }
                else
                {
                    return (tViajes[posicion]);


                }

            }
            else
            {//No hay Viajes en el losViajes

                return null;

            }
        }


    }
}
