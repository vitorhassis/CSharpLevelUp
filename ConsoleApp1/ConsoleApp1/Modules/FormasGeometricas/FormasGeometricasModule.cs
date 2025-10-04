//diz que a classe FormasGeometricasModule pertence ao pacote ConsoleApp1.Modules
using ConsoleApp1.Modules.CatalogoProdutos;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
namespace ConsoleApp1.Modules.FormasGeometricas
{
    //como eh a classe base, a classe mae, colocamos ABSTRACT, e nas filhas, OVERRIDE (obrigo herdar logicas e métodos), se eu quisesse so forçar a existencia de certos metodos, independente da herança, usaria interface
    public class FormasGeometricasModule
    {

        public static FormaGeometrica ExibirOpcoesFormas()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Opções <- ===\n");
            Console.WriteLine("1- Retangulo");
            Console.WriteLine("2- Quadrado");
            Console.WriteLine("3- Circulo");
            Console.WriteLine("4- Losangulo");
            Console.WriteLine("5- Trapezio");
            Console.Write("\n-> ");
            int op = int.Parse(Console.ReadLine());

            //Criamos uma classe abstrata chamada FormaGeometrica, que serve como molde base para todas as formas.Por ser abstrata, ela não é instanciada diretamente, pois representa apenas um conceito genérico O objetivo é que as classes filhas herdem essa estrutura, sobrescrevam (override) os métodos genéricos definidos na base — como CalcularArea() e CalcularPerimetro() — e implementem as lógicas específicas de cada forma. Dessa forma, instanciamos apenas as classes concretas(filhas), que representam formas reais como Retangulo, Circulo, etc. No caso, forma eh uma instancia da classe FormaGeometrica;

            FormaGeometrica forma = null;

            switch (op)
            {
                //forma eh o nome da variavel de FormaGeometrica, ate antes do = ele eh um molde generico. Depois do =, eu atribuo a esse molde, um objeto especifico, como Retangulo, circulo, quadrado, que sao classes concretas filha da classe abstrata.
                case 1:
                    forma = new Retangulo();
                    break;

                case 2:
                    forma = new Quadrado();
                    break;

                case 3:
                    forma = new Circulo();
                    break;

                case 4:
                    forma = new Losangulo();
                    break;

                case 5:
                    forma = new Trapezio();
                    break;
            }

            //"Se forma for um objeto que implementa IEntradaDados, então cria uma variável chamada entrada, e nela eu posso chamar o método SolicitarEntradaDeDados() com segurança." Como forma é do tipo FormaGeometrica, FormaGeometrica nao tem o método que queremos, ex: forma.SolicitarEntradaDeDados();
            if (forma is IEntradaDados entrada)
            {
                entrada.SolicitarEntradaDeDados();
            }

            return forma;
        }
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU FORMAS GEOMETRICAS ===\n");
                Console.WriteLine("1- Adicionar forma geometrica"); //registrar ou logar conta
                Console.WriteLine("2- Listar suas formas geometricas");
                Console.WriteLine("3- Listar todas os usuarios e suas formas");
                Console.WriteLine("4- Aprendizado deste exercicio");
                Console.WriteLine("5- Remover um usuario do sistema");
                Console.WriteLine("0- Sair");
                Console.Write("\n-> ");
                string op = Console.ReadLine().Trim();

                var listagem = new ListarFormasUser();

                switch (op)
                {
                    case "1":
                        GerenciadorUsuarios.RegistrarUsuario();
                        break;

                    case "2":
                        listagem.ValidacaoUser();
                        break;

                    case "3":
                        listagem.ListarTodosUsuariosEFormas();
                        break;

                    case "4":
                        AprendizadoModule.ExibirAprendizado();
                        break;

                    case "5":
                        GerenciadorUsuarios.RemoverUsuario();
                        break;

                    case "0":
                        Console.Clear();
                        return;
                }
            }
        }
    }
}
