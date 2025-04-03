using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor48
    {
        public VectorProcessor48() { }


        public bool IsAccepted(string input, bool symbolMode, bool parityCriterion)
        {
            int state = 0;
            int onesCount = 0;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a':
                            currentSequence = "0101";
                            break;
                        case 'b':
                            currentSequence = "0100";
                            break;
                        case 'c':
                            currentSequence = "0110";
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
                    onesCount += bitValue;

                    state = (state, bitValue) switch
                    {
                        (0, 0) => 1,
                        (0, 1) => 2,
                        (1, 0) => 3,
                        (1, 1) => 0,
                        (2, 0) => 1,
                        (2, 1) => 3,
                        (3, 0) => 2,
                        (3, 1) => 0,
                        _ => state
                    };
                }

                currentSequence = "";
            }

            if (parityCriterion)
                return onesCount % 2 == 0; 
            else
                return state == 0; 
        }
    }
}
