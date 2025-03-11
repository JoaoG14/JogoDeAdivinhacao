namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
                Console.WriteLine("---------------------------------");

                Console.WriteLine("Escolha um nível de dificuldade:");
                Console.WriteLine("1 - Fácil   (10 tentativas)");
                Console.WriteLine("2 - Médio   (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");

                Console.WriteLine("Digite o número do nível de dificuldade: ");
                int nivelDificuldade = Convert.ToInt32(Console.ReadLine());

                int totalDeTenativas = 0;

                Random geradorNumeros= new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                if (nivelDificuldade == 1)
                {
                    totalDeTenativas = 11;
                }
                else if (nivelDificuldade == 2)
                {
                    totalDeTenativas = 6;
                }
                else if (nivelDificuldade == 3)
                {
                    totalDeTenativas = 4;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue;
                }

                for (int tentativa = 1; tentativa < totalDeTenativas; tentativa++)
                {    

                    Console.WriteLine("Tentativa " + tentativa + " de " + totalDeTenativas);
                    Console.WriteLine("Digite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O numero digitado foi: " + numeroDigitado);
                    Console.WriteLine("O numero secreto foi: " + numeroSecreto);

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou!");
                        break;
                    }
                    else if (tentativa > totalDeTenativas)
                    {
                        Console.WriteLine("Você perdeu! O número secreto era: " + numeroSecreto);
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("Que pena! Você errou! O número secreto é menor.");
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("Que pena! Você errou! O número secreto é maior.");
                    }
                    else
                    {
                        Console.WriteLine("Que pena! Você errou!");
                    }
                }

                Console.WriteLine("Deseja continaur? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if(opcaoContinuar == "N")
                {
                    break;
                }
            }
        }
    }
}
