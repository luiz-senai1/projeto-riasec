using atividade_riasec;

Menu menu = new();
Perfil perfil = new();
Cadastro cadastro = new();
List<Cadastro> listaCadastro = new List<Cadastro>();

Console.WriteLine("Bem-Vindo ao RIASEC");

bool rodando = true;
bool acesso = false;

while (rodando)
{
    menu.MenuEntrar();
    string escolhaEntrar = Console.ReadLine();
    switch (escolhaEntrar)
    {
        case "1":
            int contador = 0;
            Console.WriteLine("Insira seu usuário");
            string user = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            string senha = Console.ReadLine();

            Cadastro buscaCadastro = listaCadastro.Find(x => x.User == user);

            if (buscaCadastro == null)
            {
                Console.WriteLine($"Não há cadastro!");
                break;
            }
            else
            {
                if (senha != buscaCadastro.Senha)
                {
                    while (contador < 3)
                    {
                        contador++;

                        Console.WriteLine("Insira sua senha");
                        senha = Console.ReadLine();
                    }
                    if (contador == 3)
                    {
                        Console.WriteLine("Você bloquoou acesso! Espera 5 minutos para tentar novamente!");
                        rodando = false;
                    }
                }
                else
                {
                    Console.WriteLine("Acesso permitido!");
                    acesso = true;
                    rodando = false;
                }
            }
            break;
        case "2":
            Console.WriteLine("Insira seu usuário");
            cadastro.User = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            cadastro.Senha = Console.ReadLine();

            listaCadastro.Add(cadastro);

            Console.WriteLine("Usuário cadastrado com sucesso!");
            break;
    }
}

if (acesso == true)
{
    perfil.Opcao();
    perfil.Realista();

    Console.WriteLine("");

    perfil.Opcao();
    perfil.Investigativo();
    
    Console.WriteLine("");

    perfil.Opcao();
    perfil.Artistico();

    Console.WriteLine("");

    perfil.Opcao();
    perfil.Social();

    Console.WriteLine("");

    perfil.Opcao();
    perfil.Empreendedor();

    Console.WriteLine("");

    perfil.Opcao();
    perfil.Convencional();

    Console.WriteLine("");

    perfil.Resultado();
}