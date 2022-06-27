using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SistemaSimplesContratos.Domain;
using SistemaSimplesContratos.Service;
using System.Text.RegularExpressions;

namespace SistemaSimplesContratos.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variaveis de controle */
            string opcao = "4", inputUser = "a";
            List<string> opcoesValidas = new List<string>()
            {
                "1",
                "2",
                "3",
                "4"
            };
            Regex paternCpf = new Regex(Validators.validatorCpf);
            Regex paternString = new Regex(Validators.validatorString);
            Regex paternCpnj = new Regex(Validators.validatorsCnpj);
            Regex paternIe = new Regex(Validators.validatorsInscricaoEstadual);
            List<Contrato> listaContratos = new List<Contrato>();

            /*=============================================*/

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();

                do
                {
                    if (!opcoesValidas.Contains(opcao))
                        Console.WriteLine(Prints.opcaoInvalida);

                    Console.WriteLine(Prints.menuInicial);
                    Console.Write("\nDigite uma das opções acima: ");
                    opcao = Console.ReadLine();
                    Console.WriteLine("\n");

                } while (!opcoesValidas.Contains(opcao));

                Console.Clear();

                if (opcao.Equals("4"))
                {
                    Console.WriteLine(Prints.fechar);
                    break;
                }

                else if (opcao.Equals("1") || opcao.Equals("2"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();

                    Console.WriteLine("\n=========== TELA DE CADASTRO ===========");
                    inputUser = "a";
                    do
                    {
                        if (!(paternString.IsMatch(inputUser)))
                            Console.WriteLine(Prints.opcaoInvalida);

                        Console.Write("\nDigite o nome: ");
                        inputUser = Console.ReadLine();
                    } while (!(paternString.IsMatch(inputUser)));

                    String novoNome = inputUser.ToUpper().Trim();
                    inputUser = "2";

                    decimal novoValor;

                    do
                    {
                        if (!(decimal.TryParse(inputUser, out novoValor)))
                            Console.WriteLine(Prints.opcaoInvalida);

                        Console.Write($"Digite o valor do contrato: ");
                        inputUser = Console.ReadLine();
                    } while (!(decimal.TryParse(inputUser, out novoValor)));

                    int novoPrazo;
                    inputUser = "2";

                    do
                    {
                        if (!(int.TryParse(inputUser, out novoPrazo)))
                            Console.WriteLine(Prints.opcaoInvalida);

                        Console.Write($"Digite o prazo do contrato: ");
                        inputUser = Console.ReadLine();
                    } while (!(int.TryParse(inputUser, out novoPrazo)));

                    if (opcao.Equals("1"))
                    {
                        inputUser = "33333333333";
                        do
                        {
                            if (!(paternCpf.IsMatch(inputUser)))
                                Console.WriteLine(Prints.opcaoInvalida);

                            Console.Write($"Digite o CPF (apenas números): ");
                            inputUser = Console.ReadLine();
                        } while (!(paternCpf.IsMatch(inputUser)));

                        String novoCpf = inputUser;
                        inputUser = DateOnly.FromDateTime(DateTime.Now).ToString();
                        DateOnly novaDataNascimento;

                        do
                        {
                            if (!(DateOnly.TryParse(inputUser, out novaDataNascimento)))
                                Console.WriteLine(Prints.opcaoInvalida);

                            Console.Write($"Digite a data de nascimento (dd/mm/aaaa): ");
                            inputUser = Console.ReadLine();
                        } while (!(DateOnly.TryParse(inputUser, out novaDataNascimento)));

                        ContratoPessoaFisica contratoPessoaFisica = new ContratoPessoaFisica();

                        contratoPessoaFisica.Nome = novoNome;
                        contratoPessoaFisica.Valor = novoValor;
                        contratoPessoaFisica.Prazo = novoPrazo;
                        contratoPessoaFisica.Cpf = novoCpf;
                        contratoPessoaFisica.DataNascimento = novaDataNascimento;
                        listaContratos.Add(contratoPessoaFisica);
                    }

                    else
                    {
                        inputUser = "11111111111111";
                        do
                        {
                            if (!(paternCpnj.IsMatch(inputUser)))
                                Console.WriteLine(Prints.opcaoInvalida);

                            Console.Write($"Digite o CNPJ (apenas números): ");
                            inputUser = Console.ReadLine();
                        } while (!(paternCpnj.IsMatch(inputUser)));

                        string cnpjNovo = inputUser;
                        inputUser = "519097653156";

                        do
                        {
                            if (!(paternIe.IsMatch(inputUser)))
                                Console.WriteLine(Prints.opcaoInvalida);

                            Console.Write($"Digite o Inscrição Estadual: ");
                            inputUser = Console.ReadLine();
                        } while (!(paternIe.IsMatch(inputUser)));

                        string ieNovo = inputUser;

                        ContratoPessoaJuridica contratoPessoaJuridica = new ContratoPessoaJuridica();

                        contratoPessoaJuridica.Nome = novoNome;
                        contratoPessoaJuridica.Valor = novoValor;
                        contratoPessoaJuridica.Prazo = novoPrazo;
                        contratoPessoaJuridica.Cnpj = cnpjNovo;
                        contratoPessoaJuridica.InscricaoEstadual = ieNovo;
                        listaContratos.Add(contratoPessoaJuridica);
                    }
                    Console.WriteLine("\n****** === Contratante cadastrado com sucesso! === ****** \n ");
                    Console.WriteLine(Prints.continuar);
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcao.Equals("3"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    while (true)
                    {
                        do
                        {
                            if (!opcoesValidas.Contains(opcao))
                                Console.WriteLine(Prints.opcaoInvalida);

                            Console.WriteLine(Prints.menuSecundario);
                            Console.Write("\nDigite uma das opções acima: ");
                            opcao = Console.ReadLine();

                        } while (!opcoesValidas.Contains(opcao));

                        Console.Clear();

                        if (opcao.Equals("4"))
                        {
                            Console.Clear();
                            break;
                        }

                        else if (opcao.Equals("1"))
                        {
                            Console.WriteLine("\n =========== TODAS AS INFORMAÇÕES - CONTRATOS CADASTRADOS =========== \n");

                            foreach (Contrato c in listaContratos)
                            {
                                Console.WriteLine(c.ToString());
                            }

                            Console.WriteLine(Prints.continuar);
                            Console.ReadKey();
                            Console.Clear();

                        }

                        else if (opcao.Equals("2"))
                        {
                            Contrato resultado;
                            List<Contrato> listaResultado = new List<Contrato>();
                            Console.WriteLine("\n =========== BUSCA POR NOME - CONTRATOS CADASTRADOS =========== \n");
                            do
                            {
                                Console.Write("\nPor favor, digite um nome válido\nOu digite \"4\" para retornar ao menu anterior: ");
                                inputUser = Console.ReadLine();
                                if (inputUser == "4")
                                {
                                    Console.Clear();
                                    break;
                                }

                                String nomeBusca = inputUser.ToUpper().Trim();
                                resultado = listaContratos.Find(x => x.Nome == nomeBusca);

                                if (resultado == null)
                                {
                                    Console.WriteLine("\n****** === Nome inválido! Contratante ainda não cadastrado === ****** :(");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("\n****** === Nome válido! Contratante identificado === ****** :)");
                                    listaResultado.Add(resultado);
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                Console.Write("\nVocê quer buscar mais algum nome? Digite \"1\" para mostrar os resultados buscados\nOu digite qualquer tecla para continuar buscando os nomes: ");
                                inputUser = Console.ReadLine();

                                if (inputUser == "1")
                                {
                                    break;
                                }

                                Console.Clear();

                            } while (true);

                            if (listaResultado.Any())
                            {
                                Console.WriteLine("\n\n=========== BUSCA POR NOME - CONTRATO(S) ENCONTRADO(S) =========== \n");
                                foreach (Contrato c in listaResultado)
                                {
                                    c.exibirInfo();
                                }

                                Console.WriteLine(Prints.continuar);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("\n\n=========== BUSCA POR NOME - NENHUM CONTRATO DIGITADO FOI ENCONTRADO =========== \n");

                                listaResultado.Clear();
                                Console.WriteLine(Prints.continuar);
                                Console.ReadKey();

                            }
                        }
                    }
                }
            }
        }
    }
}

