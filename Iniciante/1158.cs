using System; 
class URI {
    static void Main(string[] args) { 
        int N=int.Parse(Console.ReadLine());
        string[] val_str=new string[2];
        int[] val_int=new int[2];
        int soma=0;
        for(int i=0; i<N; i++){
            val_str=Console.ReadLine().Split();
            val_int=Array.ConvertAll(val_str, int.Parse);
            if(val_int[0]%2==0){
                for(int j=0; j<val_int[1]; j++){
                    soma+=val_int[0]+1;
                    val_int[0]+=2;
                }
            }
            else{
                for(int j=0; j<val_int[1]; j++){
                    soma+=val_int[0];
                    val_int[0]+=2;
                }
            }
            Console.WriteLine(soma);
            soma=0;
            Array.Clear(val_str,0,2);
            Array.Clear(val_int,0,2);
        }
    }
}