
public class Game
{
    Player jogador;

    Enemy inimigo1;

    public void StartGame()
    {
        CreatePlayer();
        CreateEnemy();
        Combat();

    }
    public void CreatePlayer()
    {
        jogador = new Player();
        jogador.nome = ("Gladiador");
        jogador.vida = 100;
        jogador.atk = 20;

    }
    public void CreateEnemy()
    {
        inimigo1 = new Enemy();

        inimigo1.nome = ("Prisioneiro Faminto");
        inimigo1.vida = 40;
        inimigo1.atk = 8;

    }
    public void Combat()
    {
        

        while (true)
        {

            inimigo1.vida = inimigo1.vida - jogador.atk;
            jogador.vida = jogador.vida - inimigo1.atk;

            if (inimigo1.vida > 0 && jogador.vida > 0)

            {

                Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                Console.Write("Clique enter:"); Console.ReadLine();
            }

            else if (jogador.vida <= 0)
            {
                Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine("Você Morreu!");
                break;
            }
            else 
            {

                Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine("Você Venceu!"); 
                break;
            }
        }
    }
}
