using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int m=int.Parse(Console.ReadLine());
        int inst=1;
        while(m!=0){
            List<string> alfabeto=new List<string>(){"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            string[] entrada=Console.ReadLine().Split();
            int[] codigo=Array.ConvertAll(entrada,int.Parse);
            string final="",aux="";
            for(int i=0; i<m; i++){
                final+=alfabeto[codigo[i]-1];
                aux=alfabeto[codigo[i]-1];
                alfabeto.RemoveAt(codigo[i]-1);
                alfabeto.Insert(0,aux);
            }
            Console.WriteLine("Instancia {0}",inst);
            Console.WriteLine(final);
            inst++;
            m=int.Parse(Console.ReadLine());
        }
    }
}