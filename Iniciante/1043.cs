using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        double[] lados=Array.ConvertAll(input, double.Parse);
        Array.Sort(lados);
        if(lados[0]+lados[1]>lados[2]){
            double P=lados[0]+lados[1]+lados[2];
            Console.WriteLine("Perimetro = {0}", P.ToString("F1"));
        }
        else{
            double A=((double.Parse(input[0])+double.Parse(input[1]))*double.Parse(input[2]))/2.0;
            Console.WriteLine("Area = {0}", A.ToString("F1"));
        }
    }
}