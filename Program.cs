using System;
using Desafio_Poo.src.Class;
using Desafio_Poo.src.Function;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string CharacterName;
            string PlayerClass;
            
            Console.WriteLine("Digte o nome do persongem ");
            CharacterName = Console.ReadLine();
            VerifyChoises ListClass = new VerifyChoises();
            ListClass.ListClass();

            Console.WriteLine("Digite a Classe do seu personagem: ");
            PlayerClass = Console.ReadLine().ToLower();

            ListClass.VerifyPlayerClass(CharacterName, PlayerClass);




        }

    }
}