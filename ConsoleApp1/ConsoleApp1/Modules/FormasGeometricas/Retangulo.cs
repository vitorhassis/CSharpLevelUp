namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class Retangulo:FormaGeometrica, IEntradaDados
    {
        //encapsulamento
        private double _base;
        public double Base
        {
            get { return _base; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor positivo!");
                }
                else
                {
                    _base = value;
                }
            }
        }

        private double _altura;
        public double Altura
        {
            get { return _altura; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor positivo!");
                }
                else
                {
                    _altura = value;
                }
            }
        }

        public Retangulo() { }

        //interface. Todas as classes filhas (retangulo, circulo, quadrado, etc) terao a assinatura da interface IEntradaDados. Ou seja, todas elas deverao ter a assinatura desse método "EntradaDados()" dentro delas, independente da lógica;
        public void SolicitarEntradaDeDados()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Area e perimetro do Retangulo <- ===\n");
            Console.Write("Digite o valor da base: ");
            Base = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            Altura = double.Parse(Console.ReadLine());

            Console.Write("\nCalculando...");
            Console.WriteLine("\n");
            Thread.Sleep(1500);

            CalculoArea();
            CalculoPerimetro();
        }

        public override void CalculoArea()
        {
            double result = Base * Altura;
            Console.WriteLine($"Area: {result} u.a^2");
        }

        public override void CalculoPerimetro()
        {
            double result = (Base*Base)+(Altura*Altura);
            Console.WriteLine($"Perimetro: {result} u.a");
        }

        public override void ExibirDados()
        {
            Console.WriteLine("Retangulo");
            CalculoArea();
            CalculoPerimetro();
        }
    }
}
