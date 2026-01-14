using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;

namespace atividade_riasec.Perfis;

internal class PerfilEmpreendedor : Perfil
{
    public PerfilEmpreendedor()
    {
        this.Nome = "Empreendedor";
        Cursos.Add("Gestão, Vendas Técnicas, Administração, Logística");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Empreendedor");
        Console.Write("\n1. Gosto de liderar, convencer ou motivar pessoas: ");
        ReceberInfo();

        Console.Write("\n2. Tenho iniciativa e gosto de tomar decisões: ");
        ReceberInfo();

        Console.Write("\n3. Prefiro desafios que envolvam resultados e metas: ");
        ReceberInfo();

        Console.Write("\n4. Gosto de criar projetos e colocar ideias em prática: ");
        ReceberInfo();
        Console.Clear();
    }
}
