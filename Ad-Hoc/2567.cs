using System; 
class URI {
    static void Main(string[] args) {
        string entrada1=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(entrada1)){
                break;
            }
            else{
                int n=int.Parse(entrada1);
                string[] entrada2=Console.ReadLine().Split();
                int[] dias=Array.ConvertAll(entrada2,int.Parse);
                int letal=0;
                Array.Sort(dias);
                int j=dias.Length-1;
                for(int i=0; i<dias.Length/2; i++){
                    letal+=Math.Abs(dias[i]-dias[j]);
                    j--;
                }
                Console.WriteLine(letal);
                entrada1=Console.ReadLine();
            }
        }
    }
}