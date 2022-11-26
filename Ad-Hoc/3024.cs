using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        string[] linha1=Console.ReadLine().Split();
        string[] linha2=Console.ReadLine().Split();
        int[] metros=Array.ConvertAll(linha1, int.Parse);
        int[] altitude=Array.ConvertAll(linha2, int.Parse);
        List<int> valores=new List<int>();
        valores.Add(1);
        for(int j=1; j<metros[0]; j++){
            int mirantes=1;
            for(int i=j; i<metros[0]; i++){
                if((altitude[i]-altitude[i-1])>metros[1]){
                    break;
                }
                else{
                    mirantes++;
                }
            }
            valores.Add(mirantes);
        }
        Console.WriteLine(valores.Max());
    }
}