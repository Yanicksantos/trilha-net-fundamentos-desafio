namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine ();
            if(placa.Any()){
                veiculos.Add(placa);
                Console.Write("Veiculo cadastrado com sucesso!!");
            }else{
                Console.WriteLine("Precisa adicionar uma placa antes!");
                AdicionarVeiculo();
            } 
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                int horas = 0;
                bool entradaHorasValida  = false;
                do{
                    Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                    entradaHorasValida = int.TryParse(Console.ReadLine(), out horas);
                    if(entradaHorasValida){
                        break;
                    }
                    Console.WriteLine("Quantidades de horas inválida!");
                }while(!entradaHorasValida);
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
               foreach (string veiculo in veiculos){
                    Console.WriteLine(veiculo);
               }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
