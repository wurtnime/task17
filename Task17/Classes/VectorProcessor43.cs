using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor43
    {
        VectorProcessor43() { }

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
                        case 'b':
                            currentSequence = "0110";
                            break;
                        case 'c':
                            currentSequence = "0101";
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

               
                    switch (state)
                    {
                        case 0:
                            state = bitValue == 0 ? 1 : 2;
                            break;
                        case 1:
                            state = bitValue == 0 ? 2 : 0;
                            break;
                        case 2:
                            state = bitValue == 0 ? 0 : 1;
                            break;
                    }
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
