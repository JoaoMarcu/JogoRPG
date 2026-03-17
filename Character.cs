using System;

public class Character
{
    public string nome;
    public int vida;
    public int atk;
    public int vidamax;

    bool defendendo;

    public void Defender()
    {
        defendendo = true
    }

    public void atacar(Character alvo)
    {
        alvo.ReceberDano(atk);
    }

    public virtual void ReceberDano(int dano)
    {

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
