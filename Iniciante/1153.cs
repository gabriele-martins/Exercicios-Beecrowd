using System; 
class URI {
    static void Main(string[] args) { 
        int valor=int.Parse(Console.ReadLine());
        int fat=1;
        if(valor!=0){
            for(int i=valor; i>1; i--){
                fat*=i;
            }
        }
        else{
            fat=1;
        }
        Console.WriteLine(fat);
    }
}