using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322529
{
    internal class Entrada
    {
        double valor;
        string poltrona;
        string data;
        string hora;

        public void SetValor(double valor)
        {
            this.valor = valor;

        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetPoltrona(string poltrona)
        {
            this.poltrona = poltrona;

        }
        public string GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetData(string data)
        {
            this.data = data;

        }
        public string GetData()
        {
            return this.data;
        }
        public void SetHora(string hora)
        {
            this.hora = hora;

        }
        public string GetHora()
        {
            return this.hora;
        }
    }
}
