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
            using (var stream = new StreamReader(new FileStream(@"C:\temp\Google\A-small-practice.in", FileMode.Open)))
            {
                var numCases = int.Parse(stream.ReadLine());

                for (int i = 0; i < numCases; ++i)
                {
                    var prob = new Problem();
                    var caseInfo = stream.ReadLine().Split(' ');

                    prob.NumberOfOutlets = int.Parse(caseInfo[0]);
                    prob.NumberOfSwitches = int.Parse(caseInfo[1]);

                    prob.currentState = stream.ReadLine().Split(' ').ToList();
                    prob.neededState = stream.ReadLine().Split(' ').ToList();

                    problemList.Add(prob);
                }
            }

            foreach (var pro in problemList)
            {
                pro.Run();
            }

            var ere = 1;
        }
    }
}
