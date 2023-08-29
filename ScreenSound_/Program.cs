

List<string> listaBandas = new List<string> { "The Score", "Imagine Dragons", "Glass Animals" };


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound v1.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: BandasRegistradas();        
            break;
        case 3: 
            
            break;
        case 4:
            //Console.WriteLine("Você escolheu a opcão " + opcaoEscolhidaNumerica);
            break;
        case 5:
            //Console.WriteLine("Você escolheu a opcão " + opcaoEscolhidaNumerica);
            break;
        case -1:
            //Console.WriteLine("Você escolheu a opcão " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção inválida.");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Registrar Banda");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda); //push -> add
    Console.WriteLine($"A banda {nomeBanda} foi registrada!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void BandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcoes("Bandas Registradas");

    foreach (string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    } 

    Console.WriteLine("\nDigite uma tecla para retornar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}


ExibirOpcoesDoMenu();
RegistrarBanda();