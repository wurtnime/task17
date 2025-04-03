using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor76
    {
        public VectorProcessor76() { }

        public bool IsAccepted(string input, bool symbolMode, bool doubleDigitsCriterion)
        {
            string currentSequence = "";
            bool hasDoubleZero = false;
            bool hasDoubleOne = false;
            int oneCount = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0101"; break;
                        case 'b': currentSequence = "011101"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }
            }

            hasDoubleZero = currentSequence.Contains("00");
            hasDoubleOne = currentSequence.Contains("11");
            oneCount = currentSequence.Count(c => c == '1');

            return doubleDigitsCriterion ?
                (hasDoubleZero && hasDoubleOne) : 
                (oneCount % 3 == 0);              
        }
    }
}
