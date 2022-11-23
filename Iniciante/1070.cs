using System; 
class URI {
    static void Main(string[] args) { 
        int valor=int.Parse(Console.ReadLine());
        if(valor%2==0){
            for(int i=valor+1; i<=valor+12; i+=2){
                Console.WriteLine(i);
            } 
        }
        else{
            for(int i=valor; i<=valor+10; i+=2){
                Console.WriteLine(i);
            }
        }  
    }
}