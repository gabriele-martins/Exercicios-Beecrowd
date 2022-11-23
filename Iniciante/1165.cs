using System; 
class URI {
    static void Main(string[] args) { 
        int N=int.Parse(Console.ReadLine());
        int valor, primo=0;
        for(int i=0; i<N; i++){
            valor=int.Parse(Console.ReadLine());
            for(int j=2; j<valor; j++){
                if(valor%j==0){
                    primo=1;
                }
            }
            if(primo==0){
                Console.WriteLine("{0} eh primo", valor);
            }
            else{
                Console.WriteLine("{0} nao eh primo", valor);
            }
            primo=0;
        }
    }
}