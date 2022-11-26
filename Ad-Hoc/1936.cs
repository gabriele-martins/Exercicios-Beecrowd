using System;
using System.Collections.Generic;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int k=0;
        int[] fatoriais={40320, 5040, 720, 120, 24, 6, 2, 1};
        for(int i=0; i<8; i++){
            k+=n/fatoriais[i];
            n%=fatoriais[i];
        }
        Console.WriteLine(k);
    }
}