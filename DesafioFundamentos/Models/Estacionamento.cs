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

        // IMPLEMENTADO

        {
            Console.WriteLine("Digite a placa do veículo para cadastro:");
            string placa = Console.ReadLine();

            if (veiculos.Any(v => v.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Identificamos um veículo com essa placa em nossa base de dados!");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Fique à vontade para estacionar. Liberado");
            }
        }

        public void RemoverVeiculo()

        // IMPLEMENTADO
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

               // Verifica se o veiculo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());


                //  IMPLEMENTADO

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                // IMPLEMENTADO

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veiculos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos listados em nosso estacionamento são:");

                 // IMPLEMENTADO

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não localizamos veículos estacionados.");
            }
        }
    }
}