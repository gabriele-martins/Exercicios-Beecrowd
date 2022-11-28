using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        while(entrada[0]!="0"&&entrada[1]!="0"&&entrada[2]!="0"){
            int a=int.Parse(entrada[0]);
            int b=int.Parse(entrada[1]);
            int c=int.Parse(entrada[2]);
            int vPar=a*b*c;
            int aresta=(int)Math.Pow(Convert.ToDouble(vPar),1.0/3.0);
            Console.WriteLine(aresta);
            entrada=Console.ReadLine().Split();
        }
    }
}