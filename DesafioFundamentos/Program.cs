using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


bool exibirMenu = true;
ConsoleKeyInfo keyInfo;


// Realiza o loop do menu
while (exibirMenu)
{
    
    Console.Clear();
    Console.WriteLine("\n***********  Menu  *************\n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

     
    Console.Write("Digite a sua opção:");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"IMPORTANTE!! Custo Estacionamento: {precoInicial:C} -  acrescido {precoPorHora:C} por hora.\n");
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
      
   
   // Garantindo que o programa só continue se usuário digitar a tecla ENTER 
   if(exibirMenu){
    Console.WriteLine("\n");
        do
        {
            Console.WriteLine("Pressione a tecla ENTER para continuar");
            keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }

        } while (true);
   }
    
  
}

Console.WriteLine("O programa se encerrou");
