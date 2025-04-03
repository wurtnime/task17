using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor67
    {
        public VectorProcessor67() { }

        public bool IsAccepted(string input, bool symbolMode, bool specialSymbolCriterion)
        {
            bool hasSpecialSymbol = false;
            int sum = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0 1 1"; break;
                        case 'b': currentSequence = "2 1 ⓒ"; break;
                        default: return false;
                    }
                }
                else
                {
                    currentSequence += c;
                }
            }

            if (currentSequence.Contains("ⓒ"))
            {
                hasSpecialSymbol = true;
            }

            string[] numbers = currentSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string numStr in numbers)
            {
                if (numStr == "ⓒ") continue;

                if (int.TryParse(numStr, out int num))
                {
                    sum += num;
                }
                else
                {
                    return false;
                }
            }

            return specialSymbolCriterion ?
                hasSpecialSymbol :
                sum == 5;
        }
    }
}
