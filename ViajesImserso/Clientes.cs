using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ViajesImserso
{
    public class Clientes
    {
        public void leerBDclientes(LosClientes tablaClientes)
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\ViajesImserso.mdb";
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";
            string consulta = "SELECT * FROM Clientes";
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
                    using (OleDbDataReader miTabla = comando.ExecuteReader())
                    {
                        //Console.WriteLine("------------Tabla Clientes----------------");
                        while (miTabla.Read())
                        {
                            //Console.WriteLine("{0} {1} {2} {3} {4}", miTabla["IdCliente"], miTabla["nombreCliente"].ToString(), miTabla["apellidosCliente"].ToString(), miTabla["edadCliente"], miTabla["dniCliente"].ToString());
                            Cliente elCliente = new Cliente(miTabla.GetInt32(0), miTabla.GetString(1), miTabla.GetString(2), miTabla.GetInt32(3),miTabla.GetString(4));
                            
                            tablaClientes.aniadirCliente(elCliente);
                            
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas al leer txato!!" + ex.Message);
                }

            }
        }

        public void leerBDclientesLista(ListaClientes listaDeClientes)
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\ViajesImserso.mdb";
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";
            string consulta = "SELECT * FROM Clientes";
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    
                    using (OleDbDataReader miTabla = comando.ExecuteReader())
                    {
                        //Console.WriteLine("------------Tabla Clientes----------------");
                        while (miTabla.Read())
                        {
                            //Console.WriteLine("{0} {1} {2} {3} {4}", miTabla["IdCliente"], miTabla["nombreCliente"].ToString(), miTabla["apellidosCliente"].ToString(), miTabla["edadCliente"], miTabla["dniCliente"].ToString());
                            Cliente elCliente = new Cliente(miTabla.GetInt32(0), miTabla.GetString(1), miTabla.GetString(2), miTabla.GetInt32(3), miTabla.GetString(4));

                            listaDeClientes.aniadirCliente(elCliente);

                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas al leer txato!!" + ex.Message);
                }

            }
        }

        static public void actualizarEnBD()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\clientes.mdb";
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";
            int opc;
            int id;
            String nombre = "";
            int edad = 0;
            String consultaBase = "UPDATE Clientes SET  ";
            String consultaNom = "";
            String consultaAp = "";
            String consultaEdad = "";
            String consultaBorrar = "";
            System.Console.WriteLine("¿Qué id quieres actualizar?");
            id = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("¿Qué quieres actualizar?\n 1)Nombre\n 2)Apellido \n 3)Edad\n 4)Borrar \n 0)Salir");
            opc = int.Parse(System.Console.ReadLine());
            do
            {
                switch (opc)
                {
                    case 1:
                        //Leemos lo que vamos a modificarar
                        System.Console.WriteLine("Nombre final, por favor:");
                        nombre = System.Console.ReadLine();
                        consultaNom = consultaBase + " nombre = '" + nombre + "' WHERE Id = " + id;
                        break;
                    case 2:
                        System.Console.WriteLine("Apellido final, por favor:");
                        String apellido = System.Console.ReadLine();
                        consultaAp = consultaBase + " apellidos = '" + apellido + "' WHERE Id = " + id;
                        break;
                    case 3:
                        System.Console.WriteLine("Edad final, por favor:");
                        edad = int.Parse(System.Console.ReadLine());
                        consultaEdad = consultaBase + " edad = " + edad + " WHERE Id = " + id;
                        break;
                    case 4:
                        //System.Console.WriteLine("Seguro que quieres borrar confirma con una s :");
                        //edad = int.Parse(System.Console.ReadLine());
                        consultaBorrar = "DELETE FROM Clientes WHERE Id = " + id;
                        break;
                    default:
                        Console.WriteLine("Una opción de la lista!!");
                        break;
                }
                System.Console.WriteLine("¿Qué quieres actualizar?\n 1)Nombre\n 2)Apellido \n 3)Edad\n 4)Borrar \n 0)Salir");
                opc = int.Parse(System.Console.ReadLine());

            } while (opc != 0);

            //Ver consulta que hacemos luego quitar
            System.Console.WriteLine(consultaNom);
            System.Console.WriteLine(consultaAp);
            System.Console.WriteLine(consultaEdad);
            System.Console.WriteLine(consultaBorrar);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comandoNom = new OleDbCommand(consultaNom, conexion);
                OleDbCommand comandoAp = new OleDbCommand(consultaAp, conexion);
                OleDbCommand comandoEdad = new OleDbCommand(consultaEdad, conexion);
                OleDbCommand comandoBorrar = new OleDbCommand(consultaBorrar, conexion);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command
                    if (consultaNom != "")
                    {
                        OleDbDataReader miTabla = comandoNom.ExecuteReader();
                    }
                    if (consultaAp != "")
                    {
                        OleDbDataReader miTabla = comandoAp.ExecuteReader();
                    }
                    if (consultaEdad != "")
                    {
                        OleDbDataReader miTabla = comandoEdad.ExecuteReader();
                    }
                    if (consultaBorrar != "")
                    {
                        OleDbDataReader miTabla = comandoBorrar.ExecuteReader();
                    }
                    Console.WriteLine("Actualizado correctamente");
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas al actualizar txato!!" + ex.Message);
                }

            }
            System.Console.ReadKey();

        }

        public void eliminarBDClientes()
        {
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\clientes.mdb";
            string borrarBDclientes = "DELETE FROM Clientes";
             
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {  
                OleDbCommand comandoBorrarBD = new OleDbCommand(borrarBDclientes, conexion);
                // Open the connection and execute the select command.    
                try
                {// Open connecton    
                    conexion.Open();
                    // Execute command
                    OleDbDataReader miTabla = comandoBorrarBD.ExecuteReader();

                    Console.WriteLine("Borrado correctamente");
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas txato!!" + ex.Message);
                }
            }
        }

        public void volcarBDclientes(LosClientes tablaClientes)
        { //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\ViajesImserso.mdb";
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";

            String nombre; 
            String apellidos; 
            int edad; 
            String dni;
            string insertarBDCliente;
            string borrarBDclientes = "DELETE FROM Clientes";
            //string borrarBDclientes = "TRUNCATE TABLE Clientes";
            //System.Console.WriteLine(consulta);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {   // Create a command and set its connection       
                try
                {   // Open connecton
                    OleDbCommand comandoBorrarBD = new OleDbCommand(borrarBDclientes, conexion);
                    conexion.Open();
                    OleDbDataReader miTablaBorrar = comandoBorrarBD.ExecuteReader();
                    // Execute command  
                    Console.WriteLine("------------Tabla Clientes----------------");
                    for (int i = 0; i < tablaClientes.NClientes; i++)
                    { //Leemos lo que vamos a insertar
                        nombre = tablaClientes.TClientes[i].NombreCliente;
                        apellidos = tablaClientes.TClientes[i].ApellidosCliente;
                        edad = tablaClientes.TClientes[i].EdadCliente;
                        dni = tablaClientes.TClientes[i].DniCliente; ;
                            
                        //Preparamos la query(consulta)
                        insertarBDCliente = "INSERT INTO Clientes(nombreCliente, apellidosCliente, edadCliente, dniCliente) VALUES ('" + nombre + "','" + apellidos + "'," + edad + ",'" + dni + "')";
                        //System.Console.WriteLine(insertarCliente);
                        OleDbCommand comando = new OleDbCommand(insertarBDCliente, conexion);
                        OleDbDataReader miTablaInsertar = comando.ExecuteReader();
                    }
                    Console.WriteLine("Insertados correctamente");
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas al insertar txato!!" + ex.Message);
                }
            }
            //System.Console.ReadKey();   
        }

        public void volcarBDclientesLista(ListaClientes listaDeClientes)
        { //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\ViajesImserso.mdb";
            //string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jrrrf\source\repos\ViajesImserso.mdb";
            
            String nombre;
            String apellidos;
            int edad;
            String dni;
            string insertarBDCliente;
            string borrarBDclientes = "DELETE FROM Clientes";
            //string borrarBDclientes = "TRUNCATE TABLE Clientes";
            //System.Console.WriteLine(consulta);
            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {   // Create a command and set its connection       
                try
                {   // Open connecton
                    OleDbCommand comandoBorrarBD = new OleDbCommand(borrarBDclientes, conexion);
                    conexion.Open();
                    OleDbDataReader miTablaBorrar = comandoBorrarBD.ExecuteReader();
                    // Execute command  
                    Console.WriteLine("------------Tabla Clientes----------------");
                    for (int i = 0; i < listaDeClientes.ListaDeClientes.Count; i++)
                    { //Leemos lo que vamos a insertar
                        nombre = listaDeClientes.ListaDeClientes[i].NombreCliente;
                        apellidos = listaDeClientes.ListaDeClientes[i].ApellidosCliente;
                        edad = listaDeClientes.ListaDeClientes[i].EdadCliente;
                        dni = listaDeClientes.ListaDeClientes[i].DniCliente; ;
                       
                        //Preparamos la query(consulta)
                        insertarBDCliente = "INSERT INTO Clientes(nombreCliente, apellidosCliente, edadCliente, dniCliente) VALUES ('" + nombre + "','" + apellidos + "'," + edad + ",'" + dni + "')";
                        //System.Console.WriteLine(insertarCliente);
                        OleDbCommand comando = new OleDbCommand(insertarBDCliente, conexion);
                        OleDbDataReader miTablaInsertar = comando.ExecuteReader();
                    }
                    Console.WriteLine("Insertados correctamente");
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas al insertar txato!!" + ex.Message);
                }
            }
            //System.Console.ReadKey();   
        }
    }
}
