
namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class AprendizadoModule
    {
            public static void ExibirAprendizado()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMÉTRICAS -> Aprendizado <-\n");

            Console.WriteLine("1- Aplicação de Programação Orientada a Objetos (POO) em nível intermediário-avançado;");
            Thread.Sleep(1000);

            Console.WriteLine("2- Criação de uma classe abstrata base (FormaGeometrica) com métodos genéricos;");
            Thread.Sleep(1000);

            Console.WriteLine("3- Herança: classes filhas como Retângulo, Quadrado, Círculo, Losango e Paralelogramo herdam a estrutura da classe base;");
            Thread.Sleep(1000);

            Console.WriteLine("4- Polimorfismo: uso de métodos virtuais e override para implementar lógicas específicas de cálculo de área e perímetro;");
            Thread.Sleep(1000);

            Console.WriteLine("5- Encapsulamento com propriedades (get/set) protegendo os atributos das formas;");
            Thread.Sleep(1000);

            Console.WriteLine("6- Interface IEntradaDados para obrigar a implementação da entrada dos dados nas classes concretas;");
            Thread.Sleep(1000);

            Console.WriteLine("7- Uso de dicionário para associar usuários às listas de formas cadastradas;");
            Thread.Sleep(1000);

            Console.WriteLine("8- Utilização de LINQ (FirstOrDefault) para localizar usuários;");
            Thread.Sleep(1000);

            Console.WriteLine("9- Menus interativos no Console com switch/case, validações e exibição dinâmica de resultados;");
            Thread.Sleep(1000);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
