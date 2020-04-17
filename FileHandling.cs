using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice_April2020
{
    class FileHandling
    {
        // 1
        public static void CreateBlankFile()
        {
            // C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            try
            {
                Console.WriteLine("Create a file named mytest2.txt in the disk");
                Console.WriteLine("------------------------------------------");
                // create the file
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine("A file created with name mytest2.txt");
                }
            }
            catch (Exception MyExcep)
            {

                Console.WriteLine(MyExcep.ToString());
            }
        }

        // 2
        public static void RemoveFile()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            // delete the file if exists
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("File deleted!");
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
            }
        }

        // 3
        public void OverrideTheFile()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            try
            {
                Console.WriteLine("create the file mytest2");
                using (FileStream fileStr2 = File.Create(fileName))
                {
                    Console.WriteLine("File mytest2.txt created");
                }
            }
            catch (Exception Myexc)
            {

                Console.WriteLine(Myexc.ToString());
            }

        }

        // 4
        public void CreateFileAddText()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.WriteLine("Create a file on disk if exists");
                Console.WriteLine("-------------------------------");
                // create the file
                using (StreamWriter streamWriter = File.CreateText(fileName))
                {
                   streamWriter.WriteLine("Salut. WhatsUpp !!!");
                   streamWriter.WriteLine("Bine ati venit");
                   streamWriter.WriteLine("Va rog sa va simteti bine.");
                }
            }
            catch (Exception myExc)
            {
                Console.WriteLine(myExc.ToString());
            }
        }

        // 5
        public void CreateFileReadText()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter streamWriter = File.CreateText(fileName))
                {
                    streamWriter.WriteLine("Salam");
                    streamWriter.WriteLine("Parizer");
                }
                using (StreamReader streamReader = File.OpenText(fileName))
                    {
                        string s = "";
                        Console.WriteLine("Here is the content: ");
                        while ((s = streamReader.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    Console.WriteLine("");
                    }
                
            }
            catch (Exception myExc)
            {
                Console.WriteLine(myExc.ToString());
            }
        }

        // 6
        public void WriteArrayOnFile()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            int n;
            string[] strArray;
            
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.WriteLine("Input number of lines to write in the file: ");
            n = Convert.ToInt32(Console.ReadLine());
            strArray = new string[n];

            try
            {
                    Console.WriteLine("Input {0} strings below: ", n);
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Input line {0}" ,i);
                        strArray[i] = Console.ReadLine();
                    }
                    File.WriteAllLines(fileName, strArray);

                using (StreamReader streamReader = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(" {0}", s);
                    }
                }
            }
            catch(Exception myExc)
            {
                Console.WriteLine(myExc.ToString());
            }
        }

        // 7
        public void WriteArrayOnfile2()
        {
            string fileName = @"C:\Users\tru55\Desktop\GitHub\Practice_April2020\File_Handling\mytest2.txt";
            string ignoreLine = "";
            string[] strArray;
            int n;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.WriteLine("Input the string to ignore the line: ");
            ignoreLine = Console.ReadLine();
            Console.WriteLine("Input number of lines to write: ");
            n = Convert.ToInt32(Console.ReadLine());
            strArray = new string[n];

            Console.WriteLine("Input {0} strings below: ");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Input line {0}: ", i+1);
                    strArray[i] = Console.ReadLine();
                }
                using (StreamWriter strWriter = new StreamWriter(fileName))
                {
                    foreach (string line in strArray)
                    {
                        // write the line to the file If it doesn't contain the string
                        if (!line.Contains(ignoreLine))
                        {
                            strWriter.WriteLine(line);
                        }
                    }
                }
                using (StreamReader strReader = File.OpenText(fileName))
                {
                    string s = "";
                    Console.Write("\nThe line ignored is {0}", ignoreLine);
                    while ((s = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine("\n {0}", s);
                    }
                }
            }
            catch (Exception myExc)
            {

                Console.WriteLine(myExc.ToString()); 
            }

        }
    }
}
