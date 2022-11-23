using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int[] tempo=Array.ConvertAll(input, int.Parse);
        int duracaoh,duracaomin;
        if(tempo[2]>tempo[0]&&tempo[3]>tempo[1]){
            duracaoh=tempo[2]-tempo[0];
            duracaomin=tempo[3]-tempo[1];
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]>tempo[0]&&tempo[1]>tempo[3]){
            duracaoh=tempo[2]-tempo[0]-1;
            duracaomin=tempo[3]-tempo[1]+60;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]==tempo[0]&&tempo[1]>tempo[3]){
            duracaoh=23;
            duracaomin=tempo[3]-tempo[1]+60;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]==tempo[0]&&tempo[3]>tempo[1]){
            duracaoh=0;
            duracaomin=tempo[3]-tempo[1];
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]>tempo[0]&&tempo[3]==tempo[1]){
            duracaoh=tempo[2]-tempo[0];
            duracaomin=0;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]<tempo[0]&&tempo[3]==tempo[1]){
            duracaoh=tempo[2]-tempo[0]+24;
            duracaomin=0;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]<tempo[0]&&tempo[3]>tempo[1]){
            duracaoh=tempo[2]-tempo[0]+24;
            duracaomin=tempo[3]-tempo[1];
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else if(tempo[2]<tempo[0]&&tempo[3]<tempo[1]){
            duracaoh=tempo[2]-tempo[0]+23;
            duracaomin=tempo[3]-tempo[1]+60;
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",duracaoh,duracaomin);
        }
        else{
            Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }
    }
}