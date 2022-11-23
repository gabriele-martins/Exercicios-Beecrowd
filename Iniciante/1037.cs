using System; 
class URI {
    static void Main(string[] args) { 
        double valor=double.Parse(Console.ReadLine());
        if(valor>=0 && valor<=25.0){
            Console.WriteLine("Intervalo [0,25]");
        }
        else if(valor>25.0 && valor<=50.0){
            Console.WriteLine("Intervalo (25,50]");
        }
        else if(valor>50.0 && valor<=75.0){
            Console.WriteLine("Intervalo (50,75]");
        }
        else if(valor>75.0 && valor<=100.0){
            Console.WriteLine("Intervalo (75,100]");
        }
        else{
            Console.WriteLine("Fora de intervalo");
        }
    }
}