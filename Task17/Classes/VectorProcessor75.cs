using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor75
    {
        public VectorProcessor75() { }
        public bool IsAccepted(string input, bool symbolMode, bool contains101Criterion)
        {
            string currentSequence = "";
            bool has101 = false;
            int zeroCount = 0;
            int oneCount = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "011101"; break;
                        case 'b': currentSequence = "00101"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }
            }


            has101 = currentSequence.Contains("101");

            foreach (char bit in currentSequence)
            {
                if (bit == '0') zeroCount++;
                else if (bit == '1') oneCount++;
            }

            bool isBalanced = Math.Abs(zeroCount - oneCount) <= 1;

            return contains101Criterion ?
                has101 :           
                isBalanced;         
        }
    }
}
