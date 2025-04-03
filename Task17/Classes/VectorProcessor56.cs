using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor56
    {
        public VectorProcessor56() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool sumCriterion)
        {
            int state = 0;
            int bitSum = 0;
            int maxOnesSequence = 0;
            int currentOnes = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {

                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "111"; break;
                        case 'b': currentSequence = "0100"; break;
                        case 'c': currentSequence = "1101"; break;
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


                    if (bitValue == 1)
                    {
                        currentOnes++;
                        maxOnesSequence = Math.Max(maxOnesSequence, currentOnes);
                    }
                    else
                    {
                        currentOnes = 0;
                    }

                    switch (state)
                    {
                        case 0:
                            state = (bitValue == 0) ?
                                (clockwise ? 1 : 3) :
                                (clockwise ? 2 : 1);
                            break;
                        case 1:
                            state = (bitValue == 0) ?
                                (clockwise ? 3 : 0) :
                                (clockwise ? 0 : 2);
                            break;
                        case 2:
                            state = (bitValue == 0) ?
                                (clockwise ? 0 : 3) :
                                (clockwise ? 1 : 0);
                            break;
                        case 3:
                            state = (bitValue == 0) ?
                                (clockwise ? 2 : 1) :
                                (clockwise ? 3 : 2);
                            break;
                    }
                }

                currentSequence = "";
            }

            if (sumCriterion)
                return bitSum % 4 == 0; 
            else
                return maxOnesSequence >= 3; 
        }
    }
}
