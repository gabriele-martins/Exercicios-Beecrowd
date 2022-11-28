using System; 
class URI {
    static void Main(string[] args) { 
        int t=int.Parse(Console.ReadLine());
        for(int i=0; i<t; i++){
            int n=int.Parse(Console.ReadLine());
            int x=0;
            string[] valores=new string[n];
            for(int j=0; j<n; j++){
                valores[j]=Console.ReadLine();
                if(valores[j].Contains("SAME AS ")){
                    valores[j]=valores[j].Replace("SAME AS ","");
                    int index=int.Parse(valores[j])-1;
                    valores[j]=valores[index];
                }
            }
            for(int j=0; j<n; j++){
                if(valores[j]=="LEFT"){
                    x--;
                }
                else if(valores[j]=="RIGHT"){
                    x++;
                }
            }
            Console.WriteLine(x);
        }
    }
}