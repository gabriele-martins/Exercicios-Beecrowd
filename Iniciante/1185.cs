using System; 
class URI {
    static void Main(string[] args) { 
        double[,] matriz=new double[12,12];
        string t=Console.ReadLine();
        for(int i=0; i<12; i++){
            for(int j=0; j<12; j++){
                matriz[i,j]=double.Parse(Console.ReadLine());
            }
        }
        double soma=0, media=0, cont=0;
        int col_max=11;
        for(int i=0; i<12; i++){
            for(int j=0; j<col_max; j++){
                soma+=matriz[i,j];
                cont+=1.0;
            }
            col_max--;
        }
        if(t=="S"){
            Console.WriteLine(soma.ToString("F1"));
        }
        else{
            media=soma/cont;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}