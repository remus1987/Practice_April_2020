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
            // Display
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

        //7
        public void Merge2Arrays_SortAscending()
        {
            int num1, num2, num3;
            int i, j, k;
            int[] ary1 = new int[100];
            int[] ary2 = new int[100];
            int[] aryMerged = new int[100];

            Console.Write("Input number of elements from first array: \n");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < num1; i++)
            {
                Console.Write("element - {0} : ", i);
                ary1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input number of elements from second array: \n");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < num2; i++)
            {
                Console.Write("element - {0} : ", i);
                ary2[i] = Convert.ToInt32(Console.ReadLine());
            }
            // size of the merged array
            num3 = num1 + num2;

            // insert in the aryMerged
            for (i = 0; i < num1; i++)
            {
                aryMerged[i] = ary1[i];
            }
            for (j = 0; j < num2; j++)
            {
                aryMerged[i] = ary2[j];
                i++;
            }

            // Sort the array in ascending order
            for (i = 0; i < num3; i++)
            {
                for (k = 0; k < num3-1; k++)
                {
                    if (aryMerged[k] >= aryMerged[k+1])
                    {
                        // Swap
                        j = aryMerged[k + 1];
                        aryMerged[k + 1] = aryMerged[k];
                        aryMerged[k] = j;
                    }
                }
            }
            // Display
            Console.Write("\nThe merged array in ascending ordrer is: \n");
            for (i = 0; i < num3; i++)
            {
                Console.WriteLine("{0} ", aryMerged[i]);
            }
        }

        //8
        public void CountElementFrequency()
        {
            int i, j;
            int n, counter;
            int[] multime = new int[100];
            int[] frequency1 = new int[100];

            Console.Write("Input the number of elements to be stored in the array: \n");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} elements in the array\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                multime[i] = int.Parse(Console.ReadLine());
                frequency1[i] = 1;
            }

            // Find the frequency for each element
            for (i = 0; i < n; i++)
            {
                counter = 1;
                for (j = i+1; j < n; j++)
                {
                    if (multime[i] == multime[j])
                    {
                        counter++;
                        frequency1[j] = 0;
                    }
                }
                if (frequency1[i] != 0)
                {
                    frequency1[i] = counter;
                }
            }
            Console.Write("\nThe frequency of all elements of the array: \n");
            for (i = 0; i < n; i++)
            {
                if (frequency1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", multime[i], frequency1[i]);
                }
            }
        }

        //9
        public static void MaximumAndMinimumElement()
        {
            int n, max, min;
            int[] arr = new int[100];
            Console.Write("Input the number of elements to be stored: \n");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element is {0}\n", max);
            Console.Write("Minimum element is {0}\n", min);
        }
    }
}
