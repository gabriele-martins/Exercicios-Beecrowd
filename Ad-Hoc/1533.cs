using System; 
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            string[] entrada=Console.ReadLine().Split();
            int[] pessoas=Array.ConvertAll(entrada,int.Parse);
            int segMaior=0, inicial=0;
            if(pessoas[0]==pessoas.Max()){
                segMaior=pessoas[1];
                inicial=2;
            }
            else{
                segMaior=pessoas[0];
                inicial=1;
            }
            for(int i=inicial; i<n; i++){
                if(pessoas[i]>segMaior && pessoas[i]!=pessoas.Max()){
                    segMaior=pessoas[i];
                }
            }
            Console.WriteLine(Array.IndexOf(pessoas,segMaior)+1);
            n=int.Parse(Console.ReadLine());
        }
    }
}