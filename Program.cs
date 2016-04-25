using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SystemString testTheString = new SystemString();

            //testTheString.insert(2," ");
            //testTheString.remove(4, 1);
            //Console.WriteLine(testTheString.toString());
            //Console.WriteLine(testTheString.length());
            SystemArrayString systemArrayString = new SystemArrayString("Tyler");
            systemArrayString.insert(5, "Thomann");
            
            Console.ReadLine();
        }
    }
}
