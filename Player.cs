using System;
using ArenaGame.Characters;

namespace ArenaGame.Players
{
    public class Player : Character
    {

        public int veneno = 4;
        public bool envenenado;
        public int sangrar = 6;
        public bool sangrando;
        public int sangrarTurnos = 0;
        public int defenderTurnos = 0;
        public bool defendendo;

        public void Defender()
        {
            Console.WriteLine($"{nome} está se defendendo! O escudo está levantado por 2 turnos.\n");
            defendendo = true;
        }

        public void PararDefender()
        {
            if (defenderTurnos >= 2)
            {
                Console.WriteLine($"{nome} baixou o escudo!");
                defendendo = false;
                defenderTurnos = 0;
            }

            sangrarTurnos++;
        }

        public override void ReceberDano(int dano)
        {
            if (defendendo)
            {
                defesa *= 2 ;
            }

            if (envenenado)
            {
                Console.WriteLine("Gladiador está envenenado!");
                vida -= veneno;
            }

            if (sangrando) 
            {
                Console.WriteLine("Gladiador está sangrando!");
                vida -= sangrar;

                PararSangramento();

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

        public void ReceberDanoSangramento(int danoSangramento)
        {
            sangrando = true;

            if (sangrando)
            {
                Console.WriteLine("Gladiador está sangrando!");
            }

            danoSangramento = sangrar;

            vida -= danoSangramento;

            defendendo = false;

            PararSangramento();

            if (vida < 0)
                vida = 0;
        }

        public void PararSangramento()
        {
            if (sangrarTurnos >= 3)
            {
                Console.WriteLine("O efeito do Sangramento passou!");
                sangrando = false;
                sangrarTurnos = 0;
            }

            sangrarTurnos++;
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


