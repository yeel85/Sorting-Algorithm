//// Reference using http://cforbeginners.com/CSharp/SelectionSort.html
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort();
            Console.ReadLine();
        }

        static void QuickSort()
        {
            Console.Write("Program To sort Value in ascending arrangement using Bubble Sort" + "\n");
            Console.Write("\nPlease Enter the Total Number of Elements: ");
            int Sum_element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNumber of Element = " + Sum_element);

            float [] element_array = new float[Sum_element];


            for (int i = 0; i < Sum_element; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                element_array[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nBefore Sorting: " + String.Join(",", element_array));

            Arrayquicksort(element_array,0,Sum_element-1);

            Console.Write("\nThe sorted number are:\n");
            for (int i = 0; i < Sum_element; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: " + element_array[i] + "\n");
            }

        }

        static void Arrayquicksort(float[] data, int l, int r)
        {
            int i, j;
            float x;

            i = l;
            j = r;

             x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }

            if (l < j)
                Arrayquicksort(data, l, j);
            if (i < r)
                Arrayquicksort(data, i, r);
        }

        public static void exchange(float[] data, int m, int n)
        {
            float temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

    }
}
