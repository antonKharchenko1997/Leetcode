public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int count = 0, sum = 0;
        
        for(var i = 0;i<arr.Length;i++){
            sum += arr[i];
            if(i>=k) sum -= arr[i-k];
            if(i>= k - 1 && sum >= threshold * k) count++;
        }
        
        return count;
    }
}