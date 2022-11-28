using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(input)){
                break;
            }
            else{
                string[] palavra=input.Split('x');
                int m=0;
                int p=0;
                for(int i=0; i<palavra.Length; i++){
                    p=palavra[i].Length;
                    if(i!=0 && i!=palavra.Length-1){
                        p/=2;
                    }
                    if(p>m){
                        m=p;
                    }
                }
                Console.WriteLine(m);
                input=Console.ReadLine();
            }
        }
    }
}