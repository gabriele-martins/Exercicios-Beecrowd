using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        for(int i=0; i<n; i++){
            string[] entrada=Console.ReadLine().Split();
            int[] valores=Array.ConvertAll(entrada,int.Parse);
            int[] bloco1={valores[0],valores[1],valores[2]};
            int[] bloco2={valores[3],valores[4],valores[5]};
            if(empilha(bloco1,bloco2) && empilha(bloco2,bloco1)){
                Console.WriteLine(3);
            }
            else if(empilha(bloco1,bloco2)){
                Console.WriteLine(1);
            }
            else if(empilha(bloco2,bloco1)){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
    static bool empilha(int[] a, int[] b){
        if((((a[0] < b[0]) && (a[1] < b[1])) || ((a[0] < b[1]) && (a[1] < b[0]))) || (((a[0] < b[1]) && (a[1] < b[2])) || ((a[0] < b[2]) && (a[1] < b[1]))) || (((a[0] < b[0]) && (a[1] < b[2])) || ((a[0] < b[2]) && (a[1] < b[0])))){
            return true;
        }
        else if((((a[1] < b[0]) && (a[2] < b[1])) || ((a[1] < b[1]) && (a[2] < b[0]))) || (((a[1] < b[1]) && (a[2] < b[2])) || ((a[1] < b[2]) && (a[2] < b[1]))) || (((a[1] < b[0]) && (a[2] < b[2])) || ((a[1] < b[2]) && (a[2] < b[0])))){
            return true;
        }
        else if((((a[0] < b[0]) && (a[2] < b[1])) || ((a[0] < b[1]) && (a[2] < b[0]))) || (((a[0] < b[1]) && (a[2] < b[2])) || ((a[0] < b[2]) && (a[2] < b[1]))) || (((a[0] < b[0]) && (a[2] < b[2])) || ((a[0] < b[2]) && (a[2] < b[0])))){
            return true;
        }
        return false;
    }
}