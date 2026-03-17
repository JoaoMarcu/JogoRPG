using System;

public class Character
{
    public string nome;
    public int vida;
    public int atk;

    bool defendendo;

    public void Defender()
    {
        defendendo = true
    }

    public void atacar(Character alvo)
    {
        alvo.ReceberDano(atk);
    }

    public void ReceberDano(int dano)
    {
        

        if (defendendo == true)
            dano = 0;

        vida -= dano;

        defendendo = false

        if (vida < 0)
            vida = 0;
    }

    public bool EstaVivo()
    {
        return vida > 0;
    }
}
}
