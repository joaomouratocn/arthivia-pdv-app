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
    }
}
