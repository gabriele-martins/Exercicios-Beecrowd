using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int d=0;
        for(int i=0; i<n; i++){
            string[] linha=Console.ReadLine().Split();
            d+=int.Parse(linha[0])*int.Parse(linha[1]);
        }
        Console.WriteLine(d);
    }
}