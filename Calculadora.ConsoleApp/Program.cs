// See https://aka.ms/new-console-template for more information

string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;

while (true == true)
{

    Console.Clear();
    Console.WriteLine("-------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("-------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Escolha uma opção válida!");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Digite ENTER para sair...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("-------------------------");
        Console.Write("Digite um número inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        Console.WriteLine(numeroDigitado);

        for (int iterador = 1; iterador <= 10; iterador = iterador + 1)
        {
            string linhaTabuada = $"{numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }
        return;
    }

    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("-------------------------");

        for (int iterador = 0; iterador < historicoOperacoes.Length; iterador++)
        {
            if (historicoOperacoes[iterador] != null)
            {
                Console.WriteLine(historicoOperacoes[iterador]);
            }
        }

        Console.WriteLine("Digite ENTER para sair...");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();

    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;
    string textoOperacao;

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }
    else
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";

    }

    historicoOperacoes[contadorOperacoes] = textoOperacao;
    contadorOperacoes++;

    Console.WriteLine("O resultado é: " + resultado);
    Console.ReadLine();
}