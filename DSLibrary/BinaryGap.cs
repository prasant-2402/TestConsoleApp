using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary
{
    public static class BinaryGap
    {
        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
        /// that is surrounded by ones at both ends in the binary representation of N.
        /// For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
        /// The number 529 has binary representation 1000010001 and contains two binary gaps:
        /// one of length 4 and one of length 3. 
        /// The number 20 has binary representation 10100 and contains one binary gap of length 1. 
        /// The number 15 has binary representation 1111 and has no binary gaps.
        /// The number 32 has binary representation 100000 and has no binary gaps.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int Distance (int input)
        {
            string binaryValue = Convert.ToString (input, 2);
            int positionOfFirst1 = binaryValue.IndexOf ('1');
            int positionofSecond1 = binaryValue.IndexOf ('1', (positionOfFirst1 + 1));
            
            return ((positionofSecond1 - positionOfFirst1) - 1) < 0 ? 0 : ((positionofSecond1 - positionOfFirst1) - 1);
        }

        public static string ToString(this int input)
        {
            return string.Format("{0} has a binary gap of {1}", input, Distance(input));
        }
    }
}
