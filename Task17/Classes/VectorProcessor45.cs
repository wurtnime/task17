using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor45
    {
        public VectorProcessor45() { }

        public bool IsAccepted(string input, bool symbolMode, bool zeroCountCriterion)
        {
            int state = 0;
            int zeroCount = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a':
                            currentSequence = "11000";
                            break;
                        case 'b':
                            currentSequence = "0111";
                            break;
                        case 'c':
                            currentSequence = "11101";
                            break;
                        default:
                            return false;
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

                    state = (state, bitValue) switch
                    {
                        (0, 0) => 1,
                        (0, 1) => 2,
                        (1, 0) => 3,
                        (1, 1) => 0,
                        (2, 0) => 3,
                        (2, 1) => 1,
                        (3, 0) => 2,
                        (3, 1) => 0,
                        _ => state
                    };
                }

                currentSequence = "";
            }

            if (zeroCountCriterion)
                return zeroCount % 3 == 0; 
            else
                return state == 0;
        }
    }
}
