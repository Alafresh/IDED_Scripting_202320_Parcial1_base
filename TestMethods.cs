using System;
using System.Collections.Generic;

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
            // Inicializar un contador para contar los elementos que coinciden con el valor deseado
            int contador = 0;
            
            // Iterar a través de cada par clave-valor en el diccionario
            foreach (var value in sourceDict.Values)
            {
                // Comprueba si el valor actual coincide con el valor deseado
                if (value == type)
                {
                    contador++;
                }
            }
            // Devuelve el contador que representa la cantidad de elementos que coinciden con el valor deseado
            return contador;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            // Crear un array para almacenar las claves ordenadas
            int[] sortedKeys = new int[sourceDict.Count];
            
            // Copiar las claves del diccionario en el array de claves ordenadas
            sourceDict.Keys.CopyTo(sortedKeys, 0);

            // Ordenar las claves en orden descendente utilizando Array.Sort (a,b) => b.CompareTo(a) es una expresion lambda que define el orden de las llaves
            Array.Sort(sortedKeys, (a, b) => b.CompareTo(a));
           
            // Crear un nuevo diccionario para almacenar el resultado ordenado
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
            
            // Iterar a través de las claves ordenadas
            foreach (int key in sortedKeys)
            {
                // Asignar al nuevo diccionario el valor del diccionario fuente utilizando la clave actual
                result[key] = sourceDict[key];
            }

            // Devolver el diccionario ordenado resultante
            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            // Crear un arreglo de colas para cada tipo de solicitud
            Queue<Ticket>[] result = new Queue<Ticket>[3];

            // Inicializamos cada cola en el arreglo
            for (int i = 0; i < 3; i++)
            {
                result[i] = new Queue<Ticket>();
            }

            // Ordenar la lista de tickets por el valor de Turn en orden ascendente
            sourceList.Sort((a, b) => a.Turn.CompareTo(b.Turn));

            // Iterar sobre cada ticket en la lista ordenada
            foreach (var ticket in sourceList)
            {
                // Obtener el índice de la cola apropiada según el tipo de solicitud
                int idx = GetQueueIndex(ticket.RequestType);
                // Encolar el ticket en la cola correspondiente
                result[idx].Enqueue(ticket);
            }

            return result;
        }

        internal static int GetQueueIndex(Ticket.ERequestType requestType)
        {
            // Utilizamos un switch expression para asignar un índice a cada tipo de solicitud
            return requestType switch
            {
                Ticket.ERequestType.Payment => 0,
                Ticket.ERequestType.Subscription => 1,
                Ticket.ERequestType.Cancellation => 2,
                _ => throw new ArgumentException("Unknown request type")
            };
        }
        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }
    }
}