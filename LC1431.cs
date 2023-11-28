namespace LeetCodeNew
{
    internal class LC1431
    {
        public LC1431()
        {
            Console.WriteLine(string.Join(",", KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3)));
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int largest = candies.Max();
            bool[] bools = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                if (largest < candies[i]) largest = candies[i];
                if (candies[i] + extraCandies >= largest)
                {
                    bools[i] = true;
                }
                else
                {
                    bools[i] = false;
                }
            }
            return bools;
        }
    }
}
