using System; 
class URI {
    static void Main(string[] args) { 
        int valor=int.Parse(Console.ReadLine());
        int[] vetor=new int[10];
        vetor[0]=valor;
        Console.WriteLine("N[0] = {0}", valor);
        for(int i=1; i<10; i++){
            vetor[i]=vetor[i-1]*2;
            Console.WriteLine("N[{0}] = {1}",i,vetor[i]);
        }
    }
}