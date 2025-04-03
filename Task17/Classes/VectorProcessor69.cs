using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor69
    {
        public VectorProcessor69() { }

        public bool IsAccepted(string input, bool symbolMode, bool consecutiveOnesCriterion)
        {
            string currentSequence = "";
            bool hasFourConsecutiveOnes = false;
            int digitSum = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0111"; break;
                        case 'b': currentSequence = "11201"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }
            }

            hasFourConsecutiveOnes = currentSequence.Contains("1111");

            digitSum = currentSequence.Sum(c => c - '0');

            return consecutiveOnesCriterion ?
                hasFourConsecutiveOnes :  
                digitSum == 5;
        }
    }
}
