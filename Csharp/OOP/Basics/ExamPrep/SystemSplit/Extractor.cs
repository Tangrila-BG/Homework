using System;
using System.Text.RegularExpressions;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    class Extractor
    {
        public string[] ExtractHardwareParams(string input)
        {
            var output = new string[4];
            output[0] = Regex.Split(input, @"(?=[A-Z])",
                RegexOptions.IgnorePatternWhitespace)[2].ToLowerInvariant();

            var start = input.IndexOf("(") + 1;
            var end = input.IndexOf(")");

            var para = input.Substring(start, end - start)
                .Split(new string[] { ", " }, StringSplitOptions.None);

            for (int i = 0; i < 3; i++)
                output[i + 1] = para[i];

            return output;
        }

        public string[] ExtractSoftwareParams(string input)
        {
            var output = new string[5];

            output[0] = Regex.Split(input, @"(?=[A-Z])",
                RegexOptions.IgnorePatternWhitespace)[2].ToLowerInvariant();

            var start = input.IndexOf("(") + 1;
            var end = input.IndexOf(")");

            var para = input.Substring(start, end - start)
                .Split(new string[] { ", " }, StringSplitOptions.None);

            for (int i = 0; i < 4; i++)
                output[i + 1] = para[i];

            return output;
        }

        public string[] ExtractParams(string input)
        {
            var start = input.IndexOf("(") + 1;
            var end = input.IndexOf(")");

            var para = input.Substring(start, end - start)
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            return para;
        }
    }
}
