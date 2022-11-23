using System; 
class URI {
    static void Main(string[] args) { 
        double a=double.Parse(Console.ReadLine());
        double b=double.Parse(Console.ReadLine());
        double c=double.Parse(Console.ReadLine());
        double media=a*0.2+b*0.3+c*0.5;
        Console.WriteLine("MEDIA = {0:F1}",media);
    }
}