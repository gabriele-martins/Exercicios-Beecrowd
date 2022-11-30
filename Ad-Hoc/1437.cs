using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            char[] comandos=Console.ReadLine().ToCharArray();
            int inicial=90;
            for(int i=0; i<n; i++){
                if(comandos[i]=='D'){
                    inicial-=90;
                }
                else{
                    inicial+=90;
                }
            }
            if(inicial<0 && inicial>=-360){
                inicial=360+inicial;
            }
            else if(inicial<0 && inicial<-360){
                inicial=inicial%360;
                inicial=inicial+360;
            }
            else{
                inicial=inicial%360;
            }
            if(inicial==90){
                Console.WriteLine("N");
            }
            else if(inicial==180){
                Console.WriteLine("O");
            }
            else if(inicial==270){
                Console.WriteLine("S");
            }
            else if(inicial==0){
                Console.WriteLine("L");
            }
            n=int.Parse(Console.ReadLine());
        }
    }
}