using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace atividade_riasec
{
    public class Perfil
    {

        public string? Nome { get; set; }
        public int ResultadoFinal { get; set; }
        public string? Cursos { get; set; }

        int somaRealista, somaInvestigativo, somaArtistico, somaSocial, somaEmpreendedor, somaConvencional = 0;
        int realista1, investigativo1, artistico1, social1, empreendedor1, convencional1;
        string? realista, investigativo, artistico, social, empreendedor, convencional;

        public int Converter(string teste)
        {
            var deuCerto = int.TryParse(teste, out var valor);

            if (deuCerto)
            {
                return valor;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Tente novamente Flexa >:)");
                    teste = Console.ReadLine()!;

                    deuCerto = int.TryParse(teste, out var valor1);
                    if (deuCerto)
                    {
                        return valor1;
                    }
                }
            }
        }

        public int Verificacao(int num)
        {
            if (num < 0 || num > 4)
            {
                while (true)
                {
                    Console.WriteLine("Número inválido, tente novamente!");
                    num = int.Parse(Console.ReadLine()!);

                    if (num >= 0 && num <= 4)
                    {
                        return num;
                    }
                }
            }
            else
            {
                return num;
            }
        }

        public void Opcao()
        {
            Console.WriteLine("Responda as questões:");

            Console.WriteLine("0 - Nada a ver\n1 - Pouco\n2 - Parcialmente\n3 - Bastante\n4 - Totalmente");
        }
        public void Realista()
        {
            Console.WriteLine("1. Gosto de trabalhar com ferramentas, máquinas ou objetos.");
            realista = Console.ReadLine()!;
            realista1 = Converter(realista);

            somaRealista += Verificacao(realista1);

            Console.WriteLine("2. Prefiro atividades práticas a discussões teóricas.");
            realista = Console.ReadLine()!;
            realista1 = Converter(realista);

            somaRealista += Verificacao(realista1);

            Console.WriteLine("3. Gosto de consertar, montar ou construir coisas.");
            realista = Console.ReadLine()!;
            realista1 = Converter(realista);

            somaRealista += Verificacao(realista1);

            Console.WriteLine("4. Prefiro ambientes organizados e tarefas manuais.");
            realista = Console.ReadLine()!;
            realista1 = Converter(realista);

            somaRealista += Verificacao(realista1);
        }
        public void Investigativo()
        {
            Console.WriteLine("1. Gosto de resolver problemas complexos.");
            investigativo = Console.ReadLine()!;
            investigativo1 = Converter(investigativo);

            somaInvestigativo += Verificacao(investigativo1);

            Console.WriteLine("2. Tenho interesse em ciência, pesquisa ou experimentos.");
            investigativo = Console.ReadLine()!;
            investigativo1 = Converter(investigativo);

            somaInvestigativo += Verificacao(investigativo1);

            Console.WriteLine("3. Gosto de analisar informações e entender como as coisas funcionam.");
            investigativo = Console.ReadLine()!;
            investigativo1 = Converter(investigativo);

            somaInvestigativo += Verificacao(investigativo1);

            Console.WriteLine("4. Prefiro atividades que envolvam reflexão e lógica.");
            investigativo = Console.ReadLine()!;
            investigativo1 = Converter(investigativo);

            somaInvestigativo += Verificacao(investigativo1);

        }
        public void Artistico()
        {
            somaArtistico = 0;
            Opcao();

            Console.WriteLine("1. Gosto de criar, desenhar, inventar ou expressar ideias.");
            artistico = Console.ReadLine()!;
            artistico1 = Converter(artistico);

            somaArtistico += Verificacao(artistico1);

            Console.WriteLine("2. Prefiro atividades com liberdade e sem regras rígidas.");
            artistico = Console.ReadLine()!;
            artistico1 = Converter(artistico);

            somaArtistico += Verificacao(artistico1);

            Console.WriteLine("3. Gosto de música, artes visuais, escrita ou atuação.");
            artistico = Console.ReadLine()!;
            artistico1 = Converter(artistico);

            somaArtistico += Verificacao(artistico1);
            Console.WriteLine("4. Sou imaginativo(a) e busco formas diferentes de fazer as coisas.");
            artistico = Console.ReadLine()!;
            artistico1 = Converter(artistico);

            somaArtistico += Verificacao(artistico1);
        }
        public void Social()
        {
            somaSocial = 0;
            Opcao();

            Console.WriteLine("1. Gosto de ajudar, orientar ou cuidar de pessoas.");
            social = Console.ReadLine()!;
            social1 = Converter(social);

            somaSocial += Verificacao(social1);

            Console.WriteLine("2. Tenho facilidade para ouvir e compreender os outros.");
            social = Console.ReadLine()!;
            social1 = Converter(social);

            somaSocial += Verificacao(social1);

            Console.WriteLine("3. Prefiro atividades que envolvem ensinar ou apoiar alguém.");
            social = Console.ReadLine()!;
            social1 = Converter(social);

            somaSocial += Verificacao(social1);

            Console.WriteLine("4. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.");
            social = Console.ReadLine()!;
            social1 = Converter(social);

            somaSocial += Verificacao(social1);
        }
        public void Empreendedor()
        {
            somaEmpreendedor = 0;
            Opcao();

            Console.WriteLine("1. Gosto de liderar, convencer ou motivar pessoas.");
            empreendedor = Console.ReadLine()!;
            empreendedor1 = Converter(empreendedor);

            somaEmpreendedor += Verificacao(empreendedor1);

            Console.WriteLine("2. Tenho iniciativa e gosto de tomar decisões.");
            empreendedor = Console.ReadLine()!;
            empreendedor1 = Converter(empreendedor);

            somaEmpreendedor += Verificacao(empreendedor1);

            Console.WriteLine("3. Prefiro desafios que envolvam resultados e metas.");
            empreendedor = Console.ReadLine()!;
            empreendedor1 = Converter(empreendedor);

            somaEmpreendedor += Verificacao(empreendedor1);

            Console.WriteLine("4. Gosto de criar projetos e colocar ideias em prática.");
            empreendedor = Console.ReadLine()!;
            empreendedor1 = Converter(empreendedor);

            somaEmpreendedor += Verificacao(empreendedor1);
        }
        public void Convencional()
        {
            somaConvencional = 0;
            Opcao();

            Console.WriteLine("1. Gosto de organizar, planejar e manter tudo em ordem.");
            convencional = Console.ReadLine()!;
            convencional1 = Converter(convencional);

            somaConvencional += Verificacao(convencional1);

            Console.WriteLine("2. Prefiro atividades com regras claras e rotina.");
            convencional = Console.ReadLine()!;
            convencional1 = Converter(convencional);

            somaConvencional += Verificacao(convencional1);

            Console.WriteLine("3. Gosto de trabalhar com documentos, tabelas ou registros.");
            convencional = Console.ReadLine()!;
            convencional1 = Converter(convencional);

            somaConvencional += Verificacao(convencional1);

            Console.WriteLine("4. Sou detalhista e cuidadoso(a) com informações.");
            convencional = Console.ReadLine()!;
            convencional1 = Converter(convencional);

            somaConvencional += Verificacao(convencional1);
        }
        public void Resultado()
        {

            List<int> listaNumeros = new List<int>();
            List<string> listaNomes = new List<string>();
            List<string> listaCursos = new List<string>();

            List<Perfil> listaNumerosFinal = new List<Perfil>();

            int[] resultadosNumero = { somaRealista, somaInvestigativo, somaArtistico, somaSocial, somaEmpreendedor, somaConvencional };

            string[] resultadosNome = { "Realista", "Investigativo", "Artístico", "Social", "Empreendedor", "Convencional" };

            string[] cursos = { "Mecânica, Automação, Usinagem, Eletricidade, Eletroeletrônica, Manutenção, Impressão 3D, Logística, Controle de Qualidade, Segurança do Trabalho", "Tecnologia da Informação, Eletroeletrônica, Saúde Ocupacional, Controle de Qualidade, Planejamento", "Design de Produto, Comunicação Visual", "Educação, Saúde Ocupacional, Segurança do Trabalho, Gestão, Vendas Técnicas", "Gestão, Vendas Técnicas, Administração, Logística", "Administração, Vendas Técnicas, Planejamento, Logística" };

            int maiorNumero = int.MinValue;
            string maiorNome;
            string maiorCurso;

            for (int i = 0; i < resultadosNumero.Length; i++)
            {
                if (resultadosNumero[i] > maiorNumero)
                {
                    maiorNumero = resultadosNumero[i];
                    maiorNome = resultadosNome[i];
                    maiorCurso = cursos[i];

                    listaNomes.Add(maiorNome);
                    listaNumeros.Add(maiorNumero);
                    listaCursos.Add(maiorCurso);

                }
                else if (resultadosNumero[i] == maiorNumero)
                {
                    maiorNome = resultadosNome[i];
                    maiorCurso = cursos[i];

                    listaNumeros.Add(resultadosNumero[i]);
                    listaNomes.Add(maiorNome);
                    listaCursos.Add(maiorCurso);
                }
            }

            for (int i = 0; i < listaNumeros.Count(); i++)
            {
                listaNumerosFinal.Add(new Perfil { Nome = listaNomes[i], ResultadoFinal = listaNumeros[i], Cursos = cursos[i] });
            }

            foreach (var v in listaNumerosFinal)
            {
                Console.WriteLine($"{v.Nome}, Resultado {v.ResultadoFinal}, cursos {v.Cursos}\n");
            }

        }
    }
}