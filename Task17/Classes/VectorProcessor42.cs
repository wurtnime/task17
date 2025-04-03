using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor42
    {
        public VectorProcessor42() { }
        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0;
            int sum = 0;
            int max = 0;

            foreach (char symbol in input)
            {
                string binaryValue = "";
                int value = 0;

                switch (symbol)
                {
                    case 'a':
                        binaryValue = "110";
                        value = 1;
                        break;
                    case 'b':
                        binaryValue = "010";
                        value = 2;
                        break;
                    case 'c':
                        binaryValue = "010";
                        value = 3;
                        break;
                    default:
                        return false;
                }

                foreach (char bit in binaryValue)
                {
                    int bitValue = bit - '0';
                    sum += bitValue;
                    max = Math.Max(max, bitValue);

                    switch (state)
                    {
                        case 0:
                            state = (bitValue == 0) ?
                                (clockwise ? 1 : 2) :
                                (clockwise ? 2 : 1);
                            break;
                        case 1:
                            state = (bitValue == 0) ?
                                (clockwise ? 2 : 0) :
                                (clockwise ? 0 : 2);
                            break;
                        case 2:
                            state = (bitValue == 0) ?
                                (clockwise ? 0 : 1) :
                                (clockwise ? 1 : 0);
                            break;
                    }
                }
            }

            return sumCriterion ?
                sum % 5 == 0 :
                max == 1 && state == 0;
        }
    }
}
