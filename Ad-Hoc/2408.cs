using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int[] pontuacao=Array.ConvertAll(input,int.Parse);
        Array.Sort(pontuacao);
        Console.WriteLine(pontuacao[1]);
    }
}