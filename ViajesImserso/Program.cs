using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ViajesImserso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 1; // opción del menú
            do
            {
                //System.Console.WriteLine("El método  buscarCliente de la clase ListaClientes ¿Hay otra forma de hacerlo?");
                //System.Console.WriteLine("Cada vez los idClientes son mayores, con truncate me da error, me dice que no se puede utlizar esa sentencia ¿ Como puedo hacerlo?");
                //System.Console.WriteLine("¿Qué quieres hacer? \n 1) Menu cargar clientes con array \n 2) Sortear en clientes con array \n 3) menu cargar clientes en lista \n 4) Mis pruebas para aprender listas \n 5) Sin hacer (será copia del de clientes) Menu cargar viajes \n 6) Sin hacer Menu apuntarse a un viaje \n 7) Sin hacer, ahora va a la op=1 Menu sorteo en clientes \n 0) Salir");
                System.Console.WriteLine("¿Qué quieres hacer? \n 1) Menu cargar clientes con array \n 2) Sortear en clientes con array \n 3) menu cargar clientes en lista \n 4) Mis pruebas para aprender listas \n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        menuCargarClientes();
                        break;
                    case 2:
                        sortearEnClientes();
                        break;
                    case 3:
                        menuCargarClientesLista();
                        break;
                    case 4:
                        menulistasGeneralidades();
                        break;
                    case 5:
                        //menuCargarViajes();
                        break;
                    case 6:
                        //apuntarse();
                        break;
                    case 7:
                        menuSorteoClientes();
                        break;
                    case 0:
                        System.Console.WriteLine("Finalizó el menú principal\n");
                        break;
                    default:
                        System.Console.WriteLine("Opción no valida;\n");
                        break;
                }
            } while (opc != 0);
            System.Console.ReadKey();
        }

        static void menuCargarClientes()
        {
            int opc = 1; // opción del menú
            LosClientes tablaLosClientes = new LosClientes(45);
            int idCliente;
            
            Clientes clientesBD = new Clientes();
            clientesBD.leerBDclientes(tablaLosClientes);

            do
            {                
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir cliente \n 2)Mostrar clientes \n 3) Eliminar cliente\n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        AniadirClienteTabla(tablaLosClientes);
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los clientes\n");
                        tablaLosClientes.mostrarClientes();
                        break;
                    case 3:
                        System.Console.WriteLine("¿Qué cliente queremos eliminar?( Inserta su id)\n");
                        idCliente = int.Parse(System.Console.ReadLine());

                        tablaLosClientes.eliminarCliente(tablaLosClientes.buscarCliente(idCliente));
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 0:
                        System.Console.WriteLine("Finaliza el menu cliente\n");
                        break;
                    default:
                        System.Console.WriteLine("Opción no valida;\n");
                        break;
                }
            } while (opc != 0);
            clientesBD.volcarBDclientes(tablaLosClientes);
            //clientesBD.volcarBDclientes(tablaLosClientes);
            System.Console.ReadKey();
        }
        static void menuCargarClientesLista()
        {
            int opc = 1; // opción del menú
            ListaClientes listaDeClientes = new ListaClientes();
            int idCliente;

            Clientes clientesBD = new Clientes();
            clientesBD.leerBDclientesLista(listaDeClientes);

            do
            {
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir cliente \n 2)Mostrar clientes \n 3) Eliminar cliente\n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        AniadirClienteLista(listaDeClientes);
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los clientes\n");
                        listaDeClientes.mostrarClientes();
                        break;
                    case 3:
                        System.Console.WriteLine("¿Qué cliente queremos eliminar?( Inserta su id)\n");
                        idCliente = int.Parse(System.Console.ReadLine());

                        listaDeClientes.eliminarCliente(listaDeClientes.buscarCliente(idCliente));
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 0:
                        System.Console.WriteLine("Finaliza el menu cliente\n");
                        break;
                    default:
                        System.Console.WriteLine("Opción no valida;\n");
                        break;
                }
            } while (opc != 0);
            clientesBD.volcarBDclientesLista(listaDeClientes);
            //clientesBD.volcarBDclientes(tablaLosClientes);
            System.Console.ReadKey();
        }

        static void AniadirClienteTabla(LosClientes tablaLosClientes)
        {
            System.Console.WriteLine("vamos a añadir un cliente:\n");
            System.Console.WriteLine("Inserta el id del cliente:");
            int idCliente = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Inserta el nombre del cliente:");
            string nombreCliente = System.Console.ReadLine();
            System.Console.WriteLine("Inserta el apellido del cliente:");
            string apellidosCliente = System.Console.ReadLine();
            System.Console.WriteLine("Inserta la edad del cliente:");
            int edadCliente = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Inserta el DNI del cliente");
            string dni = System.Console.ReadLine();
            
            Cliente nuevoCliente = new Cliente(idCliente, nombreCliente, apellidosCliente, edadCliente, dni);
            tablaLosClientes.aniadirCliente(nuevoCliente);
            System.Console.WriteLine("Añadido! ;)\n");
        }

        static void AniadirClienteLista(ListaClientes listaDeClientes)
        {
            System.Console.WriteLine("vamos a añadir un cliente:\n");
            System.Console.WriteLine("Inserta el id del cliente:");
            int idCliente = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Inserta el nombre del cliente:");
            string nombreCliente = System.Console.ReadLine();
            System.Console.WriteLine("Inserta el apellido del cliente:");
            string apellidosCliente = System.Console.ReadLine();
            System.Console.WriteLine("Inserta la edad del cliente:");
            int edadCliente = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Inserta el DNI del cliente");
            string dni = System.Console.ReadLine();

            Cliente nuevoCliente = new Cliente(idCliente, nombreCliente, apellidosCliente, edadCliente, dni);
            listaDeClientes.aniadirCliente(nuevoCliente);
            System.Console.WriteLine("Añadido! ;)\n");
        }
        static void menuSorteoClientes()
        {
            int opc = 1; // opción del menú
            LosClientes tablaLosClientes = new LosClientes(45);
            int idCliente;

            Clientes clientesBD = new Clientes();
            clientesBD.leerBDclientes(tablaLosClientes);

            do
            {
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir cliente \n 2)Mostrar clientes \n 3) Eliminar cliente\n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        AniadirClienteTabla(tablaLosClientes);
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los clientes\n");
                        tablaLosClientes.mostrarClientes();
                        break;
                    case 3:
                        System.Console.WriteLine("¿Qué cliente queremos eliminar?( Inserta su id)\n");
                        idCliente = int.Parse(System.Console.ReadLine());

                        tablaLosClientes.eliminarCliente(tablaLosClientes.buscarCliente(idCliente));
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 0:
                        System.Console.WriteLine("Finaliza el menu cliente\n");
                        break;
                    default:
                        System.Console.WriteLine("Opción no valida;\n");
                        break;
                }
            } while (opc != 0);
            System.Console.ReadKey();
        }
        static void sortearEnClientes()
        {
            LosClientes tablaLosClientes = new LosClientes(45);
            //int idCliente;

            Clientes clientesBD = new Clientes();
            clientesBD.leerBDclientes(tablaLosClientes);

            SortearConCliente rdnCliente = new SortearConCliente();
            System.Console.WriteLine("¿quién será el afortunado? ¡¡¡SUERTE!!! ;)\n");
            rdnCliente.sortearCliente(tablaLosClientes);
        }

        static void menulistasGeneralidades()
        {/*
                        
            Clientes clientesBD = new Clientes();
            clientesBD.leerBDclientes(tablaLosClientes);*/
            int opc = 1; // opción del menú
            ListasGeneralidades LaListaGeneral = new ListasGeneralidades();
            int idCliente;
            LaListaGeneral.WorkWithString();
            Clientes clientesBD = new Clientes();
            //clientesBD.leerBDclientes(LaListaGeneral);

            do
            {
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir cliente \n 2)Mostrar clientes \n 3) Eliminar cliente\n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        //AniadirClienteTabla(tablaLosClientes);
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los clientes\n");
                        //tablaLosClientes.mostrarClientes();
                        break;
                    case 3:
                        System.Console.WriteLine("¿Qué cliente queremos eliminar?( Inserta su id)\n");
                        idCliente = int.Parse(System.Console.ReadLine());

                        //tablaLosClientes.eliminarCliente(tablaLosClientes.buscarCliente(idCliente));
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 0:
                        System.Console.WriteLine("Finaliza el menu cliente\n");
                        break;
                    default:
                        System.Console.WriteLine("Opción no valida;\n");
                        break;
                }
            } while (opc != 0);
            //clientesBD.volcarBDclientes(tablaLosClientes);
            System.Console.ReadKey();
        }

    }
}
