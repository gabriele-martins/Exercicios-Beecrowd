using System; 
class URI {
    static void Main(string[] args) { 
        int valor;
        bool condicao=true;
        while(condicao){
            valor=int.Parse(Console.ReadLine());
            if(valor==0){
                condicao=false;
            }
            else{
                for(int i=1; i<=valor; i++){
                    if(i==valor){
                        Console.WriteLine(i);
                    }
                    else{
                        Console.Write("{0} ", i);
                    }
                }   
            }
        }
    }
}