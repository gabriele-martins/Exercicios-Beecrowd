using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada1=Console.ReadLine().Split();
        string[] entrada2=Console.ReadLine().Split();
        int[] container=Array.ConvertAll(entrada1, int.Parse);
        int[] navio=Array.ConvertAll(entrada2, int.Parse);
        int largura=navio[0]/container[0];
        int comprimento=navio[1]/container[1];
        int altura=navio[2]/container[2];
        int quantidade=largura*comprimento*altura;
        Console.WriteLine(quantidade);
    }
}