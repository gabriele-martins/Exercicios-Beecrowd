using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada,int.Parse);
        int f=valores[1]/valores[0];
        if(f>=valores[2]){
            Console.WriteLine("S");
        }
        else{
            Console.WriteLine("N");
        }
    }
}