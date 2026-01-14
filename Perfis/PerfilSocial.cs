using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;

namespace atividade_riasec.Perfis;

internal class PerfilSocial : Perfil
{    public PerfilSocial()
    {
        this.Nome = "Social";
        Cursos.Add("Educação, Saúde Ocupacional, Segurança do Trabalho, Gestão, Vendas Técnicas");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Social");
        Console.Write("\n1. Gosto de ajudar, orientar ou cuidar de pessoas: ");
        ReceberInfo();

        Console.Write("\n2. Tenho facilidade para ouvir e compreender os outros: ");
        ReceberInfo();

        Console.Write("\n3. Prefiro atividades que envolvem ensinar ou apoiar alguém: ");
        ReceberInfo();

        Console.Write("\n4. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo: ");
        ReceberInfo();
        Console.Clear();
    }
}
