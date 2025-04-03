using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor63
    {
        public VectorProcessor63() { }


        public bool IsAccepted(string input, bool symbolMode, bool stateCriterion)
        {
            int state = 0;
            bool hasVerticalBar = false;
            string currentSequence = "";

            foreach (char c in input)
            {
                if (symbolMode)
                {
                    switch (char.ToLower(c))
                    {
                        case 'a': currentSequence = "210"; break;
                        case 'b': currentSequence = "11|02"; break;
                        default: return false;
                    }
                }
                else
                {
                    if (c == '|')
                    {
                        hasVerticalBar = true;
                        continue;
                    }
                    if (c != '0' && c != '1' && c != '2') return false;
                    currentSequence += c;
                }

                foreach (char symbol in currentSequence)
                {
                    if (symbol == '|')
                    {
                        hasVerticalBar = true;
                        continue;
                    }

                    int inputValue = symbol - '0';

                    switch (state)
                    {
                        case 0:
                            state = inputValue switch
                            {
                                0 => 0,
                                1 => 2,
                                2 => 1,
                                _ => state
                            };
                            break;
                        case 1:
                            state = inputValue switch
                            {
                                0 => 2,
                                1 => 0,
                                2 => 2,
                                _ => state
                            };
                            break;
                        case 2:
                            state = inputValue switch
                            {
                                0 => 1,
                                1 => 2,
                                2 => 0,
                                _ => state
                            };
                            break;
                    }
                }

                currentSequence = "";
            }

            return stateCriterion ?
                state == 2 :
                hasVerticalBar; 
        }
    }
}
