public class Solution {
    public int FindPairs(int[] nums, int k) {
            if (k < 0)
                return 0;
        
            int result = 0;
            System.Collections.Hashtable hash = new System.Collections.Hashtable();

            foreach (var item in nums)
                if (!hash.ContainsKey(item))
                    hash.Add(item, 1);
                else
                    hash[item] = (int)hash[item] + 1;

            foreach (var item in hash.Keys)
                if (k == 0)
                {
                    if ((int)hash[item] > 1)
                        result++;
                }
                else if (hash.ContainsKey((int)item + k))
                    result++;

            return result;
    }
}