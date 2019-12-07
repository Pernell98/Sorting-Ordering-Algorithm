using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Array_Of_Strings
    {
        private string[] words = { "friends", "romans", "and", "countrymen", "lend", "me", "your", "ears", "I", "come","to", "bury", "ceasar","not","to","praise", "him" };

        public Array_Of_Strings()
        {
            //bubbleSort();

            //display();

            insertionSort();

        }

        public string[] bubbleSort()
        {
            for(int a  = 0;  a < words.Length-1; a++)
            {
                for (int b = a + 1; b < words.Length; b++)
                {
                    if(words[a].CompareTo(words[b]) > 0)
                    {
                        string temp = words[a];
                        words[a] = words[b];
                        words[b] = temp;

                    }

                }
            }

            return words;
        }

        public void insertionSort(string [] words)
        {

            for(int a = 0; a < words.Length - 1; a++)

            {
                for(int b = a + 1;  b > 0; b--)
                {
                    if(words[b-1].CompareTo(words[b]) > 0)
                    {
                        string temp = words[b-1];
                        words[b-1] = words[b];
                        words[b] = temp;
                    
                    }
                }
            }
        }

        public void SelectionSort(string [] array)
        {

            for(int a = 0; a < words.Length - 1; a++)

            {
                int smallest = a;
                {
                    for (int b = a + 1; b < array.Length; b++)
                    {
                        if (array[b].CompareTo(array[smallest]) < 0)
                        {
                            smallest = b;
                        }
                    
                    }

                    temp = array [smallest];
                    array[smallest] = array[a];
                    array[a] = temp;

                }
            }

            return array;
        }

        public void display()
        {
            for(int a = 0; a < words.Length; a++)
            {
                Console.WriteLine(words[a]); 
            }
        }
    }
}
