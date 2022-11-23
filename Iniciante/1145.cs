using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int[] val=Array.ConvertAll(input, int.Parse);
        for(int j=1; j<=val[1]; j++){
            if(j%val[0]==0){
                Console.WriteLine(j);
            }
            else{
                Console.Write("{0} ",j);
            }
        }
    }
}