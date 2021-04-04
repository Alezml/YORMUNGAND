using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.SUPPORT
{
    public class SupportClass
    {
        // Преобразовать "Фамилию Имя Отчество" в "Фамилию И. О."
        public static string FIOshort(string FullName)
        {
            string fio = "";
            if (FullName != null)
            {
                string[] _subs = FullName.Split(' ');
                Boolean firstword = true;
                foreach (string row in _subs)
                {
                    if (firstword)
                    {
                        fio = row + ' ';
                    }
                    else
                    {
                        fio = fio + row.Substring(0, 1) + '.';
                    }
                    firstword = false;
                }
                return fio;
            }
            else
            {
                return "-";
            }
        }
        public static string DataShort(DateTime data)
        {
                return data.ToShortDateString();
        }
        public static string ToHtml(string data)
        {
            if (data != null)
            {
                return data.Replace(Convert.ToString('"'), "&quot;");
            }
            else
            {
                return "-";
            }
        }
    }
}
