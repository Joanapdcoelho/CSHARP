
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Resources;


namespace BatalhaNaval
{
    internal class Program
    {

        //variável global
        static string[,] tabuleiro = new string[10, 10];//tabuleiro inicial
        static string[,] tabuleiro1 = new string[10, 10];//array bidimensional com 10 posições em x e 10 em y - jogador 1
        static string[,] tabuleiro2 = new string[10, 10];//jogador 2 - 10 posições
        static string[,] tabuleiro3 = new string[10, 10]; //tabuleiro adivinhar tabuleiro2
        static string[,] tabuleiro4 = new string[10, 10]; //tabuleiro adivinhar tabuleiro1
        static string[] submarinos = new string[8];//8 submarinos jogador 1        
        static string[] submarinos2 = new string[8];//8 submarinos jogador2
        static int x, y;

        static void Main(string[] args)
        {

            //variáveis
            string nome, nome2;
            int linha, coluna, barcos1 = 8, barcos2 = 8, tentativa, tentativa2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
            .______        ___   .___________.    ___       __       __    __       ___      
            |   _  \      /   \  |           |   /   \     |  |     |  |  |  |     /   \     
            |  |_)  |    /  ^  \ `---|  |----`  /  ^  \    |  |     |  |__|  |    /  ^  \    
            |   _  <    /  /_\  \    |  |      /  /_\  \   |  |     |   __   |   /  /_\  \   
            |  |_)  |  /  _____  \   |  |     /  _____  \  |  `----.|  |  |  |  /  _____  \  
            |______/  /__/     \__\  |__|    /__/     \__\ |_______||__|  |__| /__/     \__\ 
                                                                                 
            .__   __.      ___   ____    ____  ___       __                                  
            |  \ |  |     /   \  \   \  /   / /   \     |  |                                 
            |   \|  |    /  ^  \  \   \/   / /  ^  \    |  |                                 
            |  . `  |   /  /_\  \  \      / /  /_\  \   |  |                                 
            |  |\   |  /  _____  \  \    / /  _____  \  |  `----.                            
            |__| \__| /__/     \__\  \__/ /__/     \__\ |_______|
            
            Direitos reservados JOANA COELHO | 2022 
            ");

            SoundPlayer player = new SoundPlayer("bat_naval_ju.wav");
             player.Load();
             player.Play();
            Console.ReadKey();        

            Console.ForegroundColor = ConsoleColor.White;

            //============INÍCIO DO JOGO--------
            
            SoundPlayer barco = new SoundPlayer("navio.wav");
            barco.Load();
            barco.Play();
            
            Console.ReadKey();

            //==========INSERIR NOME JOGADOR1---------
            Console.WriteLine("Insira o nome do jogador1: ");
            nome = Console.ReadLine();
            Console.Clear();//Limpar

            //nome do jogo
            nome_jogo();
            //ver o nome do jogador 1 durante o tabuleiro com submarinos
            Console.WriteLine($" \nJogador 1: {nome}\n");

            //=========MOSTRAR TABULEIRO VAZIO-------
            mostra_tabuleiro(); //tabuleiro inicial

            for (linha = 0; linha <= 9; linha++)
            {
                for (coluna = 0; coluna <= 9; coluna++)
                {
                    //Colocar - nos tabuleiros
                    tabuleiro1[coluna, linha] = " - ";
                    tabuleiro2[coluna, linha] = " - ";
                    tabuleiro3[coluna, linha] = " - ";
                    tabuleiro4[coluna, linha] = " - ";
                }
            }

            //============ESCONDER OS SUBMARINOS JOGADOR 1------
            do
            {
                for (int i = 0; i < submarinos.Length; i++)
                {
                    Console.WriteLine("Onde pretende esconder os seus submarinos? \n");

                    confirma_linha_coluna();//entra na função
                    confirma_posicao_ocupada(1); //Caso não esteja ocupada                    
                    //sai e mete o D na posição inserida pelo utilizador
                    tabuleiro1[x, y] = " D ";

                    Console.Clear();

                    nome_jogo();
                    Console.WriteLine("");
                    Console.WriteLine($"Jogador 1: {nome}\n");

                    //=======tabuleiro1 - esconder os submarinos do jogador 1

                    Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
                    Console.WriteLine("--+--------------------------------");
                    for (linha = 0; linha <= 9; linha++)
                    {
                        Console.Write($"{linha} | ");

                        for (coluna = 0; coluna <= 9; coluna++)

                        {
                            if (tabuleiro1[coluna, linha] != " D ")//não tem submarino
                            {
                                tabuleiro1[coluna, linha] = " - ";//coloca linha
                                Console.Write($"{tabuleiro1[coluna, linha]}");//mostra
                            }
                            else
                            {
                                Console.Write($"{tabuleiro1[coluna, linha]}");//mostra
                            }
                        }
                        Console.WriteLine();
                    }
                }
            } while (submarinos.Length < 8);

            Console.Clear(); //limpar tudo
            nome_jogo();

            //==================INSERIR NOME JOGADOR 2---------
            Console.WriteLine("Insira o nome do jogador2: ");
            nome2 = Console.ReadLine();
            Console.Clear();//Limpar

            nome_jogo();

            //ver o nome do jogador 2 durante o tabuleiro com submarinos
            Console.WriteLine($" \nJogador 2: {nome2}\n");

            //tabuleiro vazio
            mostra_tabuleiro();

            //=========ESCONDER OS SUBMARINOS JOGADOR 2------

            do
            {
                for (int i = 0; i < submarinos2.Length; i++) //até ao comprimento do array submarinos2 - são 8
                {
                    Console.WriteLine("Onde pretende esconder os seus submarinos? \n");
                    confirma_linha_coluna();
                    confirma_posicao_ocupada(2);
                    //Caso não esteja ocupada                    
                    //sai e mete mete o D na posição inserida pelo utilizador
                    tabuleiro1[x, y] = " D ";

                    Console.Clear();//limpar

                    //========
                    nome_jogo();
                    //nome do jogador 2-----
                    Console.WriteLine("");
                    Console.WriteLine($" \nJogador 2: {nome2}\n");

                    //======tabuleiro2 - esconder os submarinos do jogador 2------
                    tabuleiro2[x, y] = " D ";
                    //Console.ReadKey();

                    Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
                    Console.WriteLine("--+--------------------------------");
                    for (linha = 0; linha <= 9; linha++)
                    {
                        Console.Write($"{linha} | ");

                        for (coluna = 0; coluna <= 9; coluna++)

                        {
                            //Se tiver um submarino «D» 
                            if (tabuleiro2[coluna, linha] != " D ")
                            {
                                tabuleiro2[coluna, linha] = " - ";
                                Console.Write($"{tabuleiro2[coluna, linha]}");
                            }
                            else
                            {
                                Console.Write($"{tabuleiro2[coluna, linha]}");
                            }
                        }
                        Console.WriteLine("");
                    }
                }

            } while (submarinos2.Length < 8);//até aos 8 submarinos

            //==============LIMPAR /ESCONDER TABULEIRO DO JOGADOR 2---------
            Console.Clear();
            nome_jogo();

            //========Ciclo para repetir o jogo até algum jogador ter completado os 8 submarinos
            do
            {
                //====JOGADOR 1 --3 TENTATIVAS DESCOBRIR SUBMARINOS JOGADOR2========
                tentativa = 3;

                //tabuleiro 3 para as tentativas do jogador 1 no tabuleiro 2
                do
                {

                    //NOME DO JOGO
                    nome_jogo();
                    Console.WriteLine(" ");

                    //===============MOSTRAR TABULEIRO LIMPO------

                    Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
                    Console.WriteLine("--+--------------------------------");
                    for (linha = 0; linha <= 9; linha++)
                    {
                        Console.Write($"{linha} | ");
                        for (coluna = 0; coluna <= 9; coluna++)
                        {

                            Console.Write($"{tabuleiro3[coluna, linha]}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");

                    Console.WriteLine($"Jogador 1: {nome} tem {tentativa} tentativas para acertar ");

                    Console.WriteLine($"{nome} Insira as coordenadas\n ");
                    confirma_linha_coluna();

                    Console.WriteLine("");

                    //SE ACERTAR «X» É FOGO SE FALHAR «O» É ÁGUA
                    if (tabuleiro2[x, y] == " D ") //Se tiver submarino «D» no tabuleiro 2 
                    {
                        tabuleiro3[x, y] = " X "; //faz X no tabuleiro 3
                                                  //
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FOGO!!");//escreve fogo a vermelho
                        SoundPlayer fire = new SoundPlayer("bomba.wav");
                        fire.Load();
                        fire.Play();

                        Console.ForegroundColor = ConsoleColor.White; //limpa cor e mete a branco
                        //Console.WriteLine("");

                        //tiro aos barcos do jogador 2
                        barcos2--; //menos um barco do jogador 2

                        Console.WriteLine($"Submarinos1: {barcos1}\n Submarinos2: {barcos2}");
                        Console.WriteLine($"Pressione uma tecla para continuar! ");
                        Console.ReadKey();
                    }
                    else
                    {
                        tabuleiro3[x, y] = " O ";//escreve O no tabuleiro3 

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("ÁGUA!");//escreve água a azul
                        SoundPlayer agua = new SoundPlayer("Splash.wav");
                        agua.Load();
                        agua.Play();

                        Console.ForegroundColor = ConsoleColor.White;//limpa fica a branco a letra
                        Console.WriteLine("");
                        Console.WriteLine($"Pressione uma tecla para continuar! ");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    tentativa--;//mais uma tentativa de acertar
                    Console.WriteLine($"Tentativa: {tentativa}\n ");

                    Console.Clear();

                } while (tentativa > 0 && barcos2 != 0);//até 3 tentativas

                Console.Clear(); //<----Esconder o tabuleiro               

                //=======JOGADOR 2 ->3 TENTATIVAS DESCOBRIR SUBMARINOS JOGADOR 1

                tentativa2 = 3;

                while (tentativa2 > 0 && barcos1 != 0 && barcos2 != 0) // caso o jogador 1 ainda nao tiver ganho
                {
                    do
                    {
                        //NOME DO JOGO
                        nome_jogo();
                        Console.WriteLine(" ");

                        //==============MOSTRAR TABULEIRO LIMPO -4 =========

                        Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
                        Console.WriteLine("--+--------------------------------");
                        for (linha = 0; linha <= 9; linha++)
                        {
                            Console.Write($"{linha} | ");
                            for (coluna = 0; coluna <= 9; coluna++)
                            {
                                Console.Write($"{tabuleiro4[coluna, linha]}");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\n");

                        Console.WriteLine($"Jogador 2: {nome2} tem {tentativa2} tentativas para acertar ");

                        Console.WriteLine($"{nome2} Insira as coordenadas\n ");
                        confirma_linha_coluna();

                        Console.WriteLine("");

                        if (tabuleiro1[x, y] == " D ") //Se tiver submarino «D» no tabuleiro 1 
                        {

                            tabuleiro4[x, y] = " X "; //faz X no tabuleiro 4             
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("FOGO!!");//escreve fogo a vermelho
                            SoundPlayer fire = new SoundPlayer("bomba.wav");
                            fire.Load();
                            fire.Play();
                            Console.ForegroundColor = ConsoleColor.White; //limpa cor e mete a branco
                            //Console.WriteLine("\n");
                            //tiro aos barcos do jogador 1
                            barcos1--; //menos um barco do jogador 1

                            Console.WriteLine($"Submarinos1: {barcos1} \n Submarinos 2: {barcos2} ");
                            Console.WriteLine($"Pressione uma tecla para continuar! ");
                            Console.ReadKey();

                        }
                        else
                        {
                            tabuleiro4[x, y] = " O ";//escreve O no tabuleiro3 
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("ÁGUA!");//escreve água a azul
                            SoundPlayer agua = new SoundPlayer("Splash.wav");
                            agua.Load();
                            agua.Play();
                            Console.ForegroundColor = ConsoleColor.White;//limpa fica a branco a letra
                            Console.WriteLine($"Pressione uma tecla para continuar! ");
                            Console.ReadKey();
                        }
                        tentativa2--;
                        Console.Clear();

                    } while (tentativa2 > 0 && barcos1 != 0);

                }

            } while (barcos1 != 0 && barcos2 != 0);

            Console.Clear(); //limpa e mostra o parabéns

            Console.ForegroundColor = ConsoleColor.Green;
            if (barcos2 == 0)
            {
                Console.WriteLine($"Parabéns! {nome} Ganhou!!!");//caso ganhe jogador1
                SoundPlayer aplause = new SoundPlayer("Board Room Applause.wav");
                aplause.Load();
                aplause.Play();
            }
            else
            {
                Console.WriteLine($"Parabéns! {nome2} Ganhou!!!");//caso ganhe jogador2
                SoundPlayer aplause1 = new SoundPlayer("Board Room Applause.wav");
                aplause1.Load();
                aplause1.Play();
            }


            Console.ReadKey();

        }


        static void nome_jogo()
        {
            Console.WriteLine(" \n ========JOGO DA BATALHA NAVAL=========\n ");
        }

        static void mostra_tabuleiro()
        {
            int linha, coluna;

            Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--+--------------------------------");
            for (linha = 0; linha <= 9; linha++)
            {
                Console.Write($"{linha} | ");
                for (coluna = 0; coluna <= 9; coluna++)
                {
                    tabuleiro[coluna, linha] = " - ";

                    Console.Write($"{tabuleiro[coluna, linha]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void confirma_linha_coluna()
        {
            Console.WriteLine("Insira a linha: ");
            y = int.Parse(Console.ReadLine());

            while (y < 0 || y > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um número entre 0 e 9!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Insira a linha: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insira a coluna: ");
            x = int.Parse(Console.ReadLine());

            while (x < 0 || x > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um número entre 0 e 9!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Insira a coluna: ");
                x = int.Parse(Console.ReadLine());
            }
        }

        static void confirma_posicao_ocupada(int jogador)
        {

            if (jogador == 1)//para o jogador 1 
            {
                while (tabuleiro1[x, y] == " D ")//se já estiver ocupada
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa posição já está ocupada! Insira novamente!");
                    Console.ForegroundColor = ConsoleColor.White;
                    confirma_linha_coluna();//entra novamente na função e pede tudo de novo até que não esteja ocupada
                }
            }
            else //para o jogador 2
            {

                while (tabuleiro2[x, y] == " D ")//se já estiver ocupada
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa posição já está ocupada! Insira novamente!");
                    Console.ForegroundColor = ConsoleColor.White;
                    confirma_linha_coluna();//entra novamente na função e pede tudo de novo até que não esteja ocupada
                }
            }
        }

    }
}
