// C# program to demonstrate working
// of Chinise remainder Theorem
using System;
 
class GFG
{
     
    // k is size of num[] and rem[].
    // Returns the smallest
    // number x such that:
    // x % num[0] = rem[0],
    // x % num[1] = rem[1],
    // ..................
    // x % num[k-2] = rem[k-1]
    // Assumption: Numbers in num[]
    // are pairwise coprime
    // (gcd for every pair is 1)
    static int findMinX(int []num, int []rem,
                        int k)
    {
         
        // Initialize result
        int x = 1;
     
        // As per the Chinese remainder theorem,
        // this loop will always break.
        while (true)
        {
            // Check if remainder of x % num[j] is
            // rem[j] or not (for all j from 0 to k-1)
            int j;
            for (j = 0; j < k; j++ )
                if (x % num[j] != rem[j])
                break;
     
            // If all remainders matched, we found x
            if (j == k)
                return x;
     
            // Else try next number
            x++;
        }
     
    }
     
    // Driver code
    public static void Main()
    {
        int []num = {3, 4, 5};
        int []rem = {2, 3, 1};
        int k = num.Length;
        Console.WriteLine("x is " + findMinX(num,
                                        rem, k));
    }
}