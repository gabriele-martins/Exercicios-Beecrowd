using System; 
class URI {
    static void Main(string[] args) { 
        int c=int.Parse(Console.ReadLine());
        for(int i=0; i<c; i++){
            string[] entrada=Console.ReadLine().Split();
            int valor=0;
            if(entrada[1]=="+"){
                valor=int.Parse(entrada[0])+int.Parse(entrada[2]);
            }
            else if(entrada[1]=="-"){
                valor=int.Parse(entrada[0])-int.Parse(entrada[2]);
            }
            else if(entrada[1]=="x"){
                valor=int.Parse(entrada[0])*int.Parse(entrada[2]);
            }
            int quant;
            quant=Math.Abs(valor-int.Parse(entrada[4]));
            string erres="";
            for(int j=0; j<quant; j++){
                erres+="r";
            }
            Console.WriteLine("E{0}ou!",erres);
        }
    }
}