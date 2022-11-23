using System; 
class URI {
    static void Main(string[] args) { 
        string[] valores=Console.ReadLine().Split();
        double a=double.Parse(valores[0]);
        double b=double.Parse(valores[1]);
        double c=double.Parse(valores[2]);
        if(a==0 | (Math.Pow(b,2.0)-4*a*c)<0){
            Console.WriteLine("Impossivel calcular");
        }
        else{
            double delta=Math.Pow(b,2.0)-4*a*c;
            double R1=(-b+Math.Sqrt(delta))/(2*a);
            double R2=(-b-Math.Sqrt(delta))/(2*a);
            Console.WriteLine("R1 = {0}",R1.ToString("F5"));
            Console.WriteLine("R2 = {0}",R2.ToString("F5"));
        }
    }
}