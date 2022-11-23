using System; 
class URI {
    static void Main(string[] args) { 
        int ddd=int.Parse(Console.ReadLine());
        string destination;
        if(ddd==61){
            destination="Brasilia";
        }
        else if(ddd==71){
            destination="Salvador";
        }
        else if(ddd==11){
            destination="Sao Paulo";
        }
        else if(ddd==21){
            destination="Rio de Janeiro";
        }
        else if(ddd==32){
            destination="Juiz de Fora";
        }
        else if(ddd==19){
            destination="Campinas";
        }
        else if(ddd==27){
            destination="Vitoria";
        }
        else if(ddd==31){
            destination="Belo Horizonte";
        }
        else{
            destination="DDD nao cadastrado";
        }
        Console.WriteLine(destination);
    }
}