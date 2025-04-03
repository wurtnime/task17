using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor65
    {
        public VectorProcessor65() { }

        public bool IsAccepted(string input, bool symbolMode, bool sumCriterion)
        {
            int digitSum = 0;
            bool allDigitsSame = true;
            char? firstDigit = null;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0110"; break;
                        case 'b': currentSequence = "1120"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }

                foreach (char digit in currentSequence)
                {
                    int digitValue = digit - '0';
                    digitSum += digitValue;

                    if (!firstDigit.HasValue)
                    {
                        firstDigit = digit;
                    }
                    else if (digit != firstDigit)
                    {
                        allDigitsSame = false;
                    }
                }

                currentSequence = "";
            }

            return sumCriterion ?
                digitSum % 3 == 0 :  
                allDigitsSame;       
        }
    }
}
