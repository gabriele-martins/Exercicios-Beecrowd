using System; 
class URI {
    static void Main(string[] args) { 
        double S=1.0, denominador=2.0;
        for(double i=3.0; i<=39.0; i+=2.0){
            S+=(i/denominador);
            denominador*=2.0;
        }
        Console.WriteLine("{0:F2}",S);
    }
}