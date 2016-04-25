using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SystemArrayString : ICustomString
    {
       
        char[] initialStringArray;
        string initalString;
        public int tempIndex;
        int indexCounter;
        public SystemArrayString(string InitialString)
        {
            initalString = InitialString;
            this.initialStringArray = InitialString.ToCharArray();
        }
        public void insert(int index, string toStringInsert)
        {
            char[] tempArray = toStringInsert.ToCharArray();
            char[] completeCharArray = new char[toStringInsert.Length + initalString.Length];


            for (int i = 0; i < initialStringArray.Length; i++)
            {

                completeCharArray[i] += initialStringArray[i];

            }
            for (int i = initialStringArray.Length; i < completeCharArray.Length; i++)
            {

                completeCharArray[i] += tempArray[i-index];

            }



        }
           

        public int length()
        {
            for(int i = 0; i < )
        }

        public void remove(int index, int numbCharsToRemove)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }
}
