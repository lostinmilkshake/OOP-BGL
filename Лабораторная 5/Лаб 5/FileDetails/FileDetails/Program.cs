using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDetails
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }*/
            try
            {
                string fileName = args[0];
                FileStream stream = new FileStream(fileName, FileMode.Open);
                StreamReader reader = new StreamReader(stream, Encoding.Default);
                int size = (int)stream.Length;
                //Console.WriteLine("Length of text in file: " + size);
                char[] contents = new char[size];
                for (int i = 0; i < size; i++)
                {
                    contents[i] = (char)reader.Read();
                }
                reader.Close();
                /*foreach (char ch in contents)
                {
                    Console.Write(ch);
                }*/
                Summarize(contents);
                
            }
            catch(Exception)
            {
                Console.WriteLine("The program can't read the file!");
            }
            Console.ReadKey(true);
        }

        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;
            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total of characters: {0}", contents.Length);
            Console.WriteLine("Total of vowels : {0}", vowels);
            Console.WriteLine("Total of consonants: {0}", consonants);
            Console.WriteLine("Total of lines : {0}", lines + 1);
        }
    }
}
