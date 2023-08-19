﻿using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            // fila para los resultados
            Stack<int> result = new Stack<int>();
            // fila temporal para rastrear los numeros
            Stack<int> tmp = new Stack<int>();

            foreach (int item in sourceStack)
            {
                // Mientras la pila temporal no esté vacía y el elemento en la cima sea menor o igual a item el cual es el numero actual
                while (tmp.Count > 0 && tmp.Peek() <= item)
                {
                    // Eliminamos un elemento en la cima temporal hasta encontrar uno mayor
                    tmp.Pop();
                }
                // Calcular el siguiente número mayor y agregarlo al resultado
                int nxt = tmp.Count > 0 ? tmp.Peek() : -1;
                result.Push(nxt);

                // Agregar el número actual a la pila temporal para su posterior comparación
                tmp.Push(item);
            }

            //Crear una pila para almacenar el resultado final
            Stack<int> result2 = new Stack<int>();
            foreach (int item in result)
            {
                result2.Push(item);
            }
            return result2;
        }
        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            // Crear un diccionario para almacenar los números y sus valores correspondientes
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            // Iterar a través de cada número en el arreglo de origen
            foreach (int item in sourceArr)
            {
                // switch expression devuelve un valor que se asigna
                EValueType value = item switch
                {
                    // cada var n se compara con el item si cumple la comparacion se asigna el resultado si no _ sera el caso predeterminado
                    var n when n % 2 == 0 => EValueType.Two,
                    var n when n % 3 == 0 => EValueType.Three,
                    var n when n % 5 == 0 => EValueType.Five,
                    var n when n % 7 == 0 => EValueType.Seven,
                    // Si el número no cumple con ninguno de los casos anteriores, asignar "Prime" como valor
                    _ => EValueType.Prime
                };
                // Agregar el número y su valor al diccionario de resultados
                result[item] = value;
            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}