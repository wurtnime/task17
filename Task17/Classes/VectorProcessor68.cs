using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor68
    {
        public VectorProcessor68() { }

        public bool IsAccepted(string input, bool symbolMode, bool endsWithZeroCriterion)
        {
            string currentSequence = "";
            bool hasDoubleOne = false;
            bool endsWithZero = false;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "11202"; break;
                        case 'b': currentSequence = "011"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }
            }

            endsWithZero = currentSequence.EndsWith("0");
            hasDoubleOne = currentSequence.Contains("11");

            return endsWithZeroCriterion ?
                endsWithZero :
                hasDoubleOne;
        }
    }
}
