using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
         int[] numbers = { 1, 2, 3, 4, 5 };
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
          
            sourceStack = new Stack<int>();
            Stack<int> result = new Stack<int>();
            Stack<int> tmp = new Stack<int>();
            int[] numeros = { 26, 3, 6, 5 };
            foreach (int numero in numeros)
            {
                sourceStack.Push(numero);
            }
            foreach (int num in sourceStack)
            {
                Console.WriteLine(num);
            }

            for (int i = 0; i < sourceStack.Count; i++)
            {
                if (sourceStack.ElementAt(i) > sourceStack.Peek())
                {
                    tmp.Push(sourceStack.ElementAt(i));
                }
                else
                {
                    tmp.Push(-1);
                }

                //reversarla 
                while (tmp.Count != 0)
                {
                    result.Push(tmp.Pop());
                }

            }
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
           Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
           

            //Definir valores
            CalculateValues(this.numbers,result);

            return result;
        }
        internal static Dictionary<int, EValueType> CalculateValues(int[]numbers, Dictionary<int, EValueType> result)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2) == 0)
                {
                    result.Add(numbers[i], EValueType.Two);
                }
                else if (((numbers[i] % 3) == 0))
                {
                    result.Add(numbers[i], EValueType.Three);
                }
                else if (((numbers[i] % 5) == 0))
                {
                    result.Add(numbers[i], EValueType.Five);
                }
                else if (((numbers[i] % 7) == 0))
                {
                    result.Add(numbers[i], EValueType.Five);
                }
                else if (((numbers[i] % 2) != 0))
                {
                    result.Add(numbers[i], EValueType.Prime);
                }
            }
            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
              int contador = 0;
            foreach (KeyValuePair<int, EValueType> value in valores)
            {
                if (value.Value == EValueType.Three)
                {
                    contador++;
                }
            }
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
           
            Dictionary<int, EValueType> result = null;
            List<string> listNumber = sourceDict.Keys.ToList();
            listNumber.Sort();
            listNumber.Reverse();
            CalculateValues(this.numbers, result);

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
