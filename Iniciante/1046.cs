using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int[] hora=Array.ConvertAll(input, int.Parse);
        int duracao;
        if(hora[0]<hora[1]){
            duracao=hora[1]-hora[0];
            Console.WriteLine("O JOGO DUROU {0} HORA(S)",duracao);
        }
        else if(hora[0]>hora[1]){
            duracao=(hora[1]-hora[0])+24;
            Console.WriteLine("O JOGO DUROU {0} HORA(S)",duracao);
        }
        else{
            duracao=24;
            Console.WriteLine("O JOGO DUROU {0} HORA(S)",duracao);
        }
    }
}