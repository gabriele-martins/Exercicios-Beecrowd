using System; 
class URI {
    static void Main(string[] args) { 
        int aux=0;
        string input;
        while(aux==0){
            input=Console.ReadLine();
            if(input=="2002"){
                Console.WriteLine("Acesso Permitido");
                aux=1;
            }
            else{
                Console.WriteLine("Senha Invalida");
            }
        }
    }
}