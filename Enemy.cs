using System;
using ArenaGame.Characters;
using ArenaGame.Players;

namespace ArenaGame.Enemies
{
    public class Enemy : Character
    {

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

    }
    public class Campeao : Enemy
    {

    }
}


