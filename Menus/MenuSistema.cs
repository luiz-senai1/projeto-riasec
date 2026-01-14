using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_riasec.Perfis;

namespace atividade_riasec.Menus
{
    public class MenuSistema
    {
        List<Perfil> perfis = new()
        {
        new PerfilRealista(),
        new PerfilInvestigativo(),
        new PerfilArtistico(),
        new PerfilSocial(),
        new PerfilEmpreendedor(),
        new PerfilConvencional(),
        };

        public void Executar()
        {
            foreach (Perfil perfil2 in perfis)
            {
                perfil2.Executar();
            }

            int maiorPontuacao = perfis.Max(p => p.Pontuacao);

            var vencedores = perfis.Where(p => p.Pontuacao == maiorPontuacao).ToList();

            Console.Clear();

            Console.WriteLine("Cursos que você se encaixa: ");

            foreach (var v in vencedores)
            {
                Console.WriteLine($"Nome do Curso: {v.Nome}");
                Console.WriteLine($"Sua Pontuação: {v.Pontuacao}");

                foreach (var c in v.Cursos)
                {
                    Console.WriteLine($"- {c}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}