using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using atividade_riasec.Menus;
using atividade_riasec.Modelos;

namespace atividade_riasec.Perfis;

abstract internal class Perfil
{
    static Regex entradaValida = new Regex(@"^[0-4]$");
    public static int Converter(string entrada)
    {
        if (entradaValida.IsMatch(entrada) && int.TryParse(entrada, out var valor))
        {
            return valor;

        }
        else
        {
            while (true)
            {
                Console.WriteLine("Tente novamente Flexa >:) HAHAH");
                Console.Write("");
                entrada = Console.ReadLine()!;

                if (entradaValida.IsMatch(entrada) && int.TryParse(entrada, out var valor1))
                {
                    return valor1;
                }
            }
        }
    }
    public virtual void Executar()
    {
        Pontuacao = 0;
        Console.Clear();
        Console.WriteLine("Responda as questões:\n");

        Console.WriteLine("0 - Nada a ver\n1 - Pouco\n2 - Parcialmente\n3 - Bastante\n4 - Totalmente\n");
    }
    public string Nome { get; protected set; }
    public int Pontuacao { get; protected set; }
    public List<string> Cursos = new();
    protected Dictionary<int, ResultadoCurso> listaResultados = new();
    protected void ReceberInfo()
    {
        string receber = Console.ReadLine()!;
        Pontuacao += Converter(receber);
    }
}
