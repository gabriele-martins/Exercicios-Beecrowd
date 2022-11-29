using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        for(int i=0; i<n; i++){
            char[] entrada=Console.ReadLine().ToCharArray();
            int final=0;
            int a=entrada[0]-'0';
            int b=entrada[2]-'0';
            char letra=entrada[1];
            if(a==b){
                final=a*b;
            }
            else if(char.IsUpper(letra)){
                final=b-a;
            }
            else if(char.IsLower(letra)){
                final=a+b;
            }
            Console.WriteLine(final);
        }
    }
}