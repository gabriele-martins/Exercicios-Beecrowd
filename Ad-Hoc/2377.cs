using System; 
class URI {
    static void Main(string[] args) { 
        string[] linha1=Console.ReadLine().Split();
        string[] linha2=Console.ReadLine().Split();
        int l=int.Parse(linha1[0]);
        int d=int.Parse(linha1[1]);
        int k=int.Parse(linha2[0]);
        int p=int.Parse(linha2[1]);
        int pedagios=l/d;
        int custo=p*pedagios+k*l;
        Console.WriteLine(custo);
    }
}