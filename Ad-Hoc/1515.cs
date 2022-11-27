using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            string[] input=Console.ReadLine().Split();
            string planeta=input[0];
            int menor=int.Parse(input[1])-int.Parse(input[2]);
            for(int i=1; i<n; i++){
                input=Console.ReadLine().Split();
                if(int.Parse(input[1])-int.Parse(input[2])<menor){
                    menor=int.Parse(input[1])-int.Parse(input[2]);
                    planeta=input[0];
                }
            }
            Console.WriteLine(planeta);
            n=int.Parse(Console.ReadLine());
        }
    }
}