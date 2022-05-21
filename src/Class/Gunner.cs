using System;
using Desafio_Poo.src.Class.Generics;
namespace Desafio_Poo.src.Class
{
    public class Gunner : HerosGeneric
    {
         public Gunner(string Nome)
        {
            this.Name = Nome;
            this.HP = 40;
            this.MP = 80;
            this.Level = 4;
            this.HeroType = "Gunner";
        }
        public override string DefaultAtt()
        {
            return this.Name +" Atacou atirando com sua Pistola";
        }
        public string ShotgunShoot(){
            return this.Name + " Atacou atirando com sua Shotgun";
        }
        public string SniperShoot(){
            return this.Name + " Atirou com seu rifle de precisão causando um acerto crítico";
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
                    Console.WriteLine(ShotgunShoot());
                }
                else
                {
                    Console.WriteLine(SniperShoot());
                }
            }

        }



    }
}