using System; 
class URI {
    static void Main(string[] args) { 
        int[,] jogos=new int[15,2];
        for(int i=0; i<15; i++){
            string[] input=Console.ReadLine().Split();
            jogos[i,0]=int.Parse(input[0]);
            jogos[i,1]=int.Parse(input[1]);
        }
        string[,] times=new string[8,2]{{"A","B"},{"C","D"},{"E","F"},{"G","H"},{"I","J"},{"K","L"},{"M","N"},{"O","P"}};
        string[] oitavas=new string[8];
        for(int i=0; i<8; i++){
            if(jogos[i,0]>jogos[i,1]){
                oitavas[i]=times[i,0];
            }
            else{
                oitavas[i]=times[i,1];
            }
        }
        string[] quartas=new string[4];
        int j=0;
        for(int i=0; i<4; i++){
            if(jogos[8+i,0]>jogos[8+i,1]){
                quartas[i]=oitavas[j];
            }
            else{
                quartas[i]=oitavas[j+1];
            }
            j+=2;
        }
        string[] semis=new string[2];
        j=0;
        for(int i=0; i<2; i++){
            if(jogos[12+i,0]>jogos[12+i,1]){
                semis[i]=quartas[j];
            }
            else{
                semis[i]=quartas[j+1];
            }
            j+=2;
        }
        string final="";
        if(jogos[14,0]>jogos[14,1]){
            final=semis[0];
        }
        else{
            final=semis[1];
        }
        Console.WriteLine(final);
    }
}