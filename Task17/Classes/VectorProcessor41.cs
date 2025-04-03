using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor41
    {

        public VectorProcessor41() { }

        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0; 
            int sum = 0;
            int max = 0;

            foreach (char symbol in input)
            {
                int value = symbol - 'a' + 1; 
                sum += value;
                max = Math.Max(max, value);

                switch (state)
                {
                    case 0:
                        if (value <= 2) 
                            state = clockwise ? 1 : 2;
                        else if (value <= 4) 
                            state = 1;
                        else 
                            state = 2;
                        break;
                    case 1:
                        if (value % 2 == 0) 
                            state = clockwise ? 2 : 0;
                        else 
                            state = clockwise ? 0 : 2;
                        break;
                    case 2:
                        if (value % 3 == 0) 
                            state = clockwise ? 0 : 1;
                        else
                            state = clockwise ? 1 : 0;
                        break;
                }
            }

            
            if (sumCriterion)
                return sum % 7 == 0; 
            else
                return max >= 4 && state == 1; 
        }
    }
}
