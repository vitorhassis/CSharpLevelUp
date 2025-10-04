namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class Quadrado:FormaGeometrica, IEntradaDados //estou definindo que Quadrado eh uma classe filha de FormasGeometricas
    {
        private double _lado;

        public double Lado
        {
            get { return _lado; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor positivo para o lado do quadrado!");
                }
                else
                {
                    _lado = value;
                }
            }
        }
        public void SolicitarEntradaDeDados()
        {
            Console.Clear();
            Console.WriteLine("=== MENU FORMAS GEOMETRICAS -> Area Quadrado <- ===\n");

            Console.Write("Digite o valor do lado: ");
            Lado = double.Parse(Console.ReadLine());

            Console.Write("\nCalculando...");
            Console.WriteLine("\n");
            Thread.Sleep(1500);

            CalculoArea();
            CalculoPerimetro();

        }
        public override void CalculoArea()
        {
            double area = Lado * Lado;
            Console.WriteLine($"Area: {area}, u.a^2");
        }
        public override void CalculoPerimetro()
        {
            double perimetro = Lado * 4;
            Console.WriteLine($"Perimetro: {perimetro}, u.a");
        }
    }
}
