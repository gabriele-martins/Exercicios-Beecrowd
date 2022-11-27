using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] input=Console.ReadLine().Split();
        List<int> pontos=new List<int>();
        int soma=1;
        for(int i=0; i<n-1; i++){
            if(input[i]==input[i+1]){
                soma++;
            }
            else{
                pontos.Add(soma);
                soma=1;
            }
        }
        pontos.Add(soma);
        Console.WriteLine(pontos.Max());
    }
}