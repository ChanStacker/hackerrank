using System;

namespace NewYearQueue
{
    public class Program
    {
        public string Solution(int[] newYearQueue)
        {
            var countBribe = 0;

            for(var i = 0; i < newYearQueue.Length; i++)
            {
                if (newYearQueue[i] > i + 1)
                {
                    var diff = newYearQueue[i] - (i + 1);
                    if (diff > 2)
                        return "Too Chaotic";
                    countBribe += diff;
                }
            }

            return countBribe.ToString();
        }
    }
}
