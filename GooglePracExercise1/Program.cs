using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GooglePracExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Problem> problemList = new List<Problem>();
            using (var stream = new StreamReader(new FileStream(@"D:\temp\Google\A-small-practice.in", FileMode.Open)))
            {
                var numCases = int.Parse(stream.ReadLine());

                for (int i = 0; i < numCases; ++i)
                {
                    var prob = new Problem();
                    var caseInfo = stream.ReadLine().Split(' ');

                    prob.NumberOfOutlets = int.Parse(caseInfo[0]);
                    prob.NumberOfSwitches = int.Parse(caseInfo[1]);

                    prob.masterState = stream.ReadLine().Split(' ').ToList();
                    prob.neededState = stream.ReadLine().Split(' ').ToList();

                    problemList.Add(prob);
                }
            }

            for (int i = 0; i < problemList.Count; i++)
            {
                var res = problemList[i].Run();
                if (res >= 0)
                {
                    Console.WriteLine("Case #{0}: " + res, i + 1);
                }
                else
                {
                    Console.WriteLine("Case #{0}: NOT POSSIBLE", i + 1);
                }
            }

            Console.ReadLine();
        }
    }
}
