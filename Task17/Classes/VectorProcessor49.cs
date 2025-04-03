using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor49
    {
        public VectorProcessor49() { }


        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0;
            int sum = 0;
            int max = 0;

            foreach (char bit in input)
            {
                if (bit != '0' && bit != '1') return false;

                int bitValue = bit - '0';
                sum += bitValue;
                max = Math.Max(max, bitValue);

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

            if (sumCriterion)
                return sum % 4 == 0; 
            else
                return max == 1 && state == 0; 
        }
    }
}
