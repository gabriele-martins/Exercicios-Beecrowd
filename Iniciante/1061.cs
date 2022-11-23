using System; 
class URI {
    static void Main(string[] args) { 
        int dia_inicio=int.Parse(Console.ReadLine().Replace("Dia ",""));
        string[] input1=Console.ReadLine().Replace(" : ", " ").Split();
        int [] tempo_inicio=Array.ConvertAll(input1, int.Parse);
        int dia_fim=int.Parse(Console.ReadLine().Replace("Dia ",""));
        string[] input2=Console.ReadLine().Replace(" : ", " ").Split();
        int [] tempo_fim=Array.ConvertAll(input2, int.Parse);
        int q1=tempo_inicio[2]+tempo_inicio[1]*60+tempo_inicio[0]*60*60+dia_inicio*60*60*24;
        int q2=tempo_fim[2]+tempo_fim[1]*60+tempo_fim[0]*60*60+dia_fim*60*60*24;
        int tempo_s=q2-q1;
        Console.WriteLine("{0} dia(s)", tempo_s/(60*60*24));
        tempo_s=tempo_s%(60*60*24);
        Console.WriteLine("{0} hora(s)", tempo_s/(60*60));
        tempo_s=tempo_s%(60*60);
        Console.WriteLine("{0} minuto(s)", tempo_s/60);
        tempo_s=tempo_s%60;
        Console.WriteLine("{0} segundo(s)", tempo_s);
    }
}