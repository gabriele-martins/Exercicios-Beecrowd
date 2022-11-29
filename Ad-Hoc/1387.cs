using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        while(entrada[0]!="0" && entrada[1]!="0"){
            int[] valores=Array.ConvertAll(entrada,int.Parse);
            int soma=valores[0]+valores[1];
            Console.WriteLine(soma);
            entrada=Console.ReadLine().Split();
        }
    }
}