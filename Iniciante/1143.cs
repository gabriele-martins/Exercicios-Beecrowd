using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        for(int i=1; i<=quant; i++){
            Console.WriteLine("{0} {1} {2}",i,Math.Pow(i,2),Math.Pow(i,3));
        }
    }
}