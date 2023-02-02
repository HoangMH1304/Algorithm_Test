using System;

class Ex3
{
    private static int MaximumNonAdj(int[] arr, int n)
    {
        int[] dp = new int[n];
        dp[0] = arr[0];
        dp[1] = Math.Max(arr[0], arr[1]);
        for(int i = 2; i < n ; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + arr[i], dp[i - 1]);
        }
        return dp[n - 1];
    }
    
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine(MaximumNonAdj(arr, n));
    }
}