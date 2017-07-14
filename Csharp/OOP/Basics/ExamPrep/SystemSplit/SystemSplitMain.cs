using System;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    class Program
    {
        static void Solution(string[] args)
        {
            var system = new System();
           
            while (true)
            {
                var input = Console.ReadLine().Trim();

                if (input.Equals("System Split", StringComparison.OrdinalIgnoreCase))
                    break;

                if (input.Equals("Analyze()", StringComparison.OrdinalIgnoreCase))
                {
                    system.Analyze();
                    continue;
                }

                if (input.Equals("DumpAnalyze()", StringComparison.OrdinalIgnoreCase))
                {
                    system.Dumpster.Analyze();
                    continue;
                }

                try
                {
                    Executor.Execute(input, system);
                }
                catch (Exception)
                {
                    // ignore
                }
                
            }

            Console.WriteLine(system);
        }

       
    }
}
