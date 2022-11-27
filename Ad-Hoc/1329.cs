using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            string[] input=Console.ReadLine().Split();
            int maria=0, joao=0;
            for(int i=0; i<n; i++){
                if(input[i]=="0"){
                    maria++;
                }
                else{
                    joao++;
                }
            }
            Console.WriteLine("Mary won {0} times and John won {1} times",maria,joao);
            n=int.Parse(Console.ReadLine());
        }
    }
}