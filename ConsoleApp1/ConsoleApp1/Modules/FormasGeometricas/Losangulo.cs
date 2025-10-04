namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class Losangulo:FormaGeometrica, IEntradaDados 
    {
        private double _diagonalMaior;

        public double DiagonalMaior
        {
            get { return _diagonalMaior; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor válido para a diagonal maior!");
                }
            }
        }

        private double _diagonalMenor;
        public double DiagonalMenor
        {
            get { return _diagonalMenor; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor válido para a diagonal menor");
                }
            }
        }

        public void SolicitarEntradaDeDados()
        {
            Console.Clear();
            Console.Write("=== MENU FORMAS GEOMETRICAS -> Area e perimetro do Losangulo <- ===\n");

            Console.Write("Digite o valor da diagonal MAIOR: ");
            DiagonalMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da diagonal MENOR: ");
            DiagonalMenor = double.Parse(Console.ReadLine());

            Console.Write("\nCalculando...");
            Console.WriteLine("\n");
            Thread.Sleep(1500);

            CalculoArea();
            CalculoPerimetro();
        }
        public override void CalculoArea()
        {
            double area = (DiagonalMaior * DiagonalMenor) / 2;
            Console.WriteLine($"Area: {area} u.a^2");
        }

        public override void CalculoPerimetro()
        {
            double metadeD = DiagonalMaior / 2;
            double metaded = DiagonalMenor / 2;

            double lado = Math.Sqrt(Math.Pow(metadeD, 2) + Math.Pow(metaded, 2));

            double perimetro = 4 * lado;

            Console.WriteLine($"Perimetro: {perimetro} u.a");
        }
    }
}
