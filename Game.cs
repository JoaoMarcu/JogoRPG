using System.Runtime.InteropServices;
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
        jogador.atk = 10;

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

            if (inimigo1.vida > 0)
            {
                string ini1N = inimigo1.nome;
                int ini1V = inimigo1.vida;
                int iniA = inimigo1.atk;

                string jogN = jogador.nome;
                int jogV = jogador.vida;
                int jogA = jogador.atk;

                int dano1 = ini1V - jogA;
                int dano2 = jogV - iniA;

                Console.WriteLine($"{jogN} causou {jogA} de dano em {ini1N}");
                Console.WriteLine($"vida restante de {ini1N}: {dano1}");

                Console.Write("Clique enter:"); Console.ReadLine();

                Console.WriteLine($"{ini1N} causou {iniA} de dano no {jogN}");
                Console.WriteLine($"vida restante de {jogN}: {dano2}");

                Console.Write("Clique enter:"); Console.ReadLine();

                inimigo1.vida = inimigo1.vida - jogador.atk;
                jogador.vida = jogador.vida - inimigo1.atk;
            }
            else
            {
                break;
            }

            
        }
    }
}
