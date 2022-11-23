using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        string valor;
        int C=0,R=0,S=0,total;
        for(int i=0; i<quant; i++){
            valor=Console.ReadLine();
            if(valor.Contains("C")==true){
                C+=int.Parse(valor.Replace(" C",""));
            }
            else if(valor.Contains("R")==true){
                R+=int.Parse(valor.Replace(" R",""));
            }
            else{
                S+=int.Parse(valor.Replace(" S",""));
            }
        }
        total=C+R+S;
        Console.WriteLine("Total: {0} cobaias",total);
        Console.WriteLine("Total de coelhos: {0}",C);
        Console.WriteLine("Total de ratos: {0}",R);
        Console.WriteLine("Total de sapos: {0}",S);
        Console.WriteLine("Percentual de coelhos: {0:F2} %",(Convert.ToDouble(C)/total)*100.00);
        Console.WriteLine("Percentual de ratos: {0:F2} %",(Convert.ToDouble(R)/total)*100.00);
        Console.WriteLine("Percentual de sapos: {0:F2} %",(Convert.ToDouble(S)/total)*100.00);
    }
}