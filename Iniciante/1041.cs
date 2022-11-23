using System; 
class URI {
    static void Main(string[] args) { 
        string[] coordenadas=Console.ReadLine().Split();
        double[] ponto=Array.ConvertAll(coordenadas, double.Parse);
        if(ponto[0]==0.0 && ponto[1]==0.0){
            Console.WriteLine("Origem");
        }
        else if(ponto[0]==0.0){
            Console.WriteLine("Eixo Y");
        }
        else if(ponto[1]==0.0){
            Console.WriteLine("Eixo X");
        }
        else if(ponto[0]>0.0 && ponto[1]>0.0){
            Console.WriteLine("Q1");
        }
        else if(ponto[0]>0.0 && ponto[1]<0.0){
            Console.WriteLine("Q4");
        }
        else if(ponto[0]<0.0 && ponto[1]>0.0){
            Console.WriteLine("Q2");
        }
        else{
            Console.WriteLine("Q3");
        }
    }
}