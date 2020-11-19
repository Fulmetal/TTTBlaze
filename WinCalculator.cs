using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTTBlaze
{
    public static class WinCalculator
    {
        private static List<int[]> WinningCombinations = new List<int[]>()
        {

            new int[] {1,2,3},
            new int[] {4,5,6 },
            new int[] {7,8,9 },
            new int[] {1,4,7 },
            new int[] {2,5,8 },
            new int[] {3,5,9 },
            new int[] {1,5,9 },
            new int[] {3,5,7 }
        };

        public static bool DidPlayerWin(List<int> playerCombination)
        {
            foreach (int[] i in WinningCombinations.ToArray())
            {
                if (i.Intersect(playerCombination).Count() == i.Count()) return true;
            }
            return false;
        }
    }
}
