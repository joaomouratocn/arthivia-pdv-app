using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.util
{
    internal class Util
    {
        public static string NormalizeText(string text)
        {
            
            string normalizedText = text.Normalize(NormalizationForm.FormD);

            
            StringBuilder sb = new StringBuilder();

            
            foreach (char c in normalizedText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            
            return sb.ToString().ToUpper();
        }

        public static bool CpfValidator(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // CPF precisa ter 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Rejeita CPFs com todos os dígitos iguais (ex: 11111111111)
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            // Calcula o primeiro dígito verificador
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Calcula o segundo dígito verificador
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            // Compara com os dígitos informados
            return cpf.EndsWith($"{digito1}{digito2}");
        }

    }
}
