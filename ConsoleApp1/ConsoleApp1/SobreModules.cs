namespace ConsoleApp1.Modules
{
    public class SobreModules
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== SOBRE O PROJETO ===\n");

            Console.WriteLine("-> Com o objetivo de consolidar meus conhecimentos em C#, criei este projeto no formato de um menu interativo;");
            Thread.Sleep(1000);

            Console.WriteLine("-> Cada opção representa um mini exercício, desenvolvido a partir dos conceitos e funções que fui aprendendo ao longo dos estudos;");
            Thread.Sleep(1000);

            Console.WriteLine("-> As opções seguem uma ordem crescente: os primeiros projetos são mais simples e introdutórios, enquanto os últimos trazem maior grau de dificuldade e complexidade;");
            Thread.Sleep(1000);

            Console.WriteLine("-> A ideia é que, a cada novo aprendizado, eu adicione uma nova opção ao menu, transformando este projeto em um repositório vivo da minha evolução. Em cada projeto, tenho uma opção 'SOBRE ESTE PROJETO'. Lá, terá uma descrição do que foi utilizado naquele exercício, funções, métodos. Estou aberto para receber dicas, sugestões!");
            Thread.Sleep(1000);

            Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
