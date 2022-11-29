using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int inicial=int.Parse(entrada[0]);
        int n=int.Parse(entrada[1]);
        int d=inicial,e=inicial,f=inicial;
        for(int i=0; i<n; i++){
            string[] linha=Console.ReadLine().Split();
            if(linha[0]=="C"){
                if(linha[1]=="D"){
                    d-=int.Parse(linha[2]);
                }
                else if(linha[1]=="E"){
                    e-=int.Parse(linha[2]);
                }
                else{
                    f-=int.Parse(linha[2]);
                }
            }
            else if(linha[0]=="V"){
                if(linha[1]=="D"){
                    d+=int.Parse(linha[2]);
                }
                else if(linha[1]=="E"){
                    e+=int.Parse(linha[2]);
                }
                else{
                    f+=int.Parse(linha[2]);
                }
            }
            else{
                if(linha[1]=="D"){
                    d+=int.Parse(linha[3]);
                }
                else if(linha[1]=="E"){
                    e+=int.Parse(linha[3]);
                }
                else{
                    f+=int.Parse(linha[3]);
                }
                if(linha[2]=="D"){
                    d-=int.Parse(linha[3]);
                }
                else if(linha[2]=="E"){
                    e-=int.Parse(linha[3]);
                }
                else{
                    f-=int.Parse(linha[3]);
                } 
            }
        }
        Console.WriteLine("{0} {1} {2}",d,e,f);
    }
}