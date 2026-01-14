using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Modelos;

namespace atividade_riasec.Menus;

internal class Menu
{
    public virtual void Executar()
    {
        Console.Clear();
    }
    public static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public void ExibirLogo()
    {
        Console.WriteLine(@"
    
██████╗░██╗░█████╗░░██████╗███████╗░█████╗░
██╔══██╗██║██╔══██╗██╔════╝██╔════╝██╔══██╗
██████╔╝██║███████║╚█████╗░█████╗░░██║░░╚═╝
██╔══██╗██║██╔══██║░╚═══██╗██╔══╝░░██║░░██╗
██║░░██║██║██║░░██║██████╔╝███████╗╚█████╔╝
╚═╝░░╚═╝╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝░╚════╝░
");
        Console.WriteLine("Bem vindo ao Riasec 2.0!");
    }
}
