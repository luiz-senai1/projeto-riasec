using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;
using atividade_riasec.Modelos;

namespace atividade_riasec.Perfis;

internal class PerfilRealista : Perfil
{
    public PerfilRealista()
    {
        this.Nome = "Realista";
        Cursos.Add("Mecânica, Automação, Usinagem, Eletricidade, Eletroeletrônica, Manutenção, Impressão 3D, Logística, Controle de Qualidade, Segurança do Trabalho");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Realista");
        Console.Write("\n1. Gosto de trabalhar com ferramentas, máquinas ou objetos: ");
        ReceberInfo();

        Console.Write("\n2. Prefiro atividades práticas a discussões teóricas: ");
        ReceberInfo();

        Console.Write("\n3. Gosto de consertar, montar ou construir coisas: ");
        ReceberInfo();

        Console.Write("\n4. Prefiro ambientes organizados e tarefas manuais: ");
        ReceberInfo();

        Console.Clear();
    }
}
