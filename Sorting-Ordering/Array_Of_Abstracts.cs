using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    class Array_Of_Abstracts
    {
        private Nodes[] arrayOfNodes = new Nodes[2];
        public Array_Of_Abstracts()
        {


        }

        public Nodes[] addName()
        {
            for (int a = 0; a < arrayOfNodes.Length; a++)
            {
                Nodes temp = new Nodes();

                Console.WriteLine("PLease enter name");
                temp.firstName = Console.ReadLine();

                arrayOfNodes[a] = temp;
            }

            return arrayOfNodes;
        }

        public void display(Nodes[] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a].firstName);
            }
        }

        public void display(string comment, Nodes [] array)
        {
            string output = "";

            for (int a = 0; a < array.Length; a++)
            {
                output += array[a].firstName + " ";
            }

            Console.WriteLine(comment + output);
        }

        public Nodes[] BubbleSort(Nodes [] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    if (array[a].firstName.CompareTo(array[b].firstName) > 0)
                    {
                        Nodes temp = array[a];
                        array[a] = array[b];
                        array[b] = temp;
                    }
                }
            }

            return array;
        }

        public Nodes[] insertionSort(Nodes[] array)
        {
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b < array.Length; b--)
                {
                    if (array[b-1].firstName.CompareTo(array[b].firstName) > 0)
                    {
                        Nodes temp = array[b-1];
                        array[b-1] = array[b];
                        array[b] = temp;
                    }
                }
            }

            return array;
        }

        public Nodes [] SelectionSort(Nodes [] array)
        {
            Nodes temp;

            for (int a = 0; a < array.Length - 1; a++)

            {
                int smallest = a;
                {
                    for (int b = a + 1; b < array.Length; b++)
                    {
                        if (array[b].firstName.CompareTo(array[smallest].firstName) < 0)
                        {
                            smallest = b;
                        }

                    }

                    temp = array[smallest];
                    array[smallest] = array[a];
                    array[a] = temp;

                }
            }

            return array;
        }
    }
}