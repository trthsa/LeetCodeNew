using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNew
{
    internal class LC605

    {
        public LC605()
        {
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0 }, 2));
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            int length = flowerbed.Length;

            for (int i = 0; i < length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool prev = (i == 0 || flowerbed[i - 1] == 0);
                    bool next = (i == length - 1 || flowerbed[i + 1] == 0);

                    if (prev && next)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }

            return count >= n;
        }
    }
}
