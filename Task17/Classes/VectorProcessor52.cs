using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor52
    {
        public VectorProcessor52() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool transitionCriterion)
        {
            int state = 0;
            int transitionCount = 0;
            string currentSequence = "";
            int prevState = 0;

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a': currentSequence = "0101"; break;
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
                    prevState = state;

                    if (clockwise)
                    {
                        switch (state)
                        {
                            case 0: state = bitValue == 0 ? 1 : 2; break;
                            case 1: state = bitValue == 0 ? 3 : 0; break;
                            case 2: state = bitValue == 0 ? 0 : 3; break;
                            case 3: state = bitValue == 0 ? 2 : 1; break;
                        }
                    }
                    else
                    {
                        switch (state)
                        {
                            case 0: state = bitValue == 0 ? 3 : 1; break;
                            case 1: state = bitValue == 0 ? 0 : 2; break;
                            case 2: state = bitValue == 0 ? 1 : 0; break;
                            case 3: state = bitValue == 0 ? 2 : 3; break;
                        }
                    }

                    if (state != prevState) transitionCount++;
                }

                currentSequence = "";
            }

            return transitionCriterion ?
                transitionCount % 3 == 0 : 
                state == 0; 
        }
    }
}
