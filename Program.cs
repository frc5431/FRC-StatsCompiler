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
	    Console.WriteLine("FRC-StrongHold Build");
	    Console.WriteLine("Welcome Titan!");  
            shellInput = Console.ReadLine();
            Commander(shellInput); 
        }
        public static void Commander(string Input)
        {
            if (Input.Contains("report"))
            {
                Console.WriteLine("Reporting..."); 
            }
            else 
            {
            }
        }
	public static void CSVparser()
	{
	 //Locate csv  
	   
	}
    }

  }
