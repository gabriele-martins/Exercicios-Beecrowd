using System; 
class URI {
    static void Main(string[] args) { 
        int c=int.Parse(Console.ReadLine());
        for(int i=0; i<c; i++){
            string[] input=Console.ReadLine().Split();
            string nome=input[0];
            if(nome=="Thor"){
                Console.WriteLine("Y");
            }
            else{
                Console.WriteLine("N");
            }
        }
    }
}