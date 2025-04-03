using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor78
    {
        public VectorProcessor78() { }


        public bool IsAccepted(string input, bool symbolMode, bool contains0110Criterion)
        {
            string currentSequence = "";
            bool has0110 = false;
            int zeroCount = 0;
            int oneCount = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0101101"; break;
                        case 'b': currentSequence = "0100"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }
            }

            has0110 = currentSequence.Contains("0110");
            zeroCount = currentSequence.Count(c => c == '0');
            oneCount = currentSequence.Count(c => c == '1');

            return contains0110Criterion ?
                has0110 :
                zeroCount == oneCount; 
        }
    }
}
