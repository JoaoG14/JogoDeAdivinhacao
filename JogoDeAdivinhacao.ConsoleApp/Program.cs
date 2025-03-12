namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
                Console.WriteLine("---------------------------------");

                Console.WriteLine("Escolha um nível de dificuldade:");
                Console.WriteLine("1 - Fácil   (10 tentativas)");
                Console.WriteLine("2 - Médio   (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.Write("Digite o número do nível de dificuldade: ");

                if (!int.TryParse(Console.ReadLine(), out int nivelDificuldade))
                {
                    Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                int totalDeTentativas;
                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                switch (nivelDificuldade)
                {
                    case 1: totalDeTentativas = 10; break;
                    case 2: totalDeTentativas = 5; break;
                    case 3: totalDeTentativas = 3; break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        continue;
                }

                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.Write("Digite um número: ");

                    if (!int.TryParse(Console.ReadLine(), out int numeroDigitado))
                    {
                        Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        continue;
                    }

                    Console.WriteLine($"O número digitado foi: {numeroDigitado}");

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou!");
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("Que pena! Você errou! O número secreto é menor.");
                    }
                    else
                    {
                        Console.WriteLine("Que pena! Você errou! O número secreto é maior.");
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

                Console.WriteLine($"O número secreto era: {numeroSecreto}");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar == "N")
                {
                    break;
                }
            }
        }
    }
}
