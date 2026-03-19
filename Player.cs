using System;

public class Player : Character
{

    bool envenenado;
    bool defendendo;
    public int veneno = 2;

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
            vida -= veneno;
        }

        base.ReceberDano(dano);

        if (vida < 0)
            vida = 0;
    }

    public void ReceberDanoVeneno(int danoVeneno)
    {
        envenenado = true;

        danoVeneno = veneno;

        vida -= danoVeneno;

        defendendo = false;

        if (vida < 0)
            vida = 0;
    }


    public void Curar()
	{
		vida += 20;

		if (vida > vidamax)
			vida = vidamax;
	}

    
}

