using System; 
using System.Linq;
class URI {
    static void Main(string[] args) {
        string input0=Console.ReadLine();
        while(true){
            if(string.IsNullOrEmpty(input0)){
                break;
            }
            string[] input1=Console.ReadLine().Split();
            int lesmas=int.Parse(input0);
            int[] velocidades=Array.ConvertAll(input1, int.Parse);
            if(velocidades.Max()>=20){
                Console.WriteLine(3);
            }
            else if(velocidades.Max()>=10 && velocidades.Max()<20){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(1);
            }
            input0=Console.ReadLine();
        }
    }
}