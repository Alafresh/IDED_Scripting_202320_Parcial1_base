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
            Dictionary<int, EValueType> result = null;

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