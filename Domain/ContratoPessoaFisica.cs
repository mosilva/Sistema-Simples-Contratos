using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSimplesContratos.Domain
{
    public class ContratoPessoaFisica : Contrato
    {
        private string cpf;
        private DateOnly dataNascimento;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateOnly DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public override string ToString()
        {
            return $"\nTODOS OS DADOS - CONTRATANTE {Nome}\n\nNatureza: Pessoa Física\nNome: {Nome}\nValor: R$ {Valor}\nPrazo: {Prazo}\nCPF: {Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00")}\nData de Nascimento: {dataNascimento}\nIdade: {CalcularIdade(dataNascimento)}\n\n";
        }

        private int CalcularIdade(DateOnly date)
        {
            DateTime today = DateTime.Today;

            int months = today.Month - date.Month;
            int years = today.Year - date.Year;

            if (months < 0)
            {
                years--;
            }
            return years;
        }

        public override decimal calcularPrestacao()
        {
            int idade = CalcularIdade(dataNascimento);
            if (idade <= 30)
                return (Math.Round(((Valor / Prazo) + 1),2));
            else if (idade <= 40)
                return (Math.Round(((Valor / Prazo) + 2), 2));
            else if (idade <= 50)
                return (Math.Round(((Valor / Prazo) + 3), 2));
            else
                return (Math.Round(((Valor / Prazo) + 4), 2));
        }

        public override void exibirInfo()
        {
            Console.WriteLine($"\nEXIBIR INFO - CONTRATANTE {Nome}\n\nNatureza: Pessoa Física\nValor: R$ {Valor}\nPrazo: {Prazo}\nValor da prestação: R$ {calcularPrestacao()}\nIdade: {CalcularIdade(dataNascimento)} anos\n\n");
        }

    }
}
