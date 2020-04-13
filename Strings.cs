using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_April2020
{
    class Strings
    {
        // 3
        public void SeparateChars()
        {
            int l = 0;
            Console.WriteLine("Input a string: ");
            string str = Console.ReadLine();
            while (l <= str.Length-1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }
        }

        // 5
        public void CountTotalWords()
        {
            string str;
            
            int l = 0, wrd = 1;
            Console.Write("Input a string\n");
            str = Console.ReadLine();
            Console.WriteLine("Total number of words is: ");
            while (l <= str.Length-1)
            {
                // check char if is white space or new line or tab
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine("The total number of words is: {0}", wrd);
        }

        // 7
        public void CountChar_AlphabetsDigitsSpecials()
        {
            string str;
            int nAlphabets = 0, nDigits = 0, nSpecials = 0;

            Console.WriteLine("Input a string");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >='A' && str[i] <= 'Z'))
                {
                    nDigits++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    nAlphabets++;
                }
                else
                {
                    nSpecials++;
                }
            }
            Console.WriteLine("Number of Alphabets in the string is: {0}", nAlphabets);
            Console.WriteLine("Number of Digits in the string is: {0}", nDigits);
            Console.WriteLine("Number of Special in the string is: {0}", nSpecials);

        }

        // 8
        public void CopyStrings()
        {
            string str;
            int i, l;
            Console.Write("Input a string: \n");
            str = Console.ReadLine();
            l = str.Length;
            string[] strCopy = new string[l];
            // Copies str to trCopy character to character
            i = 0;
            while (i < l)
            {
                string temp = str[i].ToString();
                strCopy[i] = temp;
                i++;
            }
            Console.Write("\n The first string is {0}\n", str);
            Console.Write("The second string is: {0}\n", string.Join("", strCopy));
            Console.WriteLine("The number of characters copied is: {0}\n", i);
        
        }

        // 10
        public void MaxOccuring_Char()
        {

            string str;
            int ascii, max, i = 0; ;
            int[] ch_fre = new int[255];
            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();
            int l = str.Length;
            // Set frequency of all chars to 0
            for (i = 0; i < 255; i++)
            {
                ch_fre[i] = 0;
            }
            // Read frequency of each characters
            i = 0;
            while (i < l)
            {
                ascii = str[i];
                ch_fre[ascii] += 1;
                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (ch_fre[i] > ch_fre[max])
                        max = i;
                }
            }
            Console.Write("The Highest frequency of character '{0}' is" +
                " appearing for number of times : {1} \n", (char)max, ch_fre[max]);
        }

        // 11
        public void SortStringArray()
        {
            string str;
            int l;
            char ch;
            Console.Write("Input a string: \n");
            str = Console.ReadLine();
            l = str.Length;
            char[] strArr = str.ToCharArray(0, l);
            for (int i = 1; i < l; i++)
                for (int j = 0; j < l-i; j++)
                    if (strArr[j] > strArr[j + 1])
                    {
                        // SWAP *Good algo for sorting
                        ch = strArr[j];
                        strArr[j] = strArr[j + 1];
                        strArr[j + 1] = ch;
                    }
            Console.Write("After sorting the string appears like: \n");
            foreach (var c in strArr)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");
        }

        // 12
        public void BubbleSort_Strings()
        {
            string[] strings;
            string temp;
            int n, l;
            Console.WriteLine("Input number of strings: ");
            n = Convert.ToInt32(Console.ReadLine());

            strings = new string[n];
            Console.WriteLine("Input {0} strings below: ");

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            l = strings.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l-1; j++)
                {
                    if (strings[j].CompareTo(strings[j+1]) > 0)
                    {
                        temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
            Console.Write("\nAfter sorting the array appears like: \n");
            for (int i = 0; i < l; i++)
            {
                Console.Write(strings[i] + " ");
            }
        }

        // 16
        public static void Check_User_Password()
        {
            string username, password;
            int n = 0;

            do
            {
                Console.WriteLine("Input a username: ");
                username = Console.ReadLine();
                Console.WriteLine("Input a password: ");
                password = Console.ReadLine();
                if (username != "abcd" || password != "1234")
                    n++;
                else
                    n = 1;
            }
            while ((username != "abcd" || password != "1234") && n != 3);
            if (n == 3)
                Console.Write("\nLogin attempt 3 or more times. Try later\n");
            else
                Console.Write("\nThe password entered successfully !");
        }

        

    }
}
