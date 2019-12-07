using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Array_Of_Primitives
    {
        private int[] numbers = new int[10];
        Random randomNumberGenerator = new Random();

        public Array_Of_Primitives()
        {
            numbers = addRandomNumbers();

            numbers = bubbleSort(numbers);

            numbers = insertionSort(numbers);

            numbers = selectionSort(numbers);

            display("Bubble Sort ", numbers);
            display("Insertion Sort ", numbers);
            display("Selection Sort ", numbers);
        }

        
       public int[] addRandomNumbers()
       {
           for(int a = 0; a < numbers.Length; a++)
           {
               numbers[a] = randomNumberGenerator.Next(20);

               //ensures that there are no duplicates but ask Doc what does it does exactly 
               for (int p = 0; p < a; p++)
               {
                   if (numbers[a] == numbers[p])
                       a--;
               }
           }

           return numbers;
       }
       

        public int[] bubbleSort(int[] numbers)
        {
            int temp = 0;

            for(int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length - 1; b++)
                {
                    if (numbers[b] > numbers[b + 1])
                    {
                        temp = numbers[b + 1];
                        numbers[b + 1] = numbers[b];
                        numbers[b] = temp;
                    }
                }    
            }
            return numbers;
        }

        public int[] insertionSort(int[] array)
        {

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b > 0; b--)
                {
                    if (array[b - 1] > array[b])
                    {
                        int temp = array[b - 1];
                        array[b - 1] = array[b];
                        array[b] = temp;
                    }

                }

            }
            return array;
        }

        public int[] selectionSort(int[] array)
        {
            int temp;

            for(int a =0; a < array.Length -1; a++ )
            {
                int smallest = a;

                for(int b = a + 1; b < array.Length; b++)
                {
                    if(array[b] < array[smallest])
                    {
                        smallest = b;

                       
                    }
                    
                }

                temp = array[smallest];
                array[smallest] = array[a];
                array[a] = temp;
            }

            return array;
        }

        public void display(int[] array)
        {
            for(int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        public void display( string sort, int[] array)
        {
            string output = "";
            for (int a = 0; a < array.Length; a++)
            {
                output += array[a];
            }

            Console.WriteLine( sort + output);
        }
    }
}
