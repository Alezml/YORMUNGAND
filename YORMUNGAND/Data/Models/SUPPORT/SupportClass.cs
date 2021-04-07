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
                if (FullName.IndexOf(' ') > -1)
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
                            if (row.Length  > 0)
                                fio = fio + row.Substring(0, 1) + '.';
                        }
                        firstword = false;
                    }
                    return fio;
                }
                else
                {
                    return FullName;
                }
                
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
