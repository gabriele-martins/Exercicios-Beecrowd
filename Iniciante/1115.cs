using System; 
class URI {
    static void Main(string[] args) { 
        string input;
        string[] val_str=new string[2];
        int[] val_int=new int[2];
        int aux=0;
        while(aux==0){
            input=Console.ReadLine();
            val_str=input.Split();
            val_int=Array.ConvertAll(val_str, int.Parse);
            if(val_int[0]==0|val_int[1]==0){
                aux=1;
            }
            else{
                if(val_int[0]>0 && val_int[1]>0){
                    Console.WriteLine("primeiro");
                }
                else if(val_int[0]<0 && val_int[1]>0){
                    Console.WriteLine("segundo");
                }
                else if(val_int[0]<0 && val_int[1]<0){
                    Console.WriteLine("terceiro");
                }
                else{
                    Console.WriteLine("quarto");
                }
            }
            Array.Clear(val_str,0,2);
            Array.Clear(val_int,0,2);
        }
    }
}