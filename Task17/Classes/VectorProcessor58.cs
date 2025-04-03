using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor58
    {
        public VectorProcessor58() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool pairCriterion)
        {
            int state = 0;
            int zeroOnePairs = 0;
            bool validPattern = true;
            int prevBit = -1;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "011"; break;
                        case 'b': currentSequence = "1110"; break;
                        case 'c': currentSequence = "1100"; break;
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

                    if (prevBit == 0 && bitValue == 1)
                    {
                        zeroOnePairs++;
                    }
                    prevBit = bitValue;

                    int prevState = state;
                    switch (state)
                    {
                        case 0:
                            state = (bitValue == 0) ?
                                (clockwise ? 1 : 3) :
                                (clockwise ? 2 : 1);
                            break;
                        case 1:
                            if (bitValue != 1) validPattern = false;
                            state = clockwise ? 2 : 0;
                            break;
                        case 2:
                            state = (bitValue == 0) ?
                                (clockwise ? 3 : 1) :
                                (clockwise ? 0 : 3);
                            break;
                        case 3:
                            if (bitValue != 0) validPattern = false;
                            state = clockwise ? 1 : 2;
                            break;
                    }

                    if (state == prevState)
                    {
                        validPattern = false;
                    }
                }

                currentSequence = "";
            }

            return pairCriterion ?
                zeroOnePairs % 2 == 1 : 
                validPattern && state == 0; 
        }
    }
}
