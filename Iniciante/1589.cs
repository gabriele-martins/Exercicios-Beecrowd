using System; 
class URI {
    static void Main(string[] args) { 
        int t=int.Parse(Console.ReadLine());
        for(int i=0; i<t; i++){
            string[] input=Console.ReadLine().Split();
            int r1=int.Parse(input[0]);
            int r2=int.Parse(input[1]);
            int r3=r1+r2;
            Console.WriteLine(r3);
        }
    }
}