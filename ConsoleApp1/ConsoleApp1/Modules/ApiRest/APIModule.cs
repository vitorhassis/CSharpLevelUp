using System;
using ConsoleApp1.Modules.ApiRest;

namespace ConsoleApp1.Modules.ApiRest
{
    public class APIModule
    {
        public static async Task Run()
        {
            string op;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU API REST -ESCOLHA- ===");
                Console.WriteLine("\n1- Criptomoedas");
                Console.WriteLine("2- Clima");
                Console.WriteLine("0- Voltar");
                Console.Write("\n-> ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                       await CriptoModule.Run(); 
                        break;

                    case "2":
                        await ClimaModule.Run();
                        break;

                    case "0":
                        return;
                }
            }
        }
    }
}
