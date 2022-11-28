using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int n=int.Parse(input[0]);
        int saldoInicial=int.Parse(input[1]);
        List<int> valores=new List<int>();
        for(int i=0; i<n; i++){
            int x=int.Parse(Console.ReadLine());
            saldoInicial+=x;
            valores.Add(saldoInicial);
        }
        Console.WriteLine(valores.Min());
    }
}