using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ViajesImserso
{
    public class ListasGeneralidades
    {
        private List<Cliente> listaClientes;
        private List<string> nombres; // = new List<string> { "Arantza", "Ana", "Felipe" };
        private List<int> fibonacciNumbers;
        private List<string> firstList;
        private int nClientes;

        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public int NClientes { get => nClientes; set => nClientes = value; }

        public ListasGeneralidades() 
        {
            this.nClientes = 0;
            this.listaClientes = new List<Cliente>();
            this.nombres = new List<string>();
        }

        public void WorkWithString()
        {
            nombres = new List<string> { "Arantza", "Ana", "Felipe" };
            foreach (var name in nombres)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            nombres.Add("Maria");
            nombres.Add("Bill");
            nombres.Remove("Ana");
            foreach (var name in nombres)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {nombres[0]}");
            Console.WriteLine($"I've added {nombres[2]} and {nombres[3]} to the list");

            Console.WriteLine($"The list has {nombres.Count} people in it");

            var index = nombres.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {nombres[index]} is at index {index}");
            }

            index = nombres.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {nombres[index]} is at index {index}");

            }

            nombres.Sort();
            foreach (var name in nombres)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);




            List<string> firstList = new List<string>()
            {
                "Opel",
                "BMW"
            };


            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            List<string> marcas = new List<string>();
            //Añadir un elemento
            marcas.Add("Audi");
            //Añadir una lista a otra lista
            marcas.AddRange(firstList);
            //indicar qué elemento y donde lo vamos a añadir
            marcas.Insert(1, "Skoda");

            //Acceder a los elementos de la lista
            Console.WriteLine(marcas[0]); //Audi

            foreach (string item in marcas)
                Console.WriteLine(item);

            //convertir una lista a inmutable (constante)
            //no hay “ninguna” preferencia
            //ReadOnly fueron introducidas en .net framework 4.5 e IList<T> ya existía anteriormente.
            //No son intercambiables, ya que no se implementan entre ellas.
            IReadOnlyList<string> readonlyMarcas = marcas;
            IList<string> IlistMarcas = marcas;

            // eliminar por index
            marcas.RemoveAt(0); //Elimina Audi
            //eliminar indicando el elemento a eliminar
            marcas.Remove("Skoda");//Elimina skoda

            //Más opciones con las listas
            //utilizar la propiedad .Count o
            //métodos, como.Clear() para limpiar la lista,
            //.Find() para encontrar elementos utilizando un predicado
            //o.Sort() para ordenar.
            // SortedList< un elemento key, el elemento dato información>
            SortedList<int, string> listaCochesOrdenada = new SortedList<int, string>()
            {
                {3,"bmw" },
                {1, "audi" },
                {2, "opel" }
            };

            foreach (var item in listaCochesOrdenada)
                Console.WriteLine(item.Value); //imprime: audi, opel, bmw
        }
    }
}
