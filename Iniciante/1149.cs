using System; 
class URI {
    static void Main(string[] args) { 
        string[] valores=Console.ReadLine().Split();
        int a=int.Parse(valores[0]);
        int n=int.Parse(valores[1]);
        int cont=2;
        while(n<=0){
            n=int.Parse(valores[cont]);
            cont+=1;
        }
        int soma=0;
        for(int i=0; i<=n-1; i++){
            soma+=a+i;
        }
        Console.WriteLine(soma);
    }
}