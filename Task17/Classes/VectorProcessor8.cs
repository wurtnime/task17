using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor8
    {
        private readonly int[,] _matrix;
        private readonly bool _clockwise;
        private readonly bool _compareBySum;

        public VectorProcessor8(int[,] matrix, bool clockwise, bool compareBySum)
        {
            _matrix = matrix;
            _clockwise = clockwise;
            _compareBySum = compareBySum;
        }

        public bool IsAccepted(string input, bool clockwise, bool sumCriterion)
        {
            int state = 0; 
            int sum = 0;
            int max = 0;

            foreach (char symbol in input)
            {
                int value = symbol == 'a' ? 1 : 2; 
                sum += value;
                max = Math.Max(max, value);

                switch (state)
                {
                    case 0:
                        if (symbol == 'a')
                            state = clockwise ? 1 : 2;
                        else if (symbol == 'b')
                            state = clockwise ? 2 : 1;
                        break;
                    case 1:
                        if (symbol == 'a')
                            state = 0;
                        else if (symbol == 'b')
                            state = 1;
                        break;
                    case 2:
                        if (symbol == 'a')
                            state = 2;
                        else if (symbol == 'b')
                            state = 0;
                        break;
                }
            }

            if (sumCriterion)
                return sum % 5 == 0;
            else
                return max == 2 && state == 1; 
        }
    }
}
