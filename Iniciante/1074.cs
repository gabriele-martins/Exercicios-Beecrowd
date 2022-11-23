using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        int[] valores=new int[quant];
        string[] par_impar=new string[quant];
        string[] pos_neg=new string[quant];
        for(int i=0; i<quant; i++){
            valores[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0; i<quant; i++){
            if(valores[i]>0){
                pos_neg[i]="POSITIVE";
            }
            else{
                pos_neg[i]="NEGATIVE";
            }
            if(valores[i]%2==0){
                par_impar[i]="EVEN";
            }
            else{
                par_impar[i]="ODD";
            }
        }
        for(int i=0; i<quant; i++){
            if(valores[i]==0){
                Console.WriteLine("NULL");
            }
            else{
                Console.WriteLine("{0} {1}",par_impar[i],pos_neg[i]);
            }
        }
    }
}