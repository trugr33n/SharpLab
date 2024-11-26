using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Services
{
    public class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName) {

            if (value.Length > maxLength)
            {
                MessageBox.Show($"В {propertyName} должно быть меньше {maxLength} символов.");
                throw new ArgumentException($"В {propertyName} должно быть меньше {maxLength} символов.");
            }
        }
    }
}
