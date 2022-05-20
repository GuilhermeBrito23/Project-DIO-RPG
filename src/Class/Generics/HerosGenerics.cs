namespace Desafio_Poo.src.Class.Generics
{
    public class HerosGeneric
    {
         //Definindo os Membros gerenicos para sere herdados
        public string Name;
        public int HP;
        public int MP;
        public int Level;
        public string HeroType;       

        //Ataque Padrão        
        public virtual string DefaultAtt(){
            return "Deu um ataque normal";
        }
    }
}