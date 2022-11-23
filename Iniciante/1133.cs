using System; 
class URI {
    static void Main(string[] args) { 
        int X,Y;
        X=int.Parse(Console.ReadLine());
        Y=int.Parse(Console.ReadLine());
        if(X<Y){
            for(int i=X+1; i<Y; i++){
                if(i%5==2 | i%5==3){
                    Console.WriteLine(i);
                }
            }
        }
        else{
            for(int i=Y+1; i<X; i++){
                if(i%5==2 | i%5==3){
                    Console.WriteLine(i);
                }
            }
        }
    }
}