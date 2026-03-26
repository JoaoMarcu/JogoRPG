using System;
using ArenaGame.Players;
using ArenaGame.Enemies;
using ArenaGame.Characters;

namespace ArenaGame.Gameplay
{
    public class Game
    {
        private Player jogador = null!;
        private Arte TelaDeInicio = null!;

        public List<Enemy> inimigos = new();

        public void StartGame()
        {
            TelaDeInicio = new Arte()
            { };
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
                atk = 2
            };

        }
        public void CreateEnemy()
        {
            Enemy inimigo1 = new Prisioneiro()
            {
                nome = ("Prisioneiro Faminto"),
                vidamax = 60,
                vida = 60,
                atk = 2
            };

            Enemy inimigo2 = new Lanceiro()
            {
                nome = ("Lanceiro com Escudo"),
                vidamax = 120,
                vida = 120,
                atk = 10
            };

            Enemy inimigo3 = new Campeao()
            {
                nome = ("Campeão da Arena"),
                vidamax = 120,
                vida = 120,
                atk = 12
            };

            inimigos.Add(inimigo1);
            inimigos.Add(inimigo2);
            inimigos.Add(inimigo3);
        }

        public static void Continue()
        {
            Console.Write("\nAperte enter para continuar:");
            Console.ReadLine();
            Console.Clear();
        }

        public void ShowActionsAndStats(Enemy inimigoAtual)
        {
            Console.Clear();
            string stats = $"||{jogador.nome} | Vida {jogador.vida}/{jogador.vidamax}||\n------------------------------------\n||{inimigoAtual.nome} | Vida {inimigoAtual.vida}/{inimigoAtual.vidamax}||\n------------------------------------\n";
            Console.WriteLine(stats);

            string options = "1.Atacar\n2.Defender\n3.Comer\n";
            Console.WriteLine(options);
            Console.Write("Escolha uma das opções:");
        }
        public void Combat()
        {
            foreach (Enemy inimigoAtual in inimigos)
            {

                while (jogador.EstaVivo() && inimigoAtual.EstaVivo())
                {
                    ShowActionsAndStats(inimigoAtual);

                    switch (int.Parse(Console.ReadLine()!))
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"{jogador.nome} ataca {inimigoAtual.nome} com sua espada!!\n");

                            jogador.Atacar(inimigoAtual);

                            Continue();


                            inimigoAtual.DecidirAção(jogador);

                            Continue();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine($"{jogador.nome}, está se defendendo!\n");

                            jogador.Defender();

                            Continue();


                            //Console.WriteLine($"{inimigoAtual.nome} tira uma seringa escondida e a lança contra {jogador.nome}, envenenando-o!\n\nO veneno causa 2 de dano todo turno.\n");

                            inimigoAtual.DecidirAção(jogador);

                            Continue();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine($"{jogador.nome} se sente revigorado, curou-se em 20!\n");

                            jogador.Curar();

                            Continue();


                            //Console.WriteLine($"{inimigoAtual.nome} ataca {jogador.nome} com suas correntes!!\n");

                            inimigoAtual.DecidirAção(jogador);

                            Continue();
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine($"{jogador.nome} escorrega e cai no chão!\n");

                            Console.WriteLine($"{inimigoAtual.nome} ataca {jogador.nome} com suas correntes!!\n");

                            inimigoAtual.DecidirAção(jogador);

                            Continue();
                            break;
                    }
                }
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


