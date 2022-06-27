using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaSimplesContratos.Service
{
    public class Validators
    {
        public const string validatorCpf = @"^\d{3}\d{3}\d{3}\d{2}$";
        public const string validatorString = @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ0-9 ]{1,100}$";
        public const string validatorsCnpj = @"^[0-9]{2}[0-9]{3}[0-9]{3}[0-9]{4}[0-9]{2}$";
        public const string validatorsInscricaoEstadual = @"^[0-9]{1,12}$";
    }
}
