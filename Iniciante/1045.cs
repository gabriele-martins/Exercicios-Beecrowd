using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        double[] lados=Array.ConvertAll(input, double.Parse);
        Array.Sort(lados);
        if(lados[2]>=(lados[1]+lados[0])){
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if(Math.Pow(lados[2],2)==(Math.Pow(lados[1],2)+Math.Pow(lados[0],2))){
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if(Math.Pow(lados[2],2)>(Math.Pow(lados[1],2)+Math.Pow(lados[0],2))){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if(Math.Pow(lados[2],2)<(Math.Pow(lados[1],2)+Math.Pow(lados[0],2))){
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        else{}
        if(lados[0]==lados[1]&&lados[0]==lados[2]&&lados[1]==lados[2]){
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if(lados[0]==lados[1]|lados[0]==lados[2]|lados[1]==lados[2]){
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
        else{}
    }
}