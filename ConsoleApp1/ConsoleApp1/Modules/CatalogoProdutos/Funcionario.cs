namespace ConsoleApp1.Modules.CatalogoProdutos
{
    internal class Funcionario
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Digite um nome válido e tente novamente!");
                }
            }
        }

        private string _email;
        public string E_mail
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Digite um email válido e tente novamente!");
                }
            }
        }

        Funcionario(string nome, string email)
        {
            Nome = nome;
            E_mail = email;
        }

        public static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Cadastro funcionário <- ===");

            Console.Write("\nDigite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu email: ");
            string email = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, email);

            Console.Write("\nFuncionário registrado com sucesso! Aguarde...");
            Thread.Sleep(2000);
            Console.Clear();

            Produto.CadastrarProduto();
        } 

        public static void Run()
        {
            
            
        }
    }
}
