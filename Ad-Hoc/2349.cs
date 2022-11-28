using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int n=int.Parse(entrada[0]);
        int c=int.Parse(entrada[1]);
        int s=int.Parse(entrada[2]);
        string[] comandos=Console.ReadLine().Split();
        int soma=0, estacao=1;
        if(estacao==s){
            soma++;
        }
        for(int i=0; i<c; i++){
            if(comandos[i]=="1"){
                estacao++;
            }
            else if(comandos[i]=="-1"){
                estacao--;
            }

            if(estacao==0){
                estacao=n;
            }
            else if(estacao>n){
                estacao-=n;
            }

            if(estacao==s){
                soma++;
            }   
        }
        Console.WriteLine(soma);
    }
}