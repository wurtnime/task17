using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor73
    {
        public VectorProcessor73() { }

        public bool IsAccepted(string input, bool symbolMode, bool tripleOnesCriterion)
        {
            string currentSequence = "";
            bool hasTripleOnes = false;
            int digitSum = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'b': currentSequence = "01120"; break;
                        case 'c': currentSequence = "210"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }
            }

            hasTripleOnes = currentSequence.Contains("111");
            digitSum = currentSequence.Sum(c => c - '0');

            return tripleOnesCriterion ?
                hasTripleOnes :     
                digitSum % 3 == 0; 
        }
    }
}
