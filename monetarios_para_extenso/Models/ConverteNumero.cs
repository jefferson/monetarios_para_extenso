using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monetarios_para_extenso.Models
{
    public static class ConverteNumero
    {
        private static string _convert(double _number)
        {

            if (_number == 0)
                return "Zero";

            if (_number < 0)
                return "Valor inválido";

            if (_number % 1 != 0)
                return "Valor inválido";

            return String.Empty;

        }

        public static string convert(double _number)
        {
            return _convert(_number);
        }

        public static string convert(string number)
        {
            double _number = -1;

            double.TryParse(number, out _number);


            return _convert(_number);

        }
    }
}