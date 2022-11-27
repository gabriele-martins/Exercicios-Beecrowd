using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        string p=input[0];
        string r=input[1];
        string caminho="";
        if(p=="0"){
            caminho="C";
        }
        else if(p=="1" && r=="0"){
            caminho="B";
        }
        else if(p=="1" && r=="1"){
            caminho="A";
        }
        Console.WriteLine(caminho);
    }
}