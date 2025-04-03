using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor59
    {
        public VectorProcessor59() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool stateChangeCriterion)
        {
            int state = 0;
            int stateChanges = 0;
            int onesCount = 0;
            int prevState = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "011"; break;
                        case 'b': currentSequence = "110"; break;
                        case 'c': currentSequence = "0101"; break;
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
                    if (bitValue == 1) onesCount++;

                    prevState = state;
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

                    if (state != prevState) stateChanges++;
                }

                currentSequence = "";
            }

            return stateChangeCriterion ?
                stateChanges % 3 == 0 : 
                onesCount % 2 == 0;    
        }
    }
}
