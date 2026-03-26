using System;
using ArenaGame.Characters;

namespace ArenaGame.Players
{
    public class Player : Character
    {


        bool defendendo;
        public int veneno = 2;
        public bool envenenado;

        public void Defender()
        {
            defendendo = true;
        }

        public override void ReceberDano(int dano)
        {
            if (defendendo)
            {
                dano = 0;
                defendendo = false;
            }

            if (envenenado)
            {
                Console.WriteLine("Gladiador está envenenado!");
                vida -= veneno;
            }

            base.ReceberDano(dano);

            if (vida < 0)
                vida = 0;
        }

        public void ReceberDanoVeneno(int danoVeneno)
        {
            envenenado = true;

            if (envenenado)
            {
                Console.WriteLine("Gladiador está envenenado!");
            }

            danoVeneno = veneno;

            vida -= danoVeneno;

            defendendo = false;

            if (vida < 0)
                vida = 0;
        }

        public void Curar()
        {

            if (envenenado)
            {
                Console.WriteLine("O efeito do Veneno passou!");
                envenenado = false;
            }

            vida += 20;

            if (vida > vidamax)
                vida = vidamax;
        }


    }
}


