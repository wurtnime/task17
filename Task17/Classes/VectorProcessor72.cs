using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor72
    {
        public VectorProcessor72() { }

        public bool IsAccepted(string input, bool symbolMode, bool specialSymbolCriterion)
        {
            string currentSequence = "";
            bool hasSpecialSymbol = false;
            bool partsEqual = false;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "1|Ø"; break;
                        case 'b': currentSequence = "2122"; break;
                        case 'c': currentSequence = "1|20"; break;
                        default: return false;
                    }
                }
                else
                {
                    currentSequence += c;
                }
            }

            hasSpecialSymbol = currentSequence.Contains("Ø");

            if (currentSequence.Contains("|"))
            {
                string[] parts = currentSequence.Split('|');
                if (parts.Length == 2)
                {
                    string left = parts[0];
                    string right = parts[1];

                    int leftSum = left.Where(char.IsDigit).Sum(c => c - '0');
                    int rightSum = right.Where(char.IsDigit).Sum(c => c - '0');
                    partsEqual = leftSum == rightSum;
                }
            }
            else
            {
 
                partsEqual = false;
            }

            return specialSymbolCriterion ?
                hasSpecialSymbol :   
                partsEqual;         
        }
    }
}
