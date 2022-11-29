using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int cartas=int.Parse(Console.ReadLine());
        List<int> valores=Console.ReadLine().Split().ToList().ConvertAll(int.Parse);
        for(int i=0; i<valores.Count-1; i++){
            if(valores[i]>=valores[i+1]){
                valores.RemoveAt(i+1);
            }
        }
        for(int i=0; i<valores.Count-1; i++){
            if(valores[i]>=valores[i+1]){
                valores.RemoveAt(i+1);
            }
        }
        Console.WriteLine(valores.Count);
    }
}