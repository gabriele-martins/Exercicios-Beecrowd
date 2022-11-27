using System; 
class URI {
    static void Main(string[] args) { 
        string[] conector1=Console.ReadLine().Split();
        string[] conector2=Console.ReadLine().Split();
        string compativel="Y";
        for(int i=0; i<5; i++){
            if(conector1[i]==conector2[i]){
                compativel="N";
                break;
            }
        }
        Console.WriteLine(compativel);
    }
}