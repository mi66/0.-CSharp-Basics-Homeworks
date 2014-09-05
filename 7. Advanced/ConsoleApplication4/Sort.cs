using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingNumbers
{
    static int[] FillTheArray(int inputCount)
    {
        int[] array = new int[inputCount];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        return array;
    }

    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbersArray = FillTheArray(numbersCount);

        Console.WriteLine();

        foreach (var number in numbersArray)
        {
            Console.WriteLine(number);
        }
    }
}