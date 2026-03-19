using System;

public class Enemy : Character
{
    int veneno = 2;

    public void Envenenar(Player alvo)
    {
        alvo.ReceberDanoVeneno(veneno);
    }

}

