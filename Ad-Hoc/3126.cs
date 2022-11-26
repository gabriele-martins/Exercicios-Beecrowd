using System; 
class URI {
    static void Main(string[] args) { 
        int c=int.Parse(Console.ReadLine());
        string[] participacao=Console.ReadLine().Split();
        int cont=0;
        for(int i=0; i<c; i++){
            if(participacao[i]=="1"){
                cont++;
            }
        }
        Console.WriteLine(cont);
    }
}