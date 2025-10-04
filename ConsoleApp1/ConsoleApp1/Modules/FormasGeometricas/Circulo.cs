using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules.FormasGeometricas
{
 
    public class Circulo:FormaGeometrica, IEntradaDados
    {
        private double _raio;

        public double Raio
        {
            get { return _raio; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Digite um valor positivo para o raio!");
                }
                else
                {
                    _raio = value;
                }
            }
        }
        public void SolicitarEntradaDeDados()
        {
            Console.Clear();
            Console.Write("=== MENU FORMAS GEOMETRICAS -> Area Circulo <- ===\n");

            Console.Write("Digite o valor do raio: ");
            Raio = double.Parse(Console.ReadLine());

            Console.Write("\nCalculando...");
            Console.WriteLine("\n");
            Thread.Sleep(1500);

            CalculoArea();
            CalculoPerimetro();
        }
        public override void CalculoArea()
        {
            double result = Math.PI * (Raio * Raio);
            Console.WriteLine($"Area: {result} u.a^2");
        }

        public override void CalculoPerimetro()
        {
            double perimetro = 2 * Math.PI * Raio;
            Console.WriteLine($"Perimetro: {perimetro} u.a");
        }
    }
}
