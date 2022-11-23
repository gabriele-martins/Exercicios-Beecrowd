using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        string input;
        string[] val_str=new string[2];
        int[] val=new int[2];
        double div;
        for(int i=0; i<quant; i++){
            input=Console.ReadLine();
            val_str=input.Split();
            val=Array.ConvertAll(val_str, int.Parse);
            if(val[1]==0){
                Console.WriteLine("divisao impossivel");
            }
            else{
                div=Convert.ToDouble(val[0])/val[1];
                Console.WriteLine(div.ToString("F1"));
            }
            Array.Clear(val_str,0,2);
            Array.Clear(val,0,2);
        }
    }
}