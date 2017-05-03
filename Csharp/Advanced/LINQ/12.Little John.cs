using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _12LittleJohn(string[] args)
        {
            int t = 4;
            
            Regex regex = new Regex(@"(>>>----->>)|(>>----->)|(>----->)");
            int small = 0;
            int medium = 0;
            int large = 0;

            var input = "";
            while (t-- > 0)
            {
                input += $" {Console.ReadLine()}";
            }
            var arrows = regex.Matches(input);

            foreach (Match arrow in arrows)
            {
                if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
                    large++;
                else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
                    medium++;
                else
                    small++;
            }
            var dec = int.Parse("" + small + medium + large);
            string binary = Convert.ToString(dec, 2);
            string binaryReversed = string.Join("", binary.ToCharArray().Reverse());
            var endBinary = binary + binaryReversed;
            var endDec = Convert.ToInt32(endBinary, 2);

            Console.WriteLine(endDec);
        }
    }
}
