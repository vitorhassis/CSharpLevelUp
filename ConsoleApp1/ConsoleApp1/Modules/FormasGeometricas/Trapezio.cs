namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class Trapezio:FormaGeometrica, IEntradaDados
    {
        private double _baseMaior;
        public double BaseMaior
        {
            get { return _baseMaior; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor maior que zero para a base maior!");
                }
            }
        }

        private double _baseMenor;

        public double BaseMenor
        {
            get { return _baseMenor; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor maior que zero para a base menor!");
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
                    Console.WriteLine("Digite um valor positivo para a altura do trapezio!");
                }
            }
        }

        public void SolicitarEntradaDeDados()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Area e perimetro do Trapezio <- ===\n");

            Console.Write("Digite o valor da base MAIOR: ");
            BaseMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da base MENOR: ");
            BaseMenor = double.Parse(Console.ReadLine());

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
            double area = ((BaseMaior + BaseMenor) * Altura) / 2;
            Console.WriteLine($"Area: {area} u.a^2");
        }

        public override void CalculoPerimetro()
        {
            double diferencaBases = (BaseMaior - BaseMenor) / 2;
            double ladoObliquo = Math.Sqrt(Math.Pow(diferencaBases, 2) + Math.Pow(Altura, 2));

            double perimetro = BaseMaior + BaseMenor + 2 * ladoObliquo;

            Console.WriteLine($"Perímetro: {perimetro} u.a");
        }
    }
}
