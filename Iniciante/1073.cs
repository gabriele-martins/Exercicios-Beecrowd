using System; 
class URI {
    static void Main(string[] args) { 
        int valor=int.Parse(Console.ReadLine());
        if(valor%2==0){
            for(int i=2; i<=valor; i+=2){
                Console.WriteLine("{0}^2 = {1}",i,Math.Pow(i,2));
            }
        }
        else{
            for(int i=2; i<valor; i+=2){
                Console.WriteLine("{0}^2 = {1}",i,Math.Pow(i,2));
            }
        }
    }
}