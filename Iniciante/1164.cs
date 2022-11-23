using System; 
class URI {
    static void Main(string[] args) { 
        int testes=int.Parse(Console.ReadLine());
        int valor, soma=0;
        for(int i=0; i<testes; i++){
            valor=int.Parse(Console.ReadLine());
            for(int j=1; j<valor; j++){
                if(valor%j==0){
                    soma+=j;
                }
            }
            if(soma==valor){
                Console.WriteLine("{0} eh perfeito", valor);
            }
            else{
                Console.WriteLine("{0} nao eh perfeito", valor);
            }
            soma=0;
        }
    }
}