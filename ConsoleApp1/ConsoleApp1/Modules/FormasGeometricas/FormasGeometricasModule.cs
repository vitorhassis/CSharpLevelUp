//diz que a classe FormasGeometricasModule pertence ao pacote ConsoleApp1.Modules
using ConsoleApp1.Modules.CatalogoProdutos;

namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class FormasGeometricasModule
    {
        //public static void CalculoArea();

        //public static void CalculoPerimetro();
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
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "0":

                        break;
                }
            }
            
            
        }
    }
}
