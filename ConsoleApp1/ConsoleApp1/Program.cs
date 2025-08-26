using ConsoleApp1.Modules;
using ConsoleApp1.Modules.CadastroUsuarios;
using ConsoleApp1.Modules.CatalogoProdutos;
using ConsoleApp1.Modules.FormasGeometricas;

bool rodando = true;

while (rodando)
{
    Console.WriteLine(" === MENU === ");
    Console.WriteLine("\n1 - Cadastro de Usuários");
    Console.WriteLine("2 - Catálogo de Produtos");
    Console.WriteLine("3 - Formas geométricas");
    Console.WriteLine("4 - API de Filmes/músicas");
    Console.WriteLine("i - Informações sobre o projeto");
    Console.WriteLine("0 - Sair");
    Console.Write("\n-> ");
    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            CadastroModule.Run();
            break;

        case "2":
            CatalogoModule.Run();
            break;

        case "3":
            FormasGeometricasModule.Run();
            break;

        case "4":
            APIModule.Run();
            break;

        case "i":
            SobreModules.Run();
            break;

        case "0":
            rodando = false;
            break;

    }

}
