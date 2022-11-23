using System; 
class URI {
    static void Main(string[] args) { 
        double[,] matriz=new double[12,12];
        int coluna=int.Parse(Console.ReadLine());
        string t=Console.ReadLine();
        for(int i=0; i<12; i++){
            for(int j=0; j<12; j++){
                matriz[i,j]=double.Parse(Console.ReadLine());
            }
        }
        double soma=0, media=0;
        for(int i=0; i<12; i++){
            soma+=matriz[i,coluna];
        }
        if(t=="S"){
            Console.WriteLine(soma.ToString("F1"));
        }
        else{
            media=soma/12.0;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}