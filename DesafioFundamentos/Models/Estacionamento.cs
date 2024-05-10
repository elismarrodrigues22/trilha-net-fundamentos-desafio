namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private int codigoVeiculo = 0;
        private List<string> veiculos = new List<string>();
        

       

        public Estacionamento(decimal precoInicial, decimal precoPorHora, int codigoVeiculo)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.codigoVeiculo = codigoVeiculo;

        }

        public void AdicionarVeiculo()
        {
           //Implementado!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            String placaEstacionar = Console.ReadLine();
            veiculos.Add(placaEstacionar);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();


            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                 valorTotal = this.precoInicial + precoPorHora * horas;

               
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                 Console.WriteLine("OS VEÍCULOS ESTACIONADOS SÃO : ");
                 int codigoVeiculo = 101;
                for(int cont =0; cont < veiculos.Count ; cont++)
                    {                                             
                        
                        Console.WriteLine($"Código do Veículo {codigoVeiculo} :   Placa : {veiculos[cont]} " );
                        codigoVeiculo++;
                    }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
