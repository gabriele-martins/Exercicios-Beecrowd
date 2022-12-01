using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int a=int.Parse(entrada[0]);
        int b=int.Parse(entrada[1]);
        int c=int.Parse(entrada[2]);
        int d=int.Parse(entrada[3]);
        int denominador=b*d;
        int numerador=(d*a)+(b*c);
        int i=2;
        while(true){
            if(denominador%i==0 && numerador%i==0){
                denominador/=i;
                numerador/=i;
                i=2;
            }
            else{
                i++;
            }
            if(i>denominador || i>numerador){
                break;
            }
        }
        Console.WriteLine("{0} {1}",numerador,denominador);
    }
}