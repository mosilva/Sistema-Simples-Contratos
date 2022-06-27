using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSimplesContratos.Domain
{
    public class ContratoPessoaJuridica: Contrato
    {
        private string cnpj;
        private string inscricaoEstadual;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = value; }
        }

        public override string ToString()
        {
            return $"\nTODOS OS DADOS - CONTRATANTE {Nome}\n\nNatureza: Pessoa Jurídica\nNome: {Nome}\nValor: R$ {Math.Round(Valor,2)}\nPrazo: {Prazo}\nCNPJ: {Convert.ToUInt64(Cnpj).ToString(@"00\.000\.000\/0000\-00")}\nInscrição Estadual: {inscricaoEstadual}\n\n";
        }

        public override decimal calcularPrestacao()
        {
            return (Math.Round(((Valor / Prazo) + 3),2));
        }

        public override void exibirInfo()
        {
            Console.WriteLine($"\nEXIBIR INFO - CONTRATANTE {Nome}\n\nNatureza: Pessoa Jurídica\nValor: R$ {Math.Round(Valor, 2)}\nPrazo: {Prazo}\nValor da prestação: R$ {calcularPrestacao()}\n\n");
        }


    }
}
