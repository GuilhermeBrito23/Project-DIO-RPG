using System;
using Desafio_Poo.src.Class;
using Desafio_Poo.src.Class.Generics;
namespace Desafio_Poo.src.Function
{
    public class VerifyChoises
    {
    string[] classe = { "Fighter", "BattleMage(Digitar tudo junto)", "Gunner" };
        public void ListClass(){
            Console.WriteLine("----------Selecione uma Classe----------");
            Console.WriteLine("Classes Disponiveis:");
            for (int i = 0; i < classe.Length; i++)
            {
            
                Console.WriteLine(classe[i]);
            }
        }
        public void VerifyPlayerClass(string CharacterName, string PlayerClass){
         if (PlayerClass == "fighter")
            {

                Console.WriteLine("----------Informações do Personagem-------");
                Fighter NewHero = new Fighter(CharacterName);
                Console.WriteLine(NewHero);
                Console.WriteLine("Simulação de 5 Ataques da Classe Escolhida:");
                NewHero.Attacking(5);

            }else if (PlayerClass == "battlemage"){
                Console.WriteLine("----------Informações do Personagem-------");
                BattleMage NewHero = new BattleMage(CharacterName);
                Console.WriteLine(NewHero);
                Console.WriteLine("Simulação de 5 Ataques da Classe Escolhida:");
                NewHero.Attacking(5);

            }else if(PlayerClass == "gunner"){
 Console.WriteLine("----------Informações do Personagem-------");
                Gunner NewHero = new Gunner(CharacterName);
                Console.WriteLine(NewHero);
                Console.WriteLine("Simulação de 5 Ataques da Classe Escolhida:");
                NewHero.Attacking(5);

            } else{
                Console.WriteLine("Por Favor Digite Uma Classe Válida");
            }
        }
    }
}