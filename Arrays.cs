using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Practice_April2020
{
    class Arrays
    {
        //1
        public void StoreAndPrintArrayElements()
        {
            int i;
            int[] ary = new int[10];
            for (i = 0; i < 10; i++)
            {
                Console.Write("Please input element {0}: ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The elements in array are:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", ary[i]);
            }
            
        }

        //2
       public void DisplayNValuesInReverseOrder()
        {
            int[] ary = new int[100];
            int i, n;
            Console.Write("Input the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements of the array\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe values store into the array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", ary[i]);
            }
            Console.Write("\nThe values store into the array in reverse are : ");
            for (i = n-1; i >= 0; i--)
            {
                Console.Write("{0} ", ary[i]);
            }
        }

        //3
        public void SumOfAryElem()
        {
            int[] ary = new int[100];
            int i, n, sum = 0;
            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                ary[i] = int.Parse(Console.ReadLine());
                sum += ary[i];
            }
            Console.Write("Sum of all elements stored in the array is : {0}", sum);
            
        }

        //4
        public void CopyArrayElements()
        {
            int[] ary = new int[100];
            int[] aryCopy = new int[100];
            int i, n;

            Console.Write("Input the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Copy elements of first array into second array
            for (i = 0; i < n; i++)
            {
                aryCopy[i] = ary[i];
            }

            Console.Write("The elements stored inthe first array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", ary[i]);
            }
            Console.Write("\nThe elements stored in the second array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", aryCopy[i]);
            }
            
        }

        //5
        public void CountArrayDuplicates()
        {
            int i, j, n, mm=1;
            int totalDuplicates = 0;
            int[] ary = new int[100];
            int[] aryRef = new int[100];

            Console.WriteLine("Input the number of elements to be stored: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0}: ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            // mark the elements are duplicate
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (ary[i] == ary[j])
                    {
                        aryRef[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            // prints the array
            for (i = 0; i < n; i++)
            {
                if (aryRef[i] == 2)
                {
                    totalDuplicates++;
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is : {0}", totalDuplicates);
        }

        //6
        public void PrintUniqueElements()
        {
            int i, j, k, n;
            int counter = 0;
            int[] ary = new int[100];

            Console.Write("Input the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in th array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            // check duplicate elements in the array
            Console.Write("The unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                counter = 0;
           // Check duplicate before the current position and increase counter by 1 if found
                for (j = 0; j < i-1; j++)
                {
                    // Increment the counter when the search value is duplicate
                    if (ary[i] == ary[j])
                    {
                        counter++;
                    }
                }
           // Check duplicate after the current position and increase counter by 1 if found
                for (k = i + 1; k < n; k++)
                {
                    if (ary[i] == ary[k])
                    {
                        counter++;
                    }
                    // Duplicate numbers next to each other
                    if (ary[i] == ary[i+1])
                    {
                        i++;
                    }
                }
            
            // print the value of the current position of the array as unique value when counter remain contains its initial value
                if (counter == 0)
                {
                    Console.Write("{0} ", ary[i]);
                }
            }
            Console.Write("\n\n");
           
        }
    }
}
