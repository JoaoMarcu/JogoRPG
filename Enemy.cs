using System;
using ArenaGame.Characters;
using ArenaGame.Players;

namespace ArenaGame.Enemies
{
    public class Enemy : Character
    {
        public bool defendendo;

        public virtual void Envenenar(Player alvo)
        {
            alvo.ReceberDanoVeneno(alvo.veneno);
        }

        public virtual void DecidirAção(Player alvo)
        {
            int escolha = rng.Next(0, 3);

            switch (escolha)
            {
                case 0:
                    Atacar(alvo);
                    break;
                case 1:
                    Atacar(alvo);
                    break;
                case 2:
                    Atacar(alvo);
                    break;
            }
        }
    }

    public class Prisioneiro : Enemy
    {
        public override void Atacar(Character alvo)
        {
            Console.WriteLine($"{nome} ataca {alvo.nome} com suas correntes!!\n");
            base.Atacar(alvo);
        }

        public override void Envenenar(Player alvo)
        {
            Console.WriteLine($"{nome} tira uma seringa escondida e a lança contra {alvo.nome}, envenenando-o!\n\nO veneno causa 2 de dano todo turno.\n");
            base.Envenenar(alvo);
        }
        public override void DecidirAção(Player alvo)
        {
            int escolha = 0;

            if (alvo.envenenado == true)
            {

                escolha = rng.Next(0, 2);
            }

            else if (alvo.envenenado == false)
            {
                escolha = rng.Next(0, 3);
            }
            switch (escolha)
            {
                case 0:
                    Atacar(alvo);
                    break;
                case 1:
                    Atacar(alvo);
                    break;
                case 2:
                    Envenenar(alvo);
                    break;
            }

        }
    }
    public class Lanceiro : Enemy
    {
        public void Sangramento(Player alvo)
        {
            Console.WriteLine($"{nome} ataca {alvo.nome} com sua lança, causando sangramento!\n\nO sangramento causa 4 de dano todo turno por 3 turnos.\n");
            alvo.ReceberDanoSangramento(alvo.sangrar);
        }

        public void AtacarDefender(Character alvo)
        {
            Console.WriteLine($"{nome} está se defendendo e ataca {alvo.nome} com sua lança!\n");

            defendendo = true;
            base.Atacar(alvo);
        }

        public override void ReceberDano(int dano)
        {
            if (defendendo)
            {
                dano = 0;
                defendendo = false;
            }

            base.ReceberDano(dano);

            if (vida < 0)
                vida = 0;
        }

        public override void DecidirAção(Player alvo)
        {
            int escolha = 0;

            if (alvo.sangrando == true)
            {

                escolha = rng.Next(0, 4);
            }

            else if (alvo.sangrando == false)
            {
                escolha = rng.Next(0, 6);
            }
            switch (escolha)
            {
                case 0:
                    Atacar(alvo);
                    break;
                case 1:
                    Atacar(alvo);
                    break;
                case 2:
                    Atacar(alvo);
                    break;
                case 3:
                    AtacarDefender(alvo);
                    break;
                case 4:
                    Sangramento(alvo);
                    break;
                case 5:
                    Sangramento(alvo);
                    break;
            }

        }

    }
    public class Campeao : Enemy
    {

    }
}


