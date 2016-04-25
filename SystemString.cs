using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SystemString : ICustomString
    {

        public string test = "Audacious";
        int lengthTest;
        
   
        public void insert(int index,string toStringInsert)
        {
            test = test.Insert(index,toStringInsert);    
        }

        public int length()
        {
           lengthTest = test.Length;
            return lengthTest;
        }

        public void remove(int index, int numbCharsToRemove)
        {
            test = test.Remove(index,numbCharsToRemove);

        }

        public string toString()
        {
            return test;
    
        }
    }
}
