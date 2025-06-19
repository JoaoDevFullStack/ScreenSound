using ScreenSound.Menus;
using ScreenSound.Models;

internal class Program : Menu
{
    private static void Main(string[] args)
    {
        Banda linkinPark = new Banda("Linkin Park");
        linkinPark.AdicionarNota(new Avaliacao(10));
        linkinPark.AdicionarNota(new Avaliacao(8));
        linkinPark.AdicionarNota(new Avaliacao(6));
        Banda theBeatles = new Banda("The Beatles");



        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(linkinPark.Nome, linkinPark);
        bandasRegistradas.Add(theBeatles.Nome, theBeatles);

        Dictionary<int, Menu> options = new();
        options.Add(1, new RegisterBand());
        options.Add(2, new RegisterAlbum());
        options.Add(3, new BandRegister());
        options.Add(4, new MenuRateBand());
        options.Add(5, new MenuDetails());
        options.Add(6, new RateAlbum());
        options.Add(-1, new MenuExit());

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 6 para avaliar um álbum de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (options.ContainsKey(opcaoEscolhidaNumerica))
            {

                Menu menu1 = options[opcaoEscolhidaNumerica];
                menu1.Execute(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0)
                {
                    ExibirOpcoesDoMenu();
                }

            } else
            {
                Console.WriteLine("Opção inválida");
            }
        }
        ExibirOpcoesDoMenu();
    }
}