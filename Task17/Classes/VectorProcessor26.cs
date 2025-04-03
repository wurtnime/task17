using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor26
    {
        public VectorProcessor26() { }

        public bool IsAccepted(string input)
        {
            int state = 0; 
            bool hasC = false;

            foreach (char symbol in input)
            {
                switch (state)
                {
                    case 0:
                        if (symbol == 'a') state = 1;
                        else if (symbol == 'b') state = 1;
                        else if (symbol == 'c') { state = 2; hasC = true; }
                        else return false;
                        break;
                    case 1:
                        if (symbol == 'a') state = 0;
                        else if (symbol == 'b') state = 0;
                        else if (symbol == 'c') { state = 2; hasC = true; }
                        else return false;
                        break;
                    case 2:
                        if (symbol == 'a' || symbol == 'b') state = 1;
                        else if (symbol == 'c') { state = 2; hasC = true; }
                        else return false;
                        break;
                }
            }

            return (state == 0 || state == 1) && hasC;
        }
    }
}
