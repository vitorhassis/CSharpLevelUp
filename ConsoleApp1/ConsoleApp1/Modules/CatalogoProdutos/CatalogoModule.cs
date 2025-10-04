//diz que a classe CadastroModule pertence ao pacote ConsoleApp1.Modules.CadastroUsuarios
//diz que a classe CatalogoModule pertence ao pacote ConsoleApp1.Modules.CatalogoProdutos
using ConsoleApp1.Modules.FormasGeometricas;

namespace ConsoleApp1.Modules.CatalogoProdutos
{
    //define a classe
    public class CatalogoModule
    {
        public static List<Produto> Catalogo = new List<Produto>
        {
            new Produto("Leite Integral", 5.49, "10/06/2023"),
            new Produto("Arroz Tipo 1 (5kg)", 22.90, "05/07/2024"),
            new Produto("Presunto Fatiado 200g", 8.99, "24/11/2022"),
            new Produto("Café Torrado e Moído 500g", 14.75, "12/12/2025"),
            new Produto("Óleo de Soja 900ml", 6.80, "28/02/2026"),
            new Produto("Macarrão Espaguete 1kg", 4.99, "15/08/2025"),
            new Produto("Queijo Mussarela 300g", 17.60, "02/10/2026"),
            new Produto("Iogurte Natural 170g", 2.89, "01/09/2023")
        };

        public static void ExibirProdutos()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CATALOGO -> Exibindo produtos <- ===\n");

            foreach (var produto in Catalogo)
            {
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preco: R$ {produto.Preco}");
                Console.WriteLine($"Data validade: {produto.DataValidade}");
                Console.WriteLine("\n");
            }
            Console.Write("Digite uma tecla para voltar ao menu... ");
            Console.ReadKey();
            Console.Clear();
            Run();
        }

        public static void MediaProdutos()
        {
            var mediaPrecoValores = Catalogo.Average(produto => produto.Preco); 

            Console.Clear();
            Console.WriteLine("=== MENU CADASTRO DE USUARIOS -> Media valores produtos <- ===\n");

            Console.WriteLine("Valores dos produtos :\n");

            bool pularEspera = true;

            foreach (var produto in Catalogo)
            {
                Console.WriteLine($"{produto.Nome} -> R${produto._preco}");
            }

            Thread.Sleep(1000);
            Console.WriteLine($"\nMedia dos valores = R${mediaPrecoValores:F2}");
            Thread.Sleep(2000);
            Console.Write("\nDigite uma tecla para voltar ao menu... ");
            Console.ReadKey();
            Console.Clear();
            Run();
        }

        //aq basicamente, "produtosVencidos" eh uma lista, que vai receber os objetos da lista "Catalogo". O filtro sera feito da seguinte maneira, essa lista vai receber os produtos onde (WHERE) a data de validade (convertemos o atributo "DataValidade" de string, para DateTime) for maior ou igual a data atual do sistema (DateTime.Now)
        public static void FiltrarPorDataValidade()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CATALOGO -> Filtrando por data de validade <- ===\n");

            var produtosVencidos = Catalogo.Where(produto => DateTime.Parse(produto.DataValidade) < DateTime.Now).ToList();
            var produtosNaoVencidos = Catalogo.Where(produto => DateTime.Parse(produto.DataValidade) > DateTime.Now).ToList();

            Console.Write("Realizando consulta. Aguarde um momento...");
            Thread.Sleep(2000);

            Console.WriteLine("\n");
            Console.WriteLine("Produtos FORA do prazo de validade: ");
            foreach (var produto in produtosVencidos)
            {
                Console.WriteLine($"{produto.Nome} -> {produto.DataValidade}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Produtos DENTRO do prazo de validade:");
            foreach (var produto in produtosNaoVencidos)
            {
                Console.WriteLine($"{produto.Nome} -> {produto.DataValidade}");
            }

            Console.Write("\nDigite uma tecla para voltar ao menu... ");
            Console.ReadKey();
            Console.Clear();
            Run();
        }

        public static void OrdenarOrdemAlfabetica()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CATALOGO -> Filtrando por data de validade <- ===\n");
            var catalogoOrdenadoAlf = Catalogo.OrderBy(produto => produto.Nome).ToList();

            foreach (var produto in catalogoOrdenadoAlf)
            {
                Console.WriteLine(produto.Nome);
            }

            Console.Write("\nDigite uma tecla para voltar ao menu... ");
            Console.ReadKey();
            Console.Clear();
            Run();

        }

        public static void OrdenarCatalogoValoresCresc()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CATALOGO -> Filtrando por data de validade <- ===\n");

            var catalogoOrdenadoValores = Catalogo.OrderBy(produto => produto.Preco).ToList();

            foreach (var produto in catalogoOrdenadoValores)
            {
                Console.WriteLine($"R${produto.Preco}");
            }

            Console.Write("\nDigite uma tecla para voltar ao menu... ");
            Console.ReadKey();
            Console.Clear();
            Run();
        }

        public static void Aprendizado()
        {
            Console.Clear();
            Console.WriteLine("=== MENU CATÁLOGO DE PRODUTOS -> Aprendizado <-\n");

            Console.WriteLine("1- Reforço de Programação Orientada a Objetos (POO);");
            Thread.Sleep(1000);

            Console.WriteLine("2- Criação de classes e listas de objetos para armazenar dados;");
            Thread.Sleep(1000);

            Console.WriteLine("3- Uso de LINQ (Average, Where, OrderBy) para cálculo de média, filtro e ordenação;");
            Thread.Sleep(1000);

            Console.WriteLine("4- Manipulação de datas com a estrutura DateTime;");
            Thread.Sleep(1000);

            Console.WriteLine("5- Construção de menus interativos no console com switch;");
            Thread.Sleep(1000);

            Console.WriteLine("6- Prática com laços de repetição (foreach, while) e validações de entrada;");
            Thread.Sleep(1000);

            Console.WriteLine("7- Separação de responsabilidades com métodos organizados;");
            Thread.Sleep(1000);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Run()
        {
            string op;

            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS ===\n");

            //Repita esse bloco para sempre, até eu manualmente mandar sair com um return, break ou Environment.Exit()
            while (true)
            {

                Console.WriteLine("1- Registrar produto");
                Console.WriteLine("2- Ver catalogo de produtos");
                Console.WriteLine("3- Calcular o preço médio dos produtos");
                Console.WriteLine("4- Filtrar catalogo pela data de validade");
                Console.WriteLine("5- Ordenar catalogo por ordem alfabetica");
                Console.WriteLine("6- Ordenar catalogo pelos valores dos produtos");
                Console.WriteLine("7- Aprendizado deste exercicio");
                Console.WriteLine("0 - Sair");
                Console.Write("\n-> ");
                op = Console.ReadLine();
                

                switch (op)
                {
                    case "1":
                        Funcionario.RegistrarUsuario();
                        break;

                    case "2":
                        ExibirProdutos();
                        break;

                    case "3":
                        MediaProdutos();
                        break;

                    case "4":
                        FiltrarPorDataValidade();
                        break;

                    case "5":
                        OrdenarOrdemAlfabetica();
                        break;

                    case "6":
                        OrdenarCatalogoValoresCresc();
                        break;

                    case "7":
                        Aprendizado();
                        break;

                    case "0":
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
