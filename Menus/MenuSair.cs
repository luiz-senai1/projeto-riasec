using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_riasec.Menus;

internal class MenuSair : Menu
{
    public override void Executar()
    {
        Console.WriteLine("Saindo...");
    }
}
