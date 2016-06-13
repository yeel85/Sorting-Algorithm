// Reference using http://cforbeginners.com/CSharp/SelectionSort.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            SelectionSort();
            Console.ReadLine();
        }


        static double SelectionSort()
        {
            Console.Write("Program To sort Value in ascending arrangement using Bubble Sort" + "\n");
            Console.Write("\nPlease Enter the Total Number of Elements: ");
            int Sum_element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNumber of Element = " + Sum_element);

            float [] element_array = new float[Sum_element];

            int index_min;
            float temp;

            for (int i = 0; i < Sum_element; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                element_array[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nBefore Sorting: " + String.Join(",", element_array));


            for (int i = 0; i < Sum_element - 1; i++)
            {
                index_min = i;

                for (int j=i+1;j<Sum_element; j++)
                {
                    if(element_array[j] < element_array[index_min])
                    {
                        index_min = j;

                    }

                }

                if (index_min != i)
                {
                    temp = element_array[i];
                    element_array[i] = element_array[index_min];
                    element_array[index_min] = temp;
                }

            }

            Console.Write("\nThe sorted number are:\n");
            for (int i = 0; i < Sum_element; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: " + element_array[i] + "\n");
            }
            return 0;
        }

    }
}
