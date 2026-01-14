using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Menus;

namespace atividade_riasec.Perfis;

internal class PerfilArtistico : Perfil
{
        public PerfilArtistico()
    {
        this.Nome = "Artistico";
        Cursos.Add("Design de Produto, Comunicação Visual");
    }
    public override void Executar()
    {
        base.Executar();
        Menu.ExibirTituloDaOpcao("Perfil Artístico");
        Console.Write("\n1. Gosto de criar, desenhar, inventar ou expressar ideias: ");
        ReceberInfo();

        Console.Write("\n2. Prefiro atividades com liberdade e sem regras rígidas: ");
        ReceberInfo();

        Console.Write("\n3. Gosto de música, artes visuais, escrita ou atuação: ");
        ReceberInfo();

        Console.Write("\n4. Sou imaginativo(a) e busco formas diferentes de fazer as coisas: ");
        ReceberInfo();
        Console.Clear();
    }
}
