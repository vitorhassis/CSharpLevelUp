
namespace ConsoleApp1.Modules.CatalogoProdutos
{
    public class Produto
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Digite um nome válido!\n");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public double _preco;

        public double Preco
        {
            get { return _preco; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor válido!");
                }
                else
                {
                    _preco = value;
                }
            }

        }
        public string DataValidade { get; set; }

        public Produto (string nome, double preco, string dataValidade)
        {
            _nome = nome;
            _preco = preco;
            DataValidade = dataValidade;
        }  

        public static void CadastrarProduto()
        {
            Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Registrando Produto <- ===");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a data de validade do produto: ");
            string dataVal = Console.ReadLine();

            Produto produto = new Produto (nome, preco, dataVal);
            CatalogoModule.Catalogo.Add (produto);

            Console.Write("\nCadastro do produto finalizado! Aguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            CatalogoModule.Run();
          
        }
    }
}
