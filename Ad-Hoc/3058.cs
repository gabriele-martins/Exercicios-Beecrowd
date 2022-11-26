using System; 
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int mercados=int.Parse(Console.ReadLine());
        double[] valores=new double[mercados];
        for(int i=0; i<mercados; i++){
            string[] precos=Console.ReadLine().Split();
            double p=double.Parse(precos[0]);
            int g=int.Parse(precos[1]);
            valores[i]=(p*1000.0)/Convert.ToDouble(g);
        }
        Console.WriteLine("{0:F2}",valores.Min());
    }
}