using atividade_riasec.Modelos;
namespace atividade_riasec.Menus;

internal class MenuLogin : Menu
{
    private MenuCadastro menuCadastro;
    MenuSistema menuSistema = new();
    public MenuLogin(MenuCadastro menuCadastro)
    {
        this.menuCadastro = menuCadastro;
    }
    string user;
    string senha;

    public override void Executar()
    {
        if (menuCadastro.cadastros.Count == 0)
        {
            Console.WriteLine("Não há usuários cadastrados!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            VerificadorLogin();
        }
    }
    private void VerificadorLogin()
    {
        int contador = 0;

        Console.WriteLine("Insira seu usuário");
        user = Console.ReadLine()!;

        Cadastro buscaCadastro = menuCadastro.cadastros.Find(x => x.User == user)!;

        if (buscaCadastro == null)
        {
            Console.WriteLine($"O usuário {user} não foi encontrado em nosso Sistema!");
            Console.WriteLine("Deseja tentar novamente? [s/n]");
            string escolhaContinuar = Console.ReadLine()!;

            if (escolhaContinuar.ToLower() == "s" || escolhaContinuar.ToLower() == "sim")
            {
                VerificadorLogin();
            }
            else
            {
                Console.WriteLine("Retornando...");
                Thread.Sleep(2000);
                Console.Clear();
            }
            return;
        }

        while (contador < 3)
        {
            Console.WriteLine("Insira sua senha");
            senha = Console.ReadLine()!;

            if (buscaCadastro.Password == senha)
            {
                Console.WriteLine("Acesso permitido!");
                Thread.Sleep(2000);
                menuSistema.Executar();
                break;
            }

            contador++;
            if (contador == 3)
            {
                Console.WriteLine("Você bloqueoou acesso! Espere 5 segundos para tentar novamente!");
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}

