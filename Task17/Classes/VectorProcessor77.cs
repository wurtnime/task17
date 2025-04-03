using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor77
    {
        public VectorProcessor77() { }

        public bool IsAccepted(string input, bool symbolMode, bool isPalindromeCriterion)
        {
            string currentSequence = "";
            bool isValid = true;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0110"; break;
                        case 'b': currentSequence = "1010"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }
            }

            if (isPalindromeCriterion)
            {
                for (int i = 0; i < currentSequence.Length / 2; i++)
                {
                    if (currentSequence[i] != currentSequence[currentSequence.Length - 1 - i])
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
        }
    }
}
