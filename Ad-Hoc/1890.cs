using System; 
class URI {
    static void Main(string[] args) { 
        int t=int.Parse(Console.ReadLine());
        for(int i=0; i<t; i++){
            string[] input=Console.ReadLine().Split();
            double c=double.Parse(input[0]);
            double d=double.Parse(input[1]);
            double cons=26, dig=10;
            long quantidade=0;
            if(c!=0 || d!=0){
                quantidade=(long)(Math.Pow(cons,c)*Math.Pow(dig,d));
            }
            Console.WriteLine(quantidade);
        }
    }
}