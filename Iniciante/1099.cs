using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        string[] val=new string[quant];
        string[] val_str=new string[2];
        int[] val_int=new int[2];
        int soma=0,i,j;
        for(i=0; i<quant; i++){
            val[i]=Console.ReadLine();
        }
        for(i=0; i<quant; i++){
            val_str=val[i].Split();
            val_int[0]=int.Parse(val_str[0]);
            val_int[1]=int.Parse(val_str[1]);
            if(val_int[0]<val_int[1]){
                for(j=val_int[0]+1; j<val_int[1]; j++){
                    if(j%2!=0){
                        soma+=j;
                    }
                }
            }
            else if(val_int[0]>val_int[1]){
                for(j=val_int[1]+1; j<val_int[0]; j++){
                    if(j%2!=0){
                        soma+=j;
                    }
                }
            }
            else{
                soma=0;
            }
            Console.WriteLine(soma);
            soma=0;
        }
    }
}