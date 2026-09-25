public class Solution {
    public int LongestMonotonicSubarray(int[] arr) {
        int counter=0;
        int c=0;
        int mx=0;
        for(int i=0; i<arr.Length-1; i++){
            if(arr[i]>arr[i+1])
            {
                counter++;
                if(counter>mx)
                {
                    mx=counter;
                }
            }
            else
            {
                counter=0;
            }
        }

        for(int i=0; i<arr.Length-1;i++){
            if(arr[i]<arr[i+1])
            {
                c++;
                if(c>mx)
                {
                    mx=c;
                }
            }
            else
            {
                c=0;
            }
        }
        
        return mx+1;
    }
}