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
    menu.ExibirLogo();
    Console.WriteLine("[1] - Entrar");
    Console.WriteLine("[2] - Cadastro");
    Console.WriteLine("[-1] - Sair");

    Console.Write("\nDigite a sua opção: ");
    string entrada = Console.ReadLine()!;
    int entrada2 = Perfil.Converter(entrada);

    if (opcoes.ContainsKey(entrada2))
    {
        Menu menu = opcoes[entrada2];
        menu.Executar();
        if (entrada2 > 0)
        {
            ExibirOpcoesMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();