using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor55
    {
        public VectorProcessor55() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool zeroCountCriterion)
        {
            int state = 0;
            int zeroCount = 0;
            bool validPattern = true;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a': currentSequence = "0100"; break;
                        case 'b': currentSequence = "01001"; break;
                        case 'c': currentSequence = "0111"; break;
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
                    if (bitValue == 0) zeroCount++;

                    int prevState = state;
                    switch (state)
                    {
                        case 0:
                            state = (bitValue == 0) ?
                                (clockwise ? 1 : 3) :
                                (clockwise ? 2 : 1);
                            break;
                        case 1:
                            if (bitValue != 0) validPattern = false;
                            state = clockwise ? 3 : 0;
                            break;
                        case 2:
                            state = (bitValue == 0) ?
                                (clockwise ? 0 : 3) :
                                (clockwise ? 1 : 0);
                            break;
                        case 3:
                            if (bitValue != 1) validPattern = false;
                            state = clockwise ? 2 : 1;
                            break;
                    }

                    if (prevState == state && currentSequence != "")
                    {
                        validPattern = false;
                    }
                }

                currentSequence = "";
            }

            return zeroCountCriterion ?
                zeroCount % 3 == 0 :  
                validPattern && state == 0;  
        }
    }
}
