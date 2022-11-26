using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] nomes=new string[n];
        int comportada=0, bagunceira=0;
        for(int i=0; i<n; i++){
            nomes[i]=Console.ReadLine();
            if(nomes[i].Contains("+ ")){
                nomes[i]=nomes[i].Remove(0,2);
                comportada++;
            }
            else if(nomes[i].Contains("- ")){
                nomes[i]=nomes[i].Remove(0,2);
                bagunceira++;
            }
        }
        Array.Sort(nomes);
        for(int i=0; i<n; i++){
            Console.WriteLine(nomes[i]);
        }
        Console.WriteLine("Se comportaram: {0} | Nao se comportaram: {1}",comportada,bagunceira);
    }
}