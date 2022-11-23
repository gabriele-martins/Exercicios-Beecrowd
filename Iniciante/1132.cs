using System; 
class URI {
    static void Main(string[] args) { 
        int X,Y,soma=0;
        X=int.Parse(Console.ReadLine());
        Y=int.Parse(Console.ReadLine());
        if(X>Y){
            for(int i=Y; i<=X; i++){
                if(i%13!=0){
                    soma+=i;
                }
            }
        }
        else{
            for(int i=X; i<=Y; i++){
                if(i%13!=0){
                    soma+=i;
                }
            }
        }
        Console.WriteLine(soma);
    }
}