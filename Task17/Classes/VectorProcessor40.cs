using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor40
    {
        public VectorProcessor40() { }

        public bool IsAccepted(string input, bool symbolMode, bool parityCriterion)
        {
            int state = 0;
            int sum = 0;
            string binaryBuffer = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (c)
                    {
                        case 'a':
                            binaryBuffer = "010";
                            sum += 1;
                            break;
                        case 'b':
                            binaryBuffer = "110";
                            sum += 3;
                            break;
                        default:
                            return false;
                    }
                }
                else
                {
                    if (c != '0' && c != '1') return false;
                    binaryBuffer += c;

                    if (binaryBuffer.Length == 3)
                    {
                        sum += Convert.ToInt32(binaryBuffer, 2);
                        binaryBuffer = "";
                    }
                }

                foreach (char bit in binaryBuffer)
                {
                    int bitValue = bit - '0';
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
            }

            if (parityCriterion)
                return sum % 2 == 0;
            else
                return state == 0 && binaryBuffer == "";
        }
    }
}
