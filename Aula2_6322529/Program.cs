using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322529
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fil= new Filme();
            Entrada ent = new Entrada();

            Console.WriteLine("Digite o titulo do filme: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Faça um breve resumo dele: ");
            string sinopse = Console.ReadLine();
            Console.WriteLine("Qual gênero? ");
            string genero = Console.ReadLine();
            Console.WriteLine("Qual é sua classificação? ");
            string classificacao = Console.ReadLine();
            fil.Receber(titulo, sinopse, genero, classificacao);

            Console.WriteLine(fil.Mostrar());

            Console.WriteLine("Digite o valor da entrada: ");
            ent.SetValor(double.Parse(Console.ReadLine()));
            Console.WriteLine("Qual é a posição da sua poltrona? ");
            ent.SetPoltrona(Console.ReadLine());
            Console.WriteLine("Digite a data do filme (DD/MM/AAAA): ");
            ent.SetData(Console.ReadLine());
            Console.WriteLine("Digite o horário de exibição (00:00): ");
            ent.SetHora(Console.ReadLine());


            Console.WriteLine("\n" + "Valor da entrada: " + ent.GetValor().ToString("C") +
                "\nPoltrona do cliente: " + ent.GetPoltrona() + "\nData de exbição: " + ent.GetData()+ "\nHorário de exibição: " + ent.GetHora()+"\n");

            Console.ReadKey();
        }
    }
}
