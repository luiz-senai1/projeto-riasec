using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;

namespace atividade_riasec.Perfis;

internal class PerfilInvestigativo : Perfil
{
    public PerfilInvestigativo()
    {
        this.Nome = "Investigativo";
        Cursos.Add("Tecnologia da Informação, Eletroeletrônica, Saúde Ocupacional, Controle de Qualidade, Planejamento");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Investigativo");
        Console.Write("\n1. Gosto de resolver problemas complexos: ");
        ReceberInfo();

        Console.Write("\n2. Tenho interesse em ciência, pesquisa ou experimentos: ");
        ReceberInfo();

        Console.Write("\n3. Gosto de analisar informações e entender como as coisas funcionam: ");
        ReceberInfo();

        Console.Write("\n4. Prefiro atividades que envolvam reflexão e lógica: ");
        ReceberInfo();
        Console.Clear();
    }
}
