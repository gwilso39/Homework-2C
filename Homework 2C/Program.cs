using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntactic sugar is meant to make life easier for a programmer or anyone
            //trying to read code.  It simplifies the process by making things a bit
            //more clear or concise and in an alternative style.  The language is said
            //to be 'sweeter' for human use.
        }

        string RVProblems(string trailer = "Hideout", string wheels = "four")
        {
            Console.WriteLine($"A {trailer} has {wheels} wheels.");
            return "";
        }
    
        //equivalent...
        string MoreRVProblems(string trailer, string wheels)
        {
            Console.WriteLine($"A {trailer} has {wheels} wheels.");
            return "";
        }

        string MoreRVProblems(string trailer)
        {
            return MoreRVProblems(trailer, "four");
        }

        string MoreRVProblems()
        {
            return MoreRVProblems("Hideout");
        }
    }
}
