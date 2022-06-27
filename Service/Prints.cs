using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaSimplesContratos.Service
{
    public static class Prints
    {
        public const string menuInicial = @" =========== MENU INICIAL ===========   

1 - Cadastrar Contrato de pessoa física
2 - Cadastrar Contrato de pessoa jurídica
3 - Exibir informações dos contratos cadastrados
4 - Sair do sistema";

        public const string fechar = "\nPressione qualquer tecla para fechar...";

        public const string continuar = "\nPressione qualquer tecla para continuar...";

        public const string opcaoInvalida = "\n****** === Opção inválida! Digite um valor verdadeiro === ******\n";

        public const string digiteNome = "\nDigite o nome do contratante: ";
        
        public const string menuSecundario = @" =========== MENU DE EXIBIÇÃO DE DADOS =========== 

1 - Todas as informações dos contratos cadastrados
2 - Exibir contrato(s) específico(s) - busca por nome
3 - Exibir contrato(s) por natureza(s) do contratante
4 - Voltar ao menu anterior";

    }
}
