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
        public List<string> masterState { get; set; }
        public List<string> neededState { get; set; }

        public int Run()
        {
            List<string> temp = new List<string>(masterState);
            List<int> answers = new List<int>();
            List<int> used = new List<int>();

            findAnswer(temp, answers, used);

            if (answers.Count <= 0)
                return -1;

            return answers.Min();
        }

        public void findAnswer(List<string> currentState, List<int> answers, List<int> used)
        {
            List<string> master = new List<string>(currentState);
            int index = 0;

            if(!(answers.Any() && answers.Min() < used.Count))
            {
                if (powerMatch(currentState, neededState))
                {
                    answers.Add(used.Count);
                }

                while (index < NumberOfSwitches)
                {
                    List<int> tempUsed = new List<int>(used);
                    tempUsed.Add(index);
                    findAnswer(Not(master, index), answers, tempUsed);
                    ++index;
                }
            }
        }

        private List<string> Not(List<string> inString, int index)
        {
            List<string> newStrings = new List<string>();
            
            foreach (var str in inString)
            {
                List<char> newStringList = new List<char>();
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == index)
                    {
                        if (str[i] == '0')
                        {
                            newStringList.Add('1');
                        }

                        if (str[i] == '1')
                        {
                            newStringList.Add('0');
                        }
                    }
                    else
                    {
                        newStringList.Add(str[i]);
                    }
                }
                newStrings.Add(new String(newStringList.ToArray()));
            }

            return newStrings;
        }

        private bool powerMatch(List<string> current, List<string> target)
        {
            foreach (var test in current)
            {
                if (!target.Contains(test))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
