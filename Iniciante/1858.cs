using System;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] tStr=Console.ReadLine().Split();
        int[] t=new int[n];
        for(int i=0; i<n; i++){
            t[i]=int.Parse(tStr[i]);
        }
        Console.WriteLine(Array.IndexOf(t,t.Min())+1);
    }
}