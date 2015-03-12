using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GooglePracExercise1
{
    class Problem
    {
        public int NumberOfSwitches { get; set; }
        public int NumberOfOutlets { get; set; }
        public List<string> currentState { get; set; }
        public List<string> neededState { get; set; }

        public void Run()
        {
            foreach (var curr in currentState)
            {
                var not = Not(curr);
            }
        }

        private string Not(string inString)
        {
            List<char> newStringList = new List<char>();
            foreach(var currChar in inString)
            {
                if (currChar == '0')
                {
                    newStringList.Add('1');
                }

                if (currChar == '1')
                {
                    newStringList.Add('0');
                }
            }

            return new string(newStringList.ToArray());
        }
    }
}
