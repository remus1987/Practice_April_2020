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
        public void PrintArrayUniqueElem()
        {
            int i, n;
            int[] ary = new int[100];

            Console.WriteLine("Input the number of elements to be stored: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0}: ", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe unique elements found in the array are: ");
            for (i != ; i < length; i++)
            {

            }
        }

    }
}
