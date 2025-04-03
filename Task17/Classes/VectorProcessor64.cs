using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor64
    {
        public VectorProcessor64() { }

        public bool IsAccepted(string input, bool symbolMode, bool sequenceCriterion)
        {
            int digitSum = 0;
            bool hasDoubleZero = false;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "1100"; break;
                        case 'b': currentSequence = "012"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }

                if (currentSequence.Contains("00"))
                {
                    hasDoubleZero = true;
                }

                // Подсчет суммы цифр
                foreach (char digit in currentSequence)
                {
                    digitSum += digit - '0';
                }

                currentSequence = "";
            }

            return sequenceCriterion ?
                hasDoubleZero : 
                digitSum == 4; 
        }
    }
}
