using System; 
class URI {
    static void Main(string[] args) { 
        decimal x=decimal.Parse(Console.ReadLine());
        decimal[] vetor=new decimal[100];
        vetor[0]=x;
        Console.WriteLine("N[0] = {0:F4}",Math.Floor(vetor[0]*10000m)/10000m);
        for(int i=1; i<100; i++){
            vetor[i]=vetor[i-1]/2.0m;
            Console.WriteLine("N[{0}] = {1:F4}",i,Math.Floor(vetor[i]*10000m)/10000m);
        }
    }
}