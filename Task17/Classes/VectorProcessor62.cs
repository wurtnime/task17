using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor62
    {
        public VectorProcessor62() { }


        public bool IsAccepted(string input, bool symbolMode, bool clockwise, bool sumCriterion)
        {
            int state = 0;
            int digitSum = 0;
            bool hasDigit4 = false;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "0112"; break;
                        case 'b': currentSequence = "2100"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c == '4')
                    {
                        hasDigit4 = true;
                        continue;
                    }
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }

                foreach (char digit in currentSequence)
                {
                    if (digit == '4')
                    {
                        hasDigit4 = true;
                        continue;
                    }

                    int digitValue = digit - '0';
                    digitSum += digitValue;

                    switch (state)
                    {
                        case 0:
                            state = (digitValue == 0) ?
                                (clockwise ? 1 : 3) :
                                (digitValue == 1 ? (clockwise ? 2 : 1) : (clockwise ? 3 : 2));
                            break;
                        case 1:
                            state = (digitValue == 0) ?
                                (clockwise ? 3 : 0) :
                                (digitValue == 1 ? (clockwise ? 0 : 2) : (clockwise ? 2 : 3));
                            break;
                        case 2:
                            state = (digitValue == 0) ?
                                (clockwise ? 0 : 3) :
                                (digitValue == 1 ? (clockwise ? 1 : 0) : (clockwise ? 3 : 1));
                            break;
                        case 3:
                            state = (digitValue == 0) ?
                                (clockwise ? 2 : 1) :
                                (digitValue == 1 ? (clockwise ? 3 : 2) : (clockwise ? 1 : 0));
                            break;
                    }
                }

                currentSequence = "";
            }

            return sumCriterion ?
                digitSum % 3 == 0 : 
                hasDigit4;
        }
    }
}
