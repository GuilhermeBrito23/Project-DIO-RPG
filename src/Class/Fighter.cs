using System;


namespace Desafio_Poo.src.Class.Generics
{
    public class Fighter : HerosGeneric
    {
        //Definindo caracteristica de um personagem lutador
        public Fighter(string Nome)
        {
            this.Name = Nome;
            this.HP = 80;
            this.MP = 30;
            this.Level = 1;
            this.HeroType = "Fighter";
        }

        //Mudando seu ataque padrão
        public override string DefaultAtt()
        {
            return this.Name +" Deu um soco normal";
        }

        //Especificando seus tipos de ataques
        public string Kick()
        {
            return this.Name + " Chutou o inimigo";
        }

        public string SuperPunch()
        {
            return this.Name + " Deu um soco muito forte";
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
                    Console.WriteLine(Kick());
                }
                else
                {
                    Console.WriteLine(SuperPunch());
                }
            }

        }



        //Criando metodo ToString para apresentar as informaçoes do personagem
        public override string ToString()
        {
            return @$"
            Nome = {this.Name} 
            HP = {this.HP}
            MP = {this.MP}
            Level = {this.Level}
            Tipo = {this.HeroType}";
        }
    }
}