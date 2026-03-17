using System;

public class Player : Character
{
    bool defendendo;


    public void Defender()
	{
        defendendo = true
    }

    public override void ReceberDano(int dano)
	{
        if (defendendo == true)
            dano = 0;

        vida -= dano;

        defendendo = false;
    }


    public void Curar()
	{
		vida += 20;

		if (vida > vidamax)
			vida = vidamax;
	}
}

