using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringLib
{
    public class StringClass
    {/// <summary>
     /// Проверка того, что введенное значение - дата
     /// </summary>
     /// <param name="textString"></param>
     /// Строка
     /// <param name="typeDate"></param>
     /// Формат даты
     /// <returns></returns>
        public static bool StringParse(string textString, int typeDate)
        {
            string typeData;
            if (typeDate == 1)
            {
                typeData = "yyyy.MM.dd";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }

            if (typeDate == 2)
            {
                typeData = "yyyy-MM-dd";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }

            if (typeDate == 3)
            {
                typeData = "yyyy/MM/dd";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }

            if (typeDate == 4)
            {
                typeData = "yyyy-M-d";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }

            if (typeDate == 5)
            {
                typeData = "yyyy/M/d";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }

            if (typeDate == 6)
            {
                typeData = "yyyy.dd.mm";
                if (!DateTime.TryParseExact(textString, typeData, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime scheduleDate))
                {
                    return false;
                }
                return true;
            }



            return true;

        }

    }
}

