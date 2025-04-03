using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor71
    {
        public VectorProcessor71() { }

        public bool IsAccepted(string input, bool symbolMode, bool containsTenCriterion)
        {
            string currentSequence = "";
            bool hasTen = false;
            int digitSum = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "2100"; break;
                        case 'b': currentSequence = "21101"; break;
                        case 'c': currentSequence = "01110"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }
            }

            hasTen = currentSequence.Contains("10");
            digitSum = currentSequence.Sum(c => c - '0');

            return containsTenCriterion ?
                hasTen : 
                digitSum == 4;   
        }
    }
}
