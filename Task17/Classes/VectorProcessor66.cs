using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor66
    {
        public VectorProcessor66() { }


        public bool IsAccepted(string input, bool symbolMode, bool equalityCriterion)
        {
            string currentSequence = "";
            bool hasZeroPipeZero = false;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "2|01"; break;
                        case 'b': currentSequence = "0|010"; break;
                        default: return false;
                    }
                }
                else
                {
                    currentSequence += c;
                }
            }
            if (currentSequence.Contains("0|0"))
            {
                hasZeroPipeZero = true;
            }

            string[] parts = currentSequence.Split('|');
            if (parts.Length != 2) return false;

            string left = parts[0];
            string right = parts[1];


            bool partsEqual = ProcessAndCompareParts(left, right);

            return equalityCriterion ?
                partsEqual :         
                hasZeroPipeZero;     
        }

        private bool ProcessAndCompareParts(string left, string right)
        {
            int leftSum = CalculateSum(left);
            int rightSum = CalculateSum(right);

            return leftSum == rightSum;
        }

        private int CalculateSum(string part)
        {
            int sum = 0;
            foreach (char c in part)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0';
                }
            }
            return sum;
        }
    }
}
