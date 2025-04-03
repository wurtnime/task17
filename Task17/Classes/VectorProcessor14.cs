using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor14
    {
        private readonly int[,] _matrix;
        private readonly bool _clockwise;
        private readonly bool _compareBySum;

        public VectorProcessor14()
        {
        }

        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0; 
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
                    default: return false; 
                }

                sum += value;
                max = Math.Max(max, value);

                switch (state)
                {
                    case 0:
                        if (symbol == 'a')
                            state = clockwise ? 1 : 2;
                        else if (symbol == 'b')
                            state = 1;
                        else if (symbol == 'c')
                            state = 2;
                        break;
                    case 1:
                        if (symbol == 'a')
                            state = 0;
                        else if (symbol == 'b')
                            state = clockwise ? 2 : 0;
                        else if (symbol == 'c')
                            state = 1;
                        break;
                    case 2:
                        if (symbol == 'a' || symbol == 'b')
                            state = 1;
                        else if (symbol == 'c')
                            state = 2;
                        break;
                }
            }

            if (sumCriterion)
                return sum % 6 == 0;
            else
                return max == 3 || state == 1;
        }
    }
}
