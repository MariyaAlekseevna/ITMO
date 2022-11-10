﻿using System;
using System.IO;


namespace ITMO.CsharpLab05.FileDetails
{
    internal class FileDetails
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            checked
            {
                for (int i = 0; i < size; i++)
                {
                    contents[i] = (char)reader.Read();
                }
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            stream.Close();
            reader.Close();
            Summarize(contents);
            Console.ReadKey();
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
            Console.WriteLine("Total no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);
            Console.Read();
        }
    }
}