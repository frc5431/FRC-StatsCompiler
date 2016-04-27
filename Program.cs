using System;

namespace ConsoleApplication
{
    public class Program
    {   
	  
        public static void Main(string[] args)
        {
            var shell = "#->";
            string shellInput; 
  
            Console.WriteLine("FRC-DataCompiler 1.0");
	    Console.WriteLine("X Shell Version 0.7"); 
            shellInput = Console.ReadLine();
            Commander(shellInput); 
        }
        public static void Commander(string Input)
        {
            if (Input == "report")
            {
                Console.WriteLine("Reporting..."); 
            }
            else 
            {
            }
        }
    }

  }
