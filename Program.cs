using System;
﻿using System.IO;
﻿
// ﻿1- Write a program that reads a text file and displays the number of words.
// 2- Write a program that reads a text file and displays the longest word in the file.

//string[] StringArray = s.Split(' ');

namespace Section9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string OldFile = @"/home/ubuntu/workspace/Section9/files/text.txt";
            string NewFile = @"/home/ubuntu/workspace/Section9/files/text.bak";
            
            CopyFile(OldFile, NewFile);
            //CountWords(OldFile);
            Console.WriteLine(String.Format("The biggest word in the file is {0}", BiggestWord(OldFile)));

        }
        
        static int CopyFile(string Old, string New)
        {
            if(File.Exists(New))
                File.Delete(New);
            
            File.Copy(Old, New);   
            
            //Console.WriteLine("You are good");            
            return 0;
        }
        
        static int CountWords(string FileName)
        {
            
            int counter = 0;  
            string line;  

            int CountWords = 0;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@FileName);  
            while((line = file.ReadLine()) != null)  
            {  
                Console.WriteLine(String.Format("{0}",line));
                string[] StringArray = line.Split(' '); 
                CountWords += StringArray.Length;
                
                //System.Console.WriteLine(line);  
                for(int i = 0; i < line.Length; i++)
                {
                    // do nothing
                }    
                counter++;  
            }  

            file.Close();  
            System.Console.WriteLine("There are {0} lines.", counter);  
            System.Console.WriteLine("There are {0} words.", CountWords);  
            // Suspend the screen.  
            System.Console.ReadLine(); 
                
            return 0;            
        }
        
        static string BiggestWord(string MyFile)
        {
                      
            int counter = 0;  
            string line;  
            string BiggestWord = "";
            int BiggestSize = 0;            

            int CountWords = 0;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@MyFile);  
            while((line = file.ReadLine()) != null)  
            {  
                
                //Console.WriteLine(String.Format("{0}",line));
                string[] StringArray = line.Split(' '); 
                CountWords += StringArray.Length;
                
                
                //System.Console.WriteLine(line);  
                foreach(string str in StringArray)
                {
                    if(str.Length > BiggestSize)
                    {
                        BiggestWord = str;
                        BiggestSize = str.Length;
                    }   
                }
                counter++;  
            }  

            file.Close();  
            // Suspend the screen.  
            System.Console.ReadLine(); 
            
            
            return BiggestWord;
            
        }
    }
    
}
