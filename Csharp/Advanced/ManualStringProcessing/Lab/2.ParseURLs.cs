using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing.Lab
{
    public partial class ManualStringProcessingLab
    {
        public static class _2ParseURLs
        {
            public static void Solution()
            {
                var link = Regex.Split(Console.ReadLine().Trim(), "\\://");

                try
                {
                    if (link.Length > 2)
                        throw new Exception();
                    var protocol = link[0];
                    var server = link[1].Substring(0, link[1].IndexOf("/"));
                    var resources = link[1].Substring(link[1].IndexOf("/") + 1);

                    Console.WriteLine($"Protocol = {protocol}");
                    Console.WriteLine($"Server = {server}");
                    Console.WriteLine($"Resources = {resources}");

                }
                catch (Exception)
                {
                    Console.Write("Invalid URL");
                }
            }
        }
    }
}
