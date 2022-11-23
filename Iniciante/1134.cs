using System; 
class URI {
    static void Main(string[] args) { 
        int input,alcool=0,gasolina=0,diesel=0;
        do{
            do{
                input=int.Parse(Console.ReadLine());
            }while(input<1|input>4);
            if(input==1){
                alcool+=1;
            }
            else if(input==2){
                gasolina+=1;
            }
            else if(input==3){
                diesel+=1;
            }
            else{}
        }while(input!=4);
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: {0}", alcool);
        Console.WriteLine("Gasolina: {0}", gasolina);
        Console.WriteLine("Diesel: {0}", diesel);
    }
}