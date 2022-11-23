using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        string[] input=new string[quant];
        string[] valores=new string[3];
        double media;
        for(int i=0; i<quant; i++){
            input[i]=Console.ReadLine();
        }
        for(int i=0; i<quant; i++){
            valores=input[i].Split();
            media=(2*double.Parse(valores[0])+3*double.Parse(valores[1])+5*double.Parse(valores[2]))/10.0;
            Console.WriteLine("{0:F1}",media);
        }
    }
}