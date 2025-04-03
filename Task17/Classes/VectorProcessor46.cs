using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor46
    {
        public VectorProcessor46() { }

        public bool IsAccepted(string input, bool symbolMode, bool sumCriterion)
        {
            int state = 0;
            int bitSum = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a': currentSequence = "0101"; break;
                        case 'b': currentSequence = "0100"; break;
                        case 'c': currentSequence = "0110"; break;
                        default: return false;
                    }
                }
                else
                {

                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }

                foreach (char bit in currentSequence)
                {
                    int bitValue = bit - '0';
                    bitSum += bitValue;

                    switch (state)
                    {
                        case 0:
                            state = (bitValue == 0) ? 1 : 2;
                            break;
                        case 1:
                            state = (bitValue == 0) ? 3 : 0;
                            break;
                        case 2:
                            state = (bitValue == 0) ? 0 : 3;
                            break;
                        case 3:
                            state = (bitValue == 0) ? 2 : 1;
                            break;
                    }
                }

                currentSequence = "";
            }

            if (sumCriterion)
                return bitSum % 4 == 0; 
            else
                return state == 0; 
        }
    }
}
