using System; 
class URI {
    static void Main(string[] args) { 
        int consumo=int.Parse(Console.ReadLine());
        int valor=0;
        if(consumo<=10){
            valor=7;
        }
        else if(consumo>=11 && consumo<=30){
            consumo-=10;
            valor=7+consumo*1;
        }
        else if(consumo>=31 && consumo<=100){
            consumo-=30;
            valor=7+20+consumo*2;
        }
        else if(consumo>=101){
            consumo-=100;
            valor=7+20+140+consumo*5;
        }
        Console.WriteLine(valor);
    }
}