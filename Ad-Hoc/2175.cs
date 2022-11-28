using System; 
using System.Linq;
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        double[] tempos=Array.ConvertAll(entrada,double.Parse);
        if(tempos[0]==tempos[1]||tempos[0]==tempos[2]||tempos[1]==tempos[2]){
            Console.WriteLine("Empate");
        }
        else if(tempos[0]==tempos.Min()){
            Console.WriteLine("Otavio");
        }
        else if(tempos[1]==tempos.Min()){
            Console.WriteLine("Bruno");
        }
        else if(tempos[2]==tempos.Min()){
            Console.WriteLine("Ian");
        }
    }
}