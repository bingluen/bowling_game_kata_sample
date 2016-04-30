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
     /*       for (int i = 0; i < pins.Count ;i++ )
            {
                if (pins[i] == 10 && pins[i+2] != 10 )
                    score += pins[i] + pins[i + 2] + pins[i + 3];
                else if( pins[i] == 10 ) // 連續兩球strike
                    score += pins[i] + pins[i + 2] + pins[i + 4];
                else
                    score += pins[i];
            }
            */

            for (int i = 0; i < pins.Count; i++)
            {
                score += pins[i].first + pins[i].second;    
            }


                return score;
        }
    }
}
