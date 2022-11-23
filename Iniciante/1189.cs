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
        int linMin=1, linMax=11;
        for(int j=0; j<5; j++){
            for(int i=linMin; i<linMax; i++){
                soma+=matriz[i,j];
                cont+=1.0;
            }
            linMin++;
            linMax--;
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