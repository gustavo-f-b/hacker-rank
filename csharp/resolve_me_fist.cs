using System;
using System.Collections.Generic;
using System.IO;

class Solution {

    static int solveMeFirst(int a, int b) => a + b;

    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        
        bool val1Limit = val1 <= 1 || val1 <= 1000;
        bool val2Limit = val2 <= 1 || val2 <= 1000;
         
        if(val1Limit && val2Limit)
        {
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
    }
}      
