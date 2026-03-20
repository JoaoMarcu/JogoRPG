using System;
public class Game
{
    Player jogador;

    Enemy inimigo1;

    Arte TelaDeInicio;

    public void StartGame()
    {
        TelaDeInicio = new Arte()
        {};
        TelaDeInicio.ExibirArte();
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
            atk = 8
        };

    }
    public void CreateEnemy()
    {
        inimigo1 = new Enemy()
        {
            nome = ("Prisioneiro Faminto"),
            vidamax = 60,
            vida = 60,
            atk = 6,
        };
    }

    public void next()
    {
        Console.Write("\nAperte enter para continuar:");
        Console.ReadLine();
        Console.Clear();
    }

    public void ShowActionsAndStats() 
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
                    Console.Clear();
                    Console.WriteLine($"{jogador.nome} ataca {inimigo1.nome} com sua espada!!\n");

                    jogador.Atacar(inimigo1);

                    next();


                    Console.WriteLine($"{inimigo1.nome} ataca {jogador.nome} com suas correntes!!\n");

                    inimigo1.Atacar(jogador);

                    next();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"{jogador.nome}, está se defendendo!\n");

                    jogador.Defender();

                    next();


                    Console.WriteLine($"{inimigo1.nome} tira uma seringa escondida e a lança contra {jogador.nome}, envenenando-o!\n\nO veneno causa 2 de dano todo turno.\n");

                    inimigo1.Envenenar(jogador);

                    next();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"{jogador.nome} se sente revigorado, curou-se em 20!\n");

                    jogador.Curar();

                    next();


                    Console.WriteLine($"{inimigo1.nome} ataca {jogador.nome} com suas correntes!!\n");

                    inimigo1.Atacar(jogador);

                    next();
                    break;
                
                default:
                    Console.Clear();

                    Console.WriteLine($"{jogador.nome} escorrega e cai no chão!\n");

                    Console.WriteLine($"{inimigo1.nome} ataca {jogador.nome} com suas correntes!!\n");

                    inimigo1.Atacar(jogador);

                    next();
                    break;
            }
        }
    }
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


