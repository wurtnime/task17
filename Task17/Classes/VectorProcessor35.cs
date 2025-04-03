using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor35
    {
        public VectorProcessor35() { }

        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0; // Начальное состояние
            int sum = 0;
            int max = 0;

            foreach (char symbol in input)
            {
                int value = 0;
                switch (symbol)
                {
                    case 'a': value = 1; break;
                    case 'b': value = 2; break;
                    case 'c': value = 3; break;
                    case 'd': value = 4; break;
                    default: return false;
                }

                sum += value;
                max = Math.Max(max, value);

                switch (state)
                {
                    case 0:
                        if (symbol == 'a')
                            state = 1;
                        else if (symbol == 'b')
                            state = clockwise ? 1 : 3;
                        else if (symbol == 'c')
                            state = 2;
                        else if (symbol == 'd')
                            state = clockwise ? 2 : 1;
                        break;
                    case 1:
                        if (symbol == 'a')
                            state = 2;
                        else if (symbol == 'b')
                            state = 0;
                        else if (symbol == 'c')
                            state = clockwise ? 0 : 2;
                        else if (symbol == 'd')
                            state = 3;
                        break;
                    case 2:
                        if (symbol == 'a' || symbol == 'b')
                            state = 1;
                        else if (symbol == 'c')
                            state = 2;
                        else if (symbol == 'd')
                            state = clockwise ? 1 : 0;
                        break;
                    case 3:
                        if (symbol == 'a' || symbol == 'd')
                            state = 1;
                        else if (symbol == 'b' || symbol == 'c')
                            state = 2;
                        break;
                }
            }

            if (sumCriterion)
                return sum % 7 == 0; 
            else
                return max == 4 && state == 1; 
        }
    }
}
