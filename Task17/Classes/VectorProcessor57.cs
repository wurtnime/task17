using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor57
    {
        public VectorProcessor57() { }


        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool transitionCriterion)
        {
            int state = 0;
            int zeroToOneTransitions = 0;
            bool validAlternation = true;
            int prevBit = -1;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0110"; break;
                        case 'b': currentSequence = "110"; break;
                        case 'c': currentSequence = "1111"; break;
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
                        zeroToOneTransitions++;
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

                    if (state == prevState)
                    {
                        validAlternation = false;
                    }
                }

                currentSequence = "";
            }

            return transitionCriterion ?
                zeroToOneTransitions % 2 == 0 : 
                validAlternation && state == 0; 
        }
    }
}
