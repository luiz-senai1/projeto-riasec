using atividade_riasec;
using atividade_riasec.Modelos;
using atividade_riasec.Menus;
using atividade_riasec.Perfis;

MenuCadastro menuCadastro = new MenuCadastro();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuLogin(menuCadastro));
opcoes.Add(2, menuCadastro);
opcoes.Add(-1, new MenuSair());

Menu menu = new Menu();

void ExibirOpcoesMenu()
{
    bool executando = true;

    while (executando)
    {
        Console.Clear();
        menu.ExibirLogo();
        Console.WriteLine("[1] - Entrar");
        Console.WriteLine("[2] - Cadastro");
        Console.WriteLine("[-1] - Sair");

        Console.Write("\nDigite a sua opção: ");
        string entrada = Console.ReadLine()!;
        int opcao = Perfil.Converter(entrada);

        if (opcoes.ContainsKey(opcao))
        {
            if (opcao == -1)
            {
                executando = false;
            }

            opcoes[opcao].Executar();
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            Console.ReadKey();
        }
    }
}


ExibirOpcoesMenu();