using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace ConsoleApp1.Modules.ApiRest
{
    public class ClimaModule
    {
        public static async Task Run()
        {
            int op;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MÓDULO DE CLIMA ===");
                Console.WriteLine("\n1- Escolher uma cidade");
                Console.WriteLine("0- Voltar");
                Console.Write("\n-> ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        await ConsultarCidade();
                        break;

                    case 0:
                        return;
                }

            }

        }

        public static async Task ConsultarCidade()
        {
            Console.WriteLine("=== API CLIMA ===");
            Console.Write("\nDigite o nome da cidade: ");
            string cidade = Console.ReadLine();
            try
            {
                var url = ($"http://api.weatherapi.com/v1/current.json?key=9e60f980da53442f921221452250510&q={cidade}&aqi=no");
                using (HttpClient cliente = new HttpClient())
                {
                    var jsonBruto = await cliente.GetStringAsync(url);
                    Console.Clear();
                    Console.WriteLine($"=== COMO ESTA O CLIMA EM {cidade} ===");
                    var dados = JsonSerializer.Deserialize<WeatherResponse>(jsonBruto);
                    Console.WriteLine($"\nESTADO -> {dados.location.region}");
                    Console.WriteLine($"PAÍS -> {dados.location.country}");
                    Console.WriteLine($"UMIDADE -> {dados.current.humidity}");
                    Console.WriteLine($"TEMPERATURA (GRAUS CELSIUS) -> {dados.current.temp_c}°C");
                    Console.WriteLine($"TEMPERATURA (FAHRENHEIT) -> {dados.current.temp_f}F");

                    await Task.Delay(2000);
                    Console.Write("\nPressione uma tecla para voltar ao Menu...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar a API {ex.Message}");
            }
        }

        public class WeatherResponse
        {
            public Location location { get; set; }
            public Current current { get; set; }
        }

        public class Location
        {
            public string region { get; set; }
            public string country { get; set; } 
            public string localtime { get; set; }

        }

        public class Current 
        {
            public float temp_c { get; set; }

            public float temp_f { get; set; }
            public int humidity { get; set; }
        }

    }
}


