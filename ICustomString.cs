using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ICustomString
    {
        string toString();
        int length();
        void insert(int index, string toStringInsert);
        void remove(int index, int numbCharsToRemove);
    }
}
