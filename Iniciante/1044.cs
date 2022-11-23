using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(input, int.Parse);
        Array.Sort(valores);
        if(valores[1]%valores[0]==0){
            Console.WriteLine("Sao Multiplos");
        }
        else{
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}