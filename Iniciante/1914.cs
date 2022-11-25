using System; 
class URI {
    static void Main(string[] args) { 
        int qt=int.Parse(Console.ReadLine());
        for(int i=0; i<qt; i++){
            string[] nomes=Console.ReadLine().Split();
            string[] valores=Console.ReadLine().Split();
            int soma=int.Parse(valores[0])+int.Parse(valores[1]);
            if(soma%2==0){
                if(nomes[1]=="PAR"){
                    Console.WriteLine(nomes[0]);
                }
                else{
                    Console.WriteLine(nomes[2]);
                }
            }
            else{
                if(nomes[1]=="IMPAR"){
                    Console.WriteLine(nomes[0]);
                }
                else{
                    Console.WriteLine(nomes[2]);
                }
            }
        }
    }
}