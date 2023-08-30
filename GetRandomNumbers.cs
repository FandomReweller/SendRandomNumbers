using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SendRandomNumbers
{
    internal class GetRandomNumbers
    {
        List<int> RandomNumbers = new List<int>();
        List<int> SortRandomNumbers = new List<int>();
        Random GetRandom = new Random();

        internal void GetRandomList()
        {
            Console.WriteLine("Получены элементы:");
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                RandomNumbers.Add(GetRandom.Next(-100, 100));
                Console.Write($"{RandomNumbers[i]};  ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество элементов:" + RandomNumbers.Count);

            SendMessage.Send(Sort(RandomNumbers));

        }

        private List<int> Sort(List<int> forSort)
        {
            switch (GetRandom.Next(0, 4))
            {
                case 0:
                   SortRandomNumbers = GetSort.BubbleSort(forSort);
                    break;
                case 1:
                    SortRandomNumbers = GetSort.CocktailSort(forSort);
                    break;
                case 2:
                    SortRandomNumbers = GetSort.InsertionSort(forSort);
                    break;
                case 3:
                    SortRandomNumbers = GetSort.ShellSort(forSort);
                    break;
                default:
                    SortRandomNumbers = GetSort.BubbleSort(forSort);
                    break;
            }
            return SortRandomNumbers;
        }
    }
}
