using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada, int.Parse);
        Console.WriteLine(valores.Max());
    }
}