using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322529
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

        public void Receber (string titulo, string sinopse, string genero, string classificacao)
        {
            this.titulo = titulo;
            this.sinopse = sinopse;
            this.genero = genero;
            this.classificacao = classificacao;

        }
       public string Mostrar()
        {
            return "Titulo do filme = " + this.titulo + "\nSinopse = " + this.sinopse + "\nGenero = " + this.genero + "\nClassificação etária = " + this.classificacao + "\n";
        }
    }
}
