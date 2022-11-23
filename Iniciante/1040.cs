using System;
class URI {
    static void Main(string[] args) { 
        string[] nota=Console.ReadLine().Split();
        double[] notas=Array.ConvertAll(nota, double.Parse);
        double media=(2*notas[0]+3*notas[1]+4*notas[2]+1*notas[3])/10;
        Console.WriteLine("Media: {0:F1}",Math.Floor(media*10)/10f);
        if(media>=7.0){
            Console.WriteLine("Aluno aprovado.");
        }
        else if(media<5.0){
            Console.WriteLine("Aluno reprovado.");
        }
        else{
            Console.WriteLine("Aluno em exame.");
            double exame=double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0:F1}",Math.Floor(exame*10)/10f);
            media=(media+exame)/2;
            if(media>=5.0){
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: {0:F1}",Math.Floor(media*10)/10f);
            }
            else{
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: {0:F1}",Math.Floor(media*10)/10f);
            }
        }
    }
}