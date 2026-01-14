
namespace atividade_riasec.Modelos;

internal class Cadastro
{
    private string? _user;
    private string? _password;

    public string User
    {
        get => _user!;
        set => _user = value;
    }
    public string Password
    {
        get => _password!;
        set => _password = value;
    }
}
