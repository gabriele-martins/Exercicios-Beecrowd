using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] input=Console.ReadLine().Split();
        int[] pedacos=new int[n];
        for(int i=0; i<n; i++){
            pedacos[i]=int.Parse(input[i]);
        }
        int soma=0;
        for(int i=0; i<n; i++){
            soma+=pedacos[i]-1;
        }
        Console.WriteLine(soma);
    }
}