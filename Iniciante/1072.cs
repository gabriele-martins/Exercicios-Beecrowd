using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        int[] valores=new int[quant];
        int cont_in=0,cont_out=0;
        for(int i=0; i<quant; i++){
            valores[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0; i<quant; i++){
            if(valores[i]>=10 && valores[i]<=20){
                cont_in+=1;
            }
            else{
                cont_out+=1;
            }
        }
        Console.WriteLine("{0} in",cont_in);
        Console.WriteLine("{0} out",cont_out);
    }
}