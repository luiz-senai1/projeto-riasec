using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;

namespace atividade_riasec.Perfis;

internal class PerfilConvencional : Perfil
{
    public PerfilConvencional()
    {
        this.Nome = "Convencional";
        Cursos.Add("Administração, Vendas Técnicas, Planejamento, Logística");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Convencional");
        Console.Write("\n1. Gosto de organizar, planejar e manter tudo em ordem: ");
        ReceberInfo();

        Console.Write("\n2. Prefiro atividades com regras claras e rotina: ");
        ReceberInfo();

        Console.Write("\n3. Gosto de trabalhar com documentos, tabelas ou registros: ");
        ReceberInfo();

        Console.Write("\n4. Sou detalhista e cuidadoso(a) com informações: ");
        ReceberInfo();
        Console.Clear();
    }
}
