using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {
        public struct set
        {
            public int first;
            public int second;
            public int third;
            public bool strike;
            public set(int fir, int sec, int thir, bool s)
            {
                first = fir;
                second = sec;
                third = thir;
                strike = s;
            }
        };

        public static int GetScore(List<set> pins)
        {
            int score = 0;

            for (int i = 0; i < pins.Count; i++)
            {
                score += pins[i].first + pins[i].second;
                if (pins[i].first == 10 && pins[i+1].first != 10)
                {
                    score += pins[i + 1].first;
                    score += pins[i + 1].second;
                }
                else if (pins[i].first == 10 && pins[i+1].first == 10)
                {
                    score += pins[i + 1].first;
                    score += pins[i + 2].first;
                    score += pins[i + 2].first;
                    score += pins[i + 2].second;
                }
            }
            
            return score;
        }
    }
}
