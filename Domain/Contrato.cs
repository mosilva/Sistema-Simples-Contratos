using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSimplesContratos.Domain
{
    public class Contrato
    {
        private Guid idContrato = Guid.NewGuid();

        private string nome;

        private decimal valor;

        private int prazo;

        public string Nome
        {
            get { return nome; }

            set { nome = value;}
        }

        public decimal Valor
        {
            get { return valor; }

            set { valor = value; }
        }

        public int Prazo
        {
            get { return prazo; }
            set { prazo = value; }
        }

        public virtual decimal calcularPrestacao()
        {
            return valor/prazo;
        }

        public virtual void exibirInfo()
        {
            Console.WriteLine($"\nEXIBIR INFO\n\nValor: R$ {Valor}\nPrazo: {Prazo}\nValor da prestação: R$ {calcularPrestacao()}\n\n");
        }


    }
}
