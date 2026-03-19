
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
        jogador = new Player()
        {
            nome = ("Gladiador"),
            vidamax = 100,
            vida = 100,
            atk = 2
        };

    }
    public void CreateEnemy()
    {
        inimigo1 = new Enemy()
        {
            nome = ("Prisioneiro Faminto"),
            vidamax = 40,
            vida = 40,
            atk = 3,
        };
    }

    public void ShowActionsAndStats () 
    {
        string stats = $"||{jogador.nome} | Vida {jogador.vida}/{jogador.vidamax}||\n------------------------------------\n||{inimigo1.nome} | Vida {inimigo1.vida}/{inimigo1.vidamax}||\n------------------------------------\n";
        Console.WriteLine(stats);

        string options = "1.Atacar\n2.Defender\n3.Comer\n";
        Console.WriteLine(options);
        Console.Write("Escolha uma das opções:");
    }
    public void Combat()
    {
        while (jogador.EstaVivo() && inimigo1.EstaVivo())
        {
            ShowActionsAndStats();

            switch (int.Parse(Console.ReadLine()!)) 
            {
                case 1:

                    jogador.Atacar(inimigo1);

                    Console.Clear();
                    Console.WriteLine($"{jogador.nome} ataca {inimigo1.nome} com sua espada!!\n");
                    Console.Write("Aperte enter para continuar:");
                    Console.ReadLine();
                    Console.Clear();

                    inimigo1.Atacar(jogador);
                    Console.WriteLine($"{inimigo1.nome} ataca {jogador.nome} com suas correntes!!\n");
                    Console.Write("Aperte enter para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:

                    jogador.Defender();

                    Console.Clear();
                    Console.WriteLine($"{jogador.nome}, está se defendendo!\n");
                    Console.Write("Aperte enter para continuar:");
                    Console.ReadLine();
                    Console.Clear();

                    inimigo1.Envenenar(jogador);
                    Console.WriteLine($"{inimigo1.nome} tira uma seringa escondida e a lança contra {jogador.nome}, envenenando-o!\nO veneno causa 2 de dano todo turno.\n");
                    Console.Write("Aperte enter para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }


                //Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                //Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                //Console.Write("Clique enter:"); Console.ReadLine();

                //Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                //Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                //Console.Write("Clique enter:"); Console.ReadLine();
            

            
            
                //Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                //Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                //Console.Write("Clique enter:"); Console.ReadLine();

                //Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                //Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                //Console.Write("Clique enter:"); Console.ReadLine();

                //Console.WriteLine("Você Morreu!");
             

                //Console.WriteLine($"{jogador.nome} causou {jogador.atk} de dano em {inimigo1.nome}");
                //Console.WriteLine($"{inimigo1.nome} causou {inimigo1.atk} de dano no {jogador.nome}");

                //Console.Write("Clique enter:"); Console.ReadLine();

                //Console.WriteLine($"vida restante de {jogador.nome}: {jogador.vida}");
                //Console.WriteLine($"vida restante de {inimigo1.nome}: {inimigo1.vida}");

                //Console.Write("Clique enter:"); Console.ReadLine();

                //Console.WriteLine("Você Venceu!"); 
        
        }
    }
}
