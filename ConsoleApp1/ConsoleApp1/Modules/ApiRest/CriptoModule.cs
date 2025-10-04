using System;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ConsoleApp1.Modules.ApiRest
{
    public class CriptoModule
    {
        static Dictionary<string, MoedaInfo> moedasFavoritas = new();

        // async pq esse método é assíncrono (pode pausar no meio para fazer uma requisição externa)
        // Task pq o await trabalha em cima dessa classe para acompanhar o progresso da operação assíncrona
        public static async Task Run()
        {
            int op;

            // looping infinito até o usuário sair (break/return)
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU CRIPTO ===");
                Console.WriteLine("\n1- Bitcoin, Ethereum, Cardano");
                Console.WriteLine("2- Pesquise uma Criptomoeda");
                Console.WriteLine("3- Exibir Favoritos");
                Console.WriteLine("4- Salvar Favoritos em arquivo");
                Console.WriteLine("0 Sair");
                Console.Write("\n-> ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        await ConsultarMoedasFixas(); // espera terminar antes de continuar
                        break;

                    case 2:
                        Console.Clear();
                        await ConsultarMoeda();
                        break;

                    case 3:
                        Console.Clear();
                        await ListarFavoritos();
                        break;

                    case 4:
                        Console.Clear();
                        await SalvarFavoritos();
                        break;

                    case 0:
                        return; // sai do loop e encerra o módulo
                }
            }
        }

        public static async Task ConsultarMoedasFixas()
        {
            try
            {
                string url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,ethereum,cardano&vs_currencies=usd,brl";

                using (HttpClient cliente = new HttpClient())
                {
                    string jsonBruto = await cliente.GetStringAsync(url);

                    Console.WriteLine("=== CONSULTAR PREÇOS FIXOS ===");
                    var dados = JsonSerializer.Deserialize<Preco>(jsonBruto);
                    Console.WriteLine($"\nBitcoin (USD) = {dados.bitcoin.usd}");
                    Console.WriteLine($"Bitcoin (BRL) = {dados.bitcoin.brl}");

                    Console.WriteLine($"\nEthereum (USD) = {dados.ethereum.usd}");
                    Console.WriteLine($"Ethereum (BRL) = {dados.ethereum.brl}");

                    Console.WriteLine($"\nCardano (USD) = {dados.cardano.usd}");
                    Console.WriteLine($"Cardano (BRL) = {dados.cardano.brl}");

                    await Task.Delay(2000);

                    Console.Write("\nPressione uma tecla para voltar ao Menu...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar a API: {ex.Message}");
            }
        }

        public static async Task ConsultarMoeda()
        {
            try
            {
                Console.WriteLine("=== CONSULTE O PREÇO DE UMA CRIPTOMOEDA ===");
                Console.Write("Digite o nome da Criptomoeda: ");
                string cripto = Console.ReadLine().ToLower();

                Console.Write($"\nBuscando por {cripto}... ");
                await Task.Delay(1500);

                string url = $"https://api.coingecko.com/api/v3/simple/price?ids={cripto}&vs_currencies=usd,brl";

                using (HttpClient cliente = new HttpClient())
                {
                    string jsonBruto = await cliente.GetStringAsync(url);
                    var dados = JsonSerializer.Deserialize<Dictionary<string, MoedaInfo>>(jsonBruto);

                    if (dados != null && dados.ContainsKey(cripto))
                    {
                        var info = dados[cripto]; //info armazena o valor da chave (valores monetarios da moeda)
                        Console.WriteLine($"\n\n{cripto.ToUpper()} (USD) = {info.usd}");
                        Console.WriteLine($"{cripto.ToUpper()} (BRL) = {info.brl}");
                        await Task.Delay(2000);

                        string op;
                        do
                        {

                            Console.Write("\nDeseja adicionar a criptomoeda na lista de Favoritos? (S/N): ");
                            op = Console.ReadLine().ToUpper();
                            if (op == "S")
                            {
                                await AdicionarCriptoFavoritos(cripto, info);
                            }
                            else
                            {
                                Console.Write("\nPressione uma tecla para voltar ao Menu...");
                                Console.ReadKey();
                            }

                        } while (op != "S" && op != "N");
                    }
                    else
                    {
                        Console.Write($"\nMoeda não encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar a API: {ex.Message}");
            }
        }

        public static async Task AdicionarCriptoFavoritos(string nomeCripto, MoedaInfo dadosMoeda)
        {
            moedasFavoritas[nomeCripto] = dadosMoeda;

            await Task.Delay(1500);
            Console.Write($"\nCriptomoeda {nomeCripto} adicionada em Favoritos!\n");
            await Task.Delay(1500);
            Console.Write("Pressione uma tecla para voltar ao Menu...");
            Console.ReadKey();

        }

        public static async Task ListarFavoritos()
        {
            Console.WriteLine("=== CRIPTOS FAVORITOS ===");

            if (moedasFavoritas.Count == 0)
            {
                Console.Write("Nenhuma moeda presente!");
            }
            else
            {
                //percorrendo cada item do dicionario. se eu faço moeda.Key eu acesso o nome dela, moeda.Value os valores, que no caso tem dois (USD e BRL)
                foreach (var moeda in moedasFavoritas)
                {
                    Console.WriteLine($"{moeda.Key} -> USD {moeda.Value.usd} | BRL {moeda.Value.brl}");
                    await Task.Delay(1000);
                }

                await Task.Delay(2000);
                Console.Write("\nPressione uma tecla para voltar ao Menu...");
                Console.ReadKey();
            }
        }

        public static async Task SalvarFavoritos()
        {
            Console.WriteLine("=== SALVAR FAVORITOS ===");
            Console.Write("Digite o nome do arquivo: ");
            string tmp = Console.ReadLine();
            string nomeArquivo = ($"{tmp}.json");

            try
            {
                var json = JsonSerializer.Serialize(moedasFavoritas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(nomeArquivo, json);
                Console.WriteLine($"\nArquivo salvo em {Path.GetFullPath(nomeArquivo)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar {ex.Message}");
            }

            await Task.Delay(1000);
            Console.Write("\nPressione uma tecla para voltar ao Menu...");
            Console.ReadKey();
        }

        public class Preco
        {
            public MoedaInfo bitcoin { get; set; }
            public MoedaInfo ethereum { get; set; }
            public MoedaInfo cardano { get; set; }
        }

        public class MoedaInfo
        {
            public decimal usd { get; set; }
            public decimal brl { get; set; }
        }
    }
}
