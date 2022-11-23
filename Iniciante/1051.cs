using System; 
class URI {
    static void Main(string[] args) { 
        double valor=double.Parse(Console.ReadLine());
        double imposto;
        if(valor>0.00 && valor<=2000.00){
            Console.WriteLine("Isento");
        }
        else if(valor>2000.00 && valor<=3000.00){
            valor=valor-2000.00;
            imposto=valor*0.08;
            Console.WriteLine("R$ {0:F2}",imposto);
        }
        else if(valor>3000.00 && valor<=4500.00){
            valor=valor-3000.00;
            imposto=1000.00*0.08+valor*0.18;
            Console.WriteLine("R$ {0:F2}",imposto);
        }
        else{
            valor=valor-4500.00;
            imposto=1000.00*0.08+1500.00*0.18+valor*0.28;
            Console.WriteLine("R$ {0:F2}",imposto);
        }
    }
}