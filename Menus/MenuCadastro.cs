using System.Text.RegularExpressions;
using atividade_riasec.Modelos;

namespace atividade_riasec.Menus;

internal class MenuCadastro : Menu
{
    private List<Cadastro> cadastrados = new();
    public List<Cadastro> cadastros => cadastrados;
    static Regex cadastroValido = new Regex(@"^[A-Za-z]+$");

    public override void Executar()
    {
        Console.Clear();
        Cadastro pessoa = new();

        Console.WriteLine("Insira seu usuário");
        string user = Console.ReadLine()!;

        pessoa.User = VerificacaoUser(user);

        Console.WriteLine("Insira sua senha");
        pessoa.Password = Console.ReadLine()!;

        cadastrados.Add(pessoa);

        Console.WriteLine("Usuário cadastrado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
    private bool usuarioExistente, usuarioInvalido;
    private string VerificacaoUser(string user)
    {
        usuarioExistente = cadastrados.Any(c => c.User == user);
        usuarioInvalido = !cadastroValido.IsMatch(user);
        while (usuarioExistente || usuarioInvalido)
        {
            if (usuarioExistente && usuarioInvalido)
            {
                Console.WriteLine("Usuário já existente e inválido!");
            }
            else if (usuarioExistente)
            {
                Console.WriteLine("Usuário já existente!");
            }
            else if (usuarioInvalido)
            {
                Console.WriteLine("Usuário inválido!\nDeve conter apenas letras!\nestá tentando achar erro ne kkkkkkkkkkkkk");
            }
            Console.WriteLine("Tente novamente!");
            Console.Write("");
            user = Console.ReadLine()!;
            usuarioExistente = cadastrados.Any(c => c.User == user);
            usuarioInvalido = !cadastroValido.IsMatch(user);
        }
        return user;
    }
}
