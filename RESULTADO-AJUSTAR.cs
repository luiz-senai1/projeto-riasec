
// public void Resultado()
// {
//     List<int> listaNumeros = new List<int>();
//     List<string> listaNomes = new List<string>();
//     List<string> listaCursos = new List<string>();

//     List<Perfil> listaNumerosFinal = new List<Perfil>();

//     int[] resultadosNumero = { somaRealista, somaInvestigativo, somaArtistico, somaSocial, somaEmpreendedor, somaConvencional };

//     string[] resultadosNome = { "Realista", "Investigativo", "Artístico", "Social", "Empreendedor", "Convencional" };

//     string[] cursos = { "Mecânica, Automação, Usinagem, Eletricidade, Eletroeletrônica, Manutenção, Impressão 3D, Logística, Controle de Qualidade, Segurança do Trabalho", "Tecnologia da Informação, Eletroeletrônica, Saúde Ocupacional, Controle de Qualidade, Planejamento", "Design de Produto, Comunicação Visual", "Educação, Saúde Ocupacional, Segurança do Trabalho, Gestão, Vendas Técnicas", "Gestão, Vendas Técnicas, Administração, Logística", "Administração, Vendas Técnicas, Planejamento, Logística" };

//     int maiorNumero = int.MinValue;
//     string maiorNome;
//     string maiorCurso;

//     for (int i = 0; i < resultadosNumero.Length; i++)
//     {
//         if (resultadosNumero[i] > maiorNumero)
//         {
//             maiorNumero = resultadosNumero[i];
//             maiorNome = resultadosNome[i];
//             maiorCurso = cursos[i];

//             listaNomes.Add(maiorNome);
//             listaNumeros.Add(maiorNumero);
//             listaCursos.Add(maiorCurso);
//             listaNumerosFinal.Add(new Perfil { Nome = listaNomes[i], ResultadoFinal = listaNumeros[i], Cursos = cursos[i] });

//         }
//         else if (resultadosNumero[i] == maiorNumero)
//         {
//             maiorNome = resultadosNome[i];
//             maiorCurso = cursos[i];

//             listaNumeros.Add(resultadosNumero[i]);
//             listaNomes.Add(maiorNome);
//             listaCursos.Add(maiorCurso);
//             listaNumerosFinal.Add(new Perfil { Nome = listaNomes[i], ResultadoFinal = listaNumeros[i], Cursos = cursos[i] });
//         }
//     }

//     for (int i = 0; i < listaNumeros.Count(); i++)
//     {
//         listaNumerosFinal.Add(new Perfil { Nome = listaNomes[i], ResultadoFinal = listaNumeros[i], Cursos = cursos[i] });
//     }

//     foreach (var v in listaNumerosFinal)
//     {
//         Console.WriteLine($"{v.Nome}, Resultado {v.ResultadoFinal}, cursos {v.Cursos}\n");
//     }

// }
