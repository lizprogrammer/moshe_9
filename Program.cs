using System;
﻿using System.IO;
﻿
// ﻿1- Write a program that reads a text file and displays the number of words.
// 2- Write a program that reads a text file and displays the longest word in the file.

namespace Section9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string OldFile = @"/home/ubuntu/workspace/Section9/files/text.txt";
            string NewFile = @"/home/ubuntu/workspace/Section9/files/text.bak";
            
            //CopyFiles(OldFile, NewFile);

            StreamReader sr = new StreamReader(NewFile);
                while (sr.ReadLine()!=null)
            {
                Line =sr.ReadLine();
                Console.WriteLine(Line);
            }

        }
        
        static int CopyFiles(string Old, string New)
        {
            if(File.Exists(New))
                File.Delete(New);
            
            File.Copy(Old, New);   
            
            Console.WriteLine("You are good");            
            return 0;
        }
        

    }
    
    

}
