//diz que a classe CadastroModule pertence ao pacote ConsoleApp1.Modules.CadastroUsuarios
namespace ConsoleApp1.Modules.CadastroUsuarios
{
    public class CadastroModule
    {
        static List<Usuario> listaUsuarios = new List<Usuario>();
        public static void Run()
        {
            bool rodar = true;
            Console.Clear();
            while (rodar)
            {
                Console.WriteLine("=== MENU CADASTRO DE USUARIOS ===");
                Console.WriteLine("1 - Cadastrar user");
                Console.WriteLine("2 - Listar users");
                Console.WriteLine("3 - Remover users");
                Console.WriteLine("4 - Aprendizado deste exercicio");
                Console.WriteLine("0 - Voltar ao Menu");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CadastrarUser(); break;

                    case 2:
                        ListarUsers(); break;

                    case 3:
                        RemoverUsers(); break;

                    case 4:
                        Aprendizado(); break;

                    case 0:
                        rodar = false; Console.Clear(); break;
                }
            }
        }

        public static void CadastrarUser()
        {
            Console.Clear();
            //pedindo os dados
            Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Cadastrando User <- ===\n");
            Console.Write("Digite o nome do usuario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.Write("Digite o seu E-mail: ");
            string email = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            //criando o objeto de Usuario e adicionando na lista
            Usuario user = new Usuario(nome, email, idade);
            listaUsuarios.Add(user);

            Console.Write("\nUsuario criado com sucesso!");
            Console.WriteLine("\nAguarde...");
            Thread.Sleep(3000);
            Console.Clear();
        }

        public static void ListarUsers()
        {
            var cont = 1;

            if(listaUsuarios.Count == 0 )
            {
                Console.Clear();
                Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Listando Users <- ===\n");
                Console.WriteLine("Lista vazia!");
                Console.WriteLine("Aguarde...");
                Thread.Sleep(3000);
                Console.Clear();
            } else
            {
                Console.Clear();
                Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Lista de Usuarios <- ===\n");
                foreach (var user in listaUsuarios)
                {
                    Console.WriteLine($"{cont} - {user.Nome}");
                    cont++;
                }

                Console.Write("\nEscolha um usuário: ");
                int esc = int.Parse(Console.ReadLine());
                esc--;
                if (esc>=0 && esc < listaUsuarios.Count)
                {
                    Console.Clear();
                    //se o user escolhe o user 1, precisamos acessar esse user que ta na posicao 0 do index da lista;
                    Console.WriteLine($"=== MENU CADASTRO DE USUARIOS -> Dados user: {listaUsuarios[esc].Nome} <- ===\n");
                    Console.WriteLine($"Email: {listaUsuarios[esc].Email}");
                    Console.WriteLine($"Idade: {listaUsuarios[esc].Idade}");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nPressione uma tecla para voltar ao Menu...");
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    Console.WriteLine("Opção inválida!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        public static void RemoverUsers()
        {
            var cont = 1;
            if (listaUsuarios.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Removendo Users <- ===\n");
                Console.WriteLine("Lista vazia!");
                Console.WriteLine("Aguarde...");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("MENU CADASTRO DE USUARIOS -> Lista de usuários\n");
                foreach (var user in listaUsuarios)
                {
                    Console.WriteLine($"{cont} - {user.Nome}");
                    cont++;
                }
                Console.WriteLine("\nEscolha uma user para remover da lista");
                var op = int.Parse(Console.ReadLine());
                op--;

                if(op>=0 && op < listaUsuarios.Count)
                {
                    string nomeRemovido = listaUsuarios[op].Nome;
                    listaUsuarios.RemoveAt(op); //removendo um item da lista pelo indice
                    Console.WriteLine($"{nomeRemovido} removido da lista!");
                    Console.WriteLine("\nPressione uma tecla para voltar ao Menu...");
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    Console.WriteLine("Escolha uma opção válida!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        public static void Aprendizado()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Aprendizado <- ===\n");
            Console.WriteLine("1 - Criação e uso de classes para modelagem de dados;\n2 - Construtores personalizados para inicializar objetos com valores;\n3 - Encapsulamento com get e set;\n4 - Manipulação de listas dinâmicas (List<T>);\n5 - Laços de repetições;\n6 - Controle de fluxo com switch, if/else e validações de entrada do user;\n");
            Console.WriteLine("\nPressione uma tecla para voltar ao Menu...");
            Console.ReadKey();
            Console.Clear();
        }
        

    }
}
