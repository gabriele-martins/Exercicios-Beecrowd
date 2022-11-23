using System;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int[] x=new int[n];
        string[] input=Console.ReadLine().Split();
        for(int i=0; i<n; i++){
            x[i]=int.Parse(input[i]);
        }
        Console.WriteLine("Menor valor: {0}", x.Min());
        Console.WriteLine("Posicao: {0}", Array.IndexOf(x,x.Min()));
    }
}