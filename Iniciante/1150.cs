using System; 
class URI {
    static void Main(string[] args) { 
        int X=int.Parse(Console.ReadLine());
        int Z=int.Parse(Console.ReadLine());
        while(Z<=X){
            Z=int.Parse(Console.ReadLine());
        }
        int cont=0, soma=0;
        while(soma<Z){
            soma+=X;
            X++;
            cont+=1;
        }
        Console.WriteLine(cont);
    }
}