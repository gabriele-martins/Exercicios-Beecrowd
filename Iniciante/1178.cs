using System; 
class URI {
    static void Main(string[] args) { 
        decimal x=decimal.Parse(Console.ReadLine());
        decimal[] vetor=new decimal[100];
        vetor[0]=x;
        Console.WriteLine("N[0] = {0:F4}",decimal.Round(vetor[0], 4, MidpointRounding.ToEven));
        for(int i=1; i<100; i++){
            vetor[i]=vetor[i-1]/2.0m;
            Console.WriteLine("N[{0}] = {1:F4}",i, decimal.Round(vetor[i], 4, MidpointRounding.ToEven));
        }
    }
}