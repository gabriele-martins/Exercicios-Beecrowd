using System; 
class URI {
    static void Main(string[] args) {
        int valor=int.Parse(Console.ReadLine());
        int teste=1;
        while(valor!=0){
            int n50=0,n10=0,n5=0,n1=0;
            n50=(int)valor/50;
            valor=valor%50;
            n10=(int)valor/10;
            valor=valor%10;
            n5=(int)valor/5;
            valor=valor%5;
            n1=valor;
            Console.WriteLine("Teste {0}",teste);
            Console.WriteLine("{0} {1} {2} {3}",n50,n10,n5,n1);
            Console.Write("\n");
            teste++;
            valor=int.Parse(Console.ReadLine());
        }
    }
}