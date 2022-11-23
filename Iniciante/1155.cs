using System; 
class URI {
    static void Main(string[] args) { 
        double S=1.0;
        for(double i=2.0; i<=100.0; i+=1.0){
            S+=(1/i);
        }
        Console.WriteLine("{0:F2}",S);
    }
}