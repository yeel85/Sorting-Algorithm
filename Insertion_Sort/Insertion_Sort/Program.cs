// reference http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
           InsertionSort();
            Console.ReadLine();
        }

        static double InsertionSort()
        {
            Console.Write("Program To sort Value in ascending arrangement using Bubble Sort" + "\n");
            Console.Write("\nPlease Enter the Total Number of Elements: ");
            int Sum_element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNumber of Element = " + Sum_element);

            float[] element_array = new float[Sum_element];

            float temp;

            for (int i = 0; i < Sum_element; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                element_array[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nBefore Sorting: " + String.Join(",", element_array));

            for (int i =1;i<Sum_element;i++)
            {
                for(int j=i; j > 0 && element_array[j] < element_array[j-1];j--)
                {
                    temp = element_array[j];
                    element_array[j] = element_array[j - 1];
                    element_array[j - 1] = temp;
                  // Console.Write("ivalue="+i+"javalue="+j + "\n" + temp + "\n" + element_array[j] + "\n" + element_array[j - 1] + "\n");
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
