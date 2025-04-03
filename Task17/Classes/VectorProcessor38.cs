using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor38
    {

        public VectorProcessor38() { }


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
                    case 'b': value = 2; break;
                    case 'c': value = 3; break;
                    default: return false;
                }

                sum += value;
                max = Math.Max(max, value);

                switch (state)
                {
                    case 0:
                        if (symbol == 'b')
                            state = clockwise ? 1 : 2;
                        else if (symbol == 'c')
                            state = 1;
                        break;
                    case 1:
                        if (symbol == 'b')
                            state = 2;
                        else if (symbol == 'c')
                            state = clockwise ? 2 : 0;
                        break;
                    case 2:
                        if (symbol == 'b')
                            state = 1;
                        else if (symbol == 'c')
                            state = 2;
                        break;
                }
            }
            if (sumCriterion)
                return sum % 5 == 0; 
            else
                return max == 3 && state == 1;
        }
    }
}
