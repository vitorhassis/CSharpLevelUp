using System.Linq;
using System.Reflection.Metadata;
using ConsoleApp1.Modules.CadastroUsuarios;

namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class User
    {
        public static List<User> Users = new List<User>();
        //Esse código define uma propriedade Nome que controla o acesso ao campo privado _nome. Quando alguém tenta ler (get), retorna o valor atual. Quando tenta definir (set), só permite a alteração se o valor não for nulo, vazio ou composto apenas por espaços. Caso contrário, exibe uma mensagem de erro e não altera o valor. Isso garante que o nome armazenado sempre seja válido.
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

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _senha = value;
                }
                else
                {
                    Console.WriteLine("Digite um email válido e tente novamente!");
                }
            }
        }

        public User (string nome, string senha)
        {
            _nome = Nome;
            _senha = Senha;
        }

        public static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Registrando user <- ===\n");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            User user = new User(nome, senha);

            bool jaExiste = Users.Any(user => user.Senha == senha); //método da linq que verifica se existe pelo menos um elemento na lista que satisfaça uma condição;

            if (!jaExiste)
            {
                Console.WriteLine("User registrado! Aguarde...");
                Thread.Sleep(1500);
                Users.Add(user);
            } else
            {
                Console.WriteLine($"Bem-vindo de volta, {user.Nome}!");
            }

        }
    }
}

