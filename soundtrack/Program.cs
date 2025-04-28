


string mensagem = "Boas vindas ao SoundTrack!";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░  ████████╗██████╗░░█████╗░░█████╗░██╗░░██╗
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗  ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██║░██╔╝
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║  ░░░██║░░░██████╔╝███████║██║░░╚═╝█████═╝░
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║  ░░░██║░░░██╔══██╗██╔══██║██║░░██╗██╔═██╗░
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝  ░░░██║░░░██║░░██║██║░░██║╚█████╔╝██║░╚██╗
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝");

    Console.WriteLine(mensagem);

}
void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma nova banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas cadastradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de avaliação de uma banda");
    Console.WriteLine("Digite 0 para sair do programa");
    Console.Write("\nDigite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            RegistrarBanda();
            break;
        case "2":
            MostrarBandasCadastradas();
            break;
        case "3":
            AvaliarBanda();
            break;
        case "4":
            ExibirMediaAvaliacoes();
            {

            }
            break;
        case "0":
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            ExibirMenu();
            Thread.Sleep(2000);
            Console.Write("\n\n\n");
            break;
    }

}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar nova banda");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"Banda {nomeBanda} cadastrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
void MostrarBandasCadastradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas cadastradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write("Digite a nota de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota >= 0 && nota <= 10)
        {
            bandasRegistradas[nomeBanda].Add(nota);
            Console.WriteLine($"\nAvaliação da banda {nomeBanda} registrada com sucesso!");
            Thread.Sleep(4000);
            ExibirMenu();
        }
        else
        {
            Console.WriteLine("Nota inválida, deve ser entre 0 e 10.");
        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não está cadastrada.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();

        ExibirMenu();

    }
}
void ExibirMediaAvaliacoes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média de notas da banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {

        List<int> notas = bandasRegistradas[nomeBanda];
        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"A média de avaliações da banda {nomeBanda} é: {media:F2}");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            ExibirMenu();
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} ainda não possui avaliações.");
        }
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não está cadastrada.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        ExibirMenu();

    }
}
void ExibirTituloDaOpcao(string titulo)
{

    int quantidadeDeLetras = titulo.Length;
    string igual = string.Empty.PadLeft(quantidadeDeLetras, '=');
    Console.WriteLine(igual);
    Console.WriteLine(titulo);
    Console.WriteLine(igual + "\n");
}


ExibirMenu();