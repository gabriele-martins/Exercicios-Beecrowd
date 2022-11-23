using System; 
class URI{
    static void Main(string[] args) { 
        int X=int.Parse(Console.ReadLine());
        int soma=0;
        while(X!=0){
            if(X%2==0){
                for(int i=0; i<5; i++){
                    soma+=X;
                    X+=2;
                }
            }
            else{
                X+=1;
                for(int i=0; i<5; i++){
                    soma+=X;
                    X+=2;
                }
            }
            Console.WriteLine(soma);
            soma=0;
            X=int.Parse(Console.ReadLine());
        }
    }
}