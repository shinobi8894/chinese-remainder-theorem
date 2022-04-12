// A javascript program to demonstrate the working of Chinese remainder
// Theorem
    
// k is size of num and rem.  Returns the smallest
// number x such that:
//  x % num[0] = rem[0],
//  x % num[1] = rem[1],
//  ..................
//  x % num[k-2] = rem[k-1]
// Assumption: Numbers in num are pairwise coprime
// (gcd for every pair is 1)
function findMinX(num , rem , k)
{
    var x = 1; // Initialize result
  
    // As per the Chinese remainder theorem,
    // this loop will always break.
    while (true)
    {
        // Check if remainder of x % num[j] is
        // rem[j] or not (for all j from 0 to k-1)
        var j;
        for (j=0; j<k; j++ )
            if (x%num[j] != rem[j])
               break;
  
        // If all remainders matched, we found x
        if (j == k)
            return x;
  
        // Else try next number
        x++;
    }
  
}
  
// Driver method
var num = [3, 4, 5];
var rem = [2, 3, 1];
var k = num.length;
document.write("x is " + findMinX(num, rem, k));
 