using System; 
class URI {
    static void Main(string[] args) { 
        int bandejas=int.Parse(Console.ReadLine());
        int soma=0;
        for(int i=0; i<bandejas; i++){
            string[] entrada=Console.ReadLine().Split();
            int l=int.Parse(entrada[0]);
            int c=int.Parse(entrada[1]);
            if(l>c){
                soma+=c;
            }
        }
        Console.WriteLine(soma);
    }
}