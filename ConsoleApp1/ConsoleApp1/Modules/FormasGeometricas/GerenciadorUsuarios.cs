namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class GerenciadorUsuarios
    {
        public static List<Usuario2> users = new List<Usuario2>();

        //Estrutura que associa uma chave a um valor. Ou seja, cada Usuario sera uma chave unica que estará associado a uma lista de formas (FormasGeometricasModule)
        public static Dictionary<Usuario2, List<FormaGeometrica>> formasPorUser = new();
        public static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Registrando user <- ===\n");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            Usuario2 userExistente = users.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);

            if (userExistente != null)
            {
                Console.WriteLine("User encontrado!");
                FormaGeometrica forma = FormasGeometricasModule.ExibirOpcoesFormas();

                //se a forma existir, associar ela ao user que acabou de se registrar
                if (forma != null)
                {
                    formasPorUser[userExistente].Add(forma);
                }

                Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nUser não encontrado. Criando novo cadastro...");
                Usuario2 novoUser = new Usuario2(nome, senha);

                users.Add(novoUser);
                formasPorUser[novoUser] = new List<FormaGeometrica>();

                FormaGeometrica forma = FormasGeometricasModule.ExibirOpcoesFormas();

                if (forma != null)
                {
                    formasPorUser[novoUser].Add(forma);
                }
                Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }

        //método que retorna a lista do usuario/key do dicionario. O papel de um metodo como esse, é devolver dados, e nao exibir nada na tela. Ou seja, esse metodo nao deve imprimir um cw dizendo q nao foi encontrado uma lista. No caso, ele retorna uma lista vazia pra nao dar erro e quebrar a execucao;
        public static List<FormaGeometrica> obterFormasUsuario(Usuario2 usuario)
        {
            if(formasPorUser.ContainsKey(usuario))
            {
                return formasPorUser[usuario]; //acessa a lista de formas associada a key/user do dicionario
            } else
            {
                return new List<FormaGeometrica>();
            }
        }

        public static void RemoverUsuario()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Removendo user <- ===\n");

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            //firstordefault eh basicamente, um metodo LINQ que busca o primeiro elemento dado uma condicao, e o retorna ou null.
            var userRemover = GerenciadorUsuarios.users.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);

            if(userRemover != null)
            {
                //remove na lista de users, e tb no dicionario. Remove o par (key e value)
                GerenciadorUsuarios.users.Remove(userRemover);
                GerenciadorUsuarios.formasPorUser.Remove(userRemover);
                Console.WriteLine($"\nUsuario {nome} removido com sucesso!");
                Thread.Sleep(1500);

                Console.WriteLine("\nDigite alguma tecla para voltar ao Menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
