using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
    var ret = A.Length+1;

    for (var index = 0; index < A.Length; index++)
    {
        if (A[index] != index+1)
        {
            return index+1;
        }
    }

    return ret; 
    }
}
