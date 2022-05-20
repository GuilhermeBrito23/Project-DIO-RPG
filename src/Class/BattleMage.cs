using System;
namespace Desafio_Poo.src.Class.Generics
{
    public class BattleMage : HerosGeneric
    {
        public BattleMage(string Nome)
        {
            this.Name = Nome;
            this.HP = 50;
            this.MP = 50;
            this.Level = 1;
            this.HeroType = "Battle Mage";
        }

        public override string DefaultAtt()
        {

            return this.Name + " Atacou com seu cajado encantado";
        }

        public string MagicSword()
        {

            return this.Name + " Atacou com uma espada materializada com magia";
        }
        public string GlacialHammer()
        {

            return this.Name + " Atacou muito forte com seu cajado com elemento de gelo, causando o dobro de dano";
        }

        public void Attacking(int AttackNumbers)
        {
            Random RandNum = new Random();

            for (int i = 1; i <= AttackNumbers; i++)
            {

                int Att = RandNum.Next(1, 4);
                if (Att == 1)
                {
                    Console.WriteLine(DefaultAtt());
                }
                else if (Att == 2)
                {
                    Console.WriteLine(MagicSword());
                }
                else
                {
                    Console.WriteLine(GlacialHammer());
                }
            }
        }
    }
}
