using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(input)){
                break;
            }
            else{
                int n=int.Parse(input);
                string[] input2=Console.ReadLine().Split();
                int[] numeros=Array.ConvertAll(input2,int.Parse);
                Array.Sort(numeros);
                int convidados=n/2;
                Console.WriteLine("{0} {1}",convidados,numeros[convidados]-numeros[convidados-1]);
            }
            input=Console.ReadLine();
        }
    }
}