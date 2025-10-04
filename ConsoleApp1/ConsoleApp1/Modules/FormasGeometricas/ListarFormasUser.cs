
namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class ListarFormasUser
    {
        private Usuario2 user = null;
        public void ValidacaoUser()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Listar formas pelo user <- ===\n");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            //“Procure na lista de usuários o primeiro que tenha o nome e a senha iguais aos digitados. Se encontrar, atribua esse usuário à variável user. Se não encontrar, user vai ficar com null.”, Usamos o método LINQ para essa busca

            user = GerenciadorUsuarios.users.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);

            if (user != null)
            {
                Console.Clear();
                Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Listar formas pelo user <- ===\n");

                var formasUser = GerenciadorUsuarios.obterFormasUsuario(user);

                if (formasUser.Count == 0)
                {
                    Console.WriteLine("\nEsse usuário ainda não registrou nenhuma forma!");
                }
                else
                {
                    foreach (var f in formasUser)
                    {
                        f.ExibirDados();
                        Console.WriteLine("\n");
                    }
                }

                Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("User não presente no sistema! Volte para o menu e cadastre-se!");
                Thread.Sleep(1500);
                Console.Write("\nDigite uma tecla para voltar ao menu... ");
                Console.ReadKey();
                Console.Clear();
            }
        }


        //aq eu tenho um metodo que basicamente vai exibir a key (users) com o seu value (lista de formas) do dicionario. Primeiro, eu faco uma verificacao pra ver se existe algo no dicionario. Se a quantidade de elementos do dicionario nao for 0, ou seja, se tiver algo, eu vou percorrer o par do dicionario (par = key + value associado). Crio duas variaveis, "usuario" que vai receber a chave do par, e "listaFormas" que vai receber o value do par. Faco outro if, e por fim, no else, faco um foreach percorrendo cada forma da lista de formas (value da key). bem simples de se entender
        public void ListarTodosUsuariosEFormas()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Listando todos os users e suas formas criadas <- ===\n");

            if(GerenciadorUsuarios.formasPorUser.Count == 0)
            {
                Console.WriteLine("Nenhum user registrou formas ainda!");
                Thread.Sleep(1500);
                Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            } else
            {
                foreach (var par in GerenciadorUsuarios.formasPorUser)
                {
                    var usuario = par.Key;
                    var listaFormas = par.Value;

                    Console.WriteLine($"Usuario {usuario.Nome}");

                    if(listaFormas.Count == 0)
                    {
                        Console.WriteLine($"{usuario.Nome} não registrou nenhuma forma!");
                    } else
                    {
                        foreach (var f in listaFormas)
                        {
                            f.ExibirDados();
                            Console.WriteLine("\n");
                        }
                    }
                    Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
