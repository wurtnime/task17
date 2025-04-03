using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Classes
{
    public class VectorProcessor74
    {
        private readonly Dictionary<char, int> _letterValues = new Dictionary<char, int>
    {
        {'a', 1}, {'b', 2}, {'0', 0}, {'1', 1} 
    };

        public VectorProcessor74() { }

        public bool IsAccepted(string sequence, bool clockwise, bool useAverage)
        {
            if (string.IsNullOrEmpty(sequence))
                return false;

            List<int> values = new List<int>();
            foreach (char c in sequence)
            {
                if (_letterValues.TryGetValue(c, out int value))
                    values.Add(value);
                else
                    return false;
            }

            bool directionValid = true;
            for (int i = 0; i < values.Count - 1; i++)
            {
                int diff = values[i + 1] - values[i];
                if (clockwise && diff <= 0)
                    directionValid = false;
                else if (!clockwise && diff >= 0)
                    directionValid = false;
            }

            if (useAverage)
            {
                double average = values.Average();
                return directionValid && average >= 1.0; 
            }
            else
            {
                int max = values.Max();
                return directionValid && max >= 1; 
            }
        }
    }
}
