using System; 
class URI {
    static void Main(string[] args) { 
        int segundos=int.Parse(Console.ReadLine());
        int minutos=(int)(segundos/60);
        segundos-=minutos*60;
        int horas=(int)(minutos/60);
        minutos-=horas*60;
        Console.WriteLine("{0}:{1}:{2}",horas,minutos,segundos);
    }
}