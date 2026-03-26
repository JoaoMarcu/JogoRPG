using System;

namespace ArenaGame.Characters
{
    public class Character
    {
        public required string nome;
        public int vida;
        public int atk;
        public int vidamax;
        public int chancecritico;
        public int multiplicritico;

        public Random rng = new Random();
        public virtual void Atacar(Character alvo)
        {
            alvo.ReceberDano(atk);
        }

        public virtual void ReceberDano(int dano)
        {
            int numero = rng.Next(0, 100);
            multiplicritico = 2;
            chancecritico = 20;

            if (numero < chancecritico)
            {
                dano = dano * multiplicritico;
                Console.WriteLine("ATAQUE CRITICO!!");
            }

            vida -= dano;

            if (vida < 0)
                vida = 0;
        }

        public bool EstaVivo()
        {
            return vida > 0;
        }
    }
}

