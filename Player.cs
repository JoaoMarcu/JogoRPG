using System;

public class Player : Character
{

	public void Defender()
	{
        bool defendendo = true
    }

	public void Curar()
	{
		vida += 20;

		if (vida > 100)
			vida = 100;
	}
}
