using System; 
class URI {
    static void Main(string[] args) { 
        int testes=int.Parse(Console.ReadLine());
        string saida="";
        for(int i=0; i<testes; i++){
            char[] monte=Console.ReadLine().ToCharArray();
            if(Array.Exists(monte, element=>element=='Q') && Array.Exists(monte, element=>element=='J') && Array.Exists(monte, element=>element=='K') && Array.Exists(monte, element=>element=='A')){
                saida="Aaah muleke";
            }
            else{
                saida="Ooo raca viu";
            }
            Console.WriteLine(saida);
        }
    }
}