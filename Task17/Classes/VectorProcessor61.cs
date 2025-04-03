using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor61
    {
        public VectorProcessor61() { }

        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool sumCriterion)
        {
            int state = 0;
            int bitSum = 0;
            bool hasSpecialSymbol = false;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "01010"; break;
                        case 'b': currentSequence = "11110"; break;
                        case 'c': currentSequence = "0110"; break;
                        case 'd': currentSequence = "11Ø"; break;
                        case 'e': currentSequence = "010"; break;
                        case 'f': currentSequence = "111"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c == 'Ø')
                    {
                        hasSpecialSymbol = true;
                        continue;
                    }
                    if (c != '0' && c != '1') return false;
                    currentSequence += c;
                }

                foreach (char bit in currentSequence)
                {
                    if (bit == 'Ø')
                    {
                        hasSpecialSymbol = true;
                        continue;
                    }

                    int bitValue = bit - '0';
                    bitSum += bitValue;


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

            return sumCriterion ?
                bitSum % 4 == 0 : 
                hasSpecialSymbol;  
        }
    }
}

