using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendRandomNumbers
{
    internal class GetSort
    {

        private static void ShowResult(List<int> forSort)
        {
            Console.WriteLine($"Отсортированные элементы:");
            for (int i = 0; i < forSort.Count; i++)
            {
                Console.Write($"{forSort[i]}; ");
            }
            Console.WriteLine();
            
        }
        //Сортировка пузырьком
        internal static List<int> BubbleSort(List<int> forSort)
        {
            Console.WriteLine("Выбран алгоритм сортировки пузырьком");
            for (int i = 0; i < forSort.Count; i++)
            {
                for (int j = 0; j < forSort.Count - 1; j++)
                {
                    if (forSort[j] > forSort[j + 1])
                    {
                        int temp = forSort[j];
                        forSort[j] = forSort[j + 1];
                        forSort[j + 1] = temp;
                    }
                }
            }

            ShowResult(forSort);
            return forSort;
        }

        //Сортировка перемешиванием
        internal static List<int> CocktailSort(List<int> forSort)
        {
            Console.WriteLine("Выбран алгоритм сортировки перемешиванием");
            int left = 0,
                right = forSort.Count - 1,
                count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (forSort[i] > forSort[i + 1])
                        Swap(forSort, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (forSort[i - 1] > forSort[i])
                        Swap(forSort, i - 1, i);
                }
                left++;
            }
            ShowResult(forSort);
            return forSort;
        }
        static void Swap(List<int> forSort, int i, int j)
        {
            int glass = forSort[i];
            forSort[i] = forSort[j];
            forSort[j] = glass;
        }

        //Сортировка вставками
        internal static List<int> InsertionSort(List<int> forSort)
        {
            Console.WriteLine("Выбран алгоритм сортировки вставками");
            for (int i = 1; i < forSort.Count; i++)
            {
                int cur = forSort[i];
                int j = i;
                while (j > 0 && cur < forSort[j - 1])
                {
                    forSort[j] = forSort[j - 1];
                    j--;
                }
                forSort[j] = cur;
            }
            ShowResult(forSort);
            return forSort;
        }

        //Сортировка выбором
        internal static List<int> SelectSort(List<int> forSort)
        {
            Console.WriteLine("Выбран алгоритм сортировки выбором");
            for (int i = 0; i < forSort.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < forSort.Count; j++)
                {
                    if (forSort[j] < forSort[min])
                    {
                        min = j;
                    }
                }
                int dummy = forSort[i];
                forSort[i] = forSort[min];
                forSort[min] = dummy;
                min = i;
            }
            ShowResult(forSort);
            return forSort;
        }

        //Сортировка Шелла
        internal static List<int> ShellSort(List<int> forSort)
        {
            Console.WriteLine("Выбран алгоритм сортировки Шелла");
            int step = forSort.Count / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < forSort.Count; i++)
                {
                    int value = forSort[i];
                    for (j = i - step; (j >= 0) && (forSort[j] > value); j -= step)
                        forSort[j + step] = forSort[j];
                    forSort[j + step] = value;
                }
                step /= 2;
            }
            ShowResult(forSort);
            return forSort;
        }

    }
}
