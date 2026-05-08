using System;

namespace ArenaGame.Characters
{
    public class Character
    {
        public required string nome;
        public int vida;
        public int vidamax;
        public int atk;
        public int defesa;
        public int chancecritico;
        public double multiplicritico;

        public Random rng = new ();
        public virtual void Atacar(Character alvo)
        {
            alvo.ReceberDano(atk);
        }

        public virtual void ReceberDano(int dano)
        {
            double danocrit;
            int numero = rng.Next(0, 100);
            multiplicritico = 1.5;
            chancecritico = 20;

            if (numero < chancecritico)
            {
                danocrit = dano * multiplicritico;
                dano = (int)danocrit;
                Console.WriteLine("ATAQUE CRITICO!!");
            }

            int danofinal = dano - defesa;
             if (danofinal < 0)
             danofinal = 0;

             vida -= danofinal;
              if (vida < 0)
              vida = 0;
        }
        public bool EstaVivo()
        {
            return vida > 0;
        }
    }
}

