﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace monetarios_para_extenso.Models
{
    public static class ConverteNumero
    {
        private static string centenas(string part)
        {
            switch (part)
            {
                case "9":
                    return "novecentos";
                case "8":
                    return "oitocentos";
                case "7":
                    return "setecentos";
                case "6":
                    return "seiscentos";
                case "5":
                    return "quinhentos";
                case "4":
                    return "quatrocentos";
                case "3":
                    return "trezentos";
                case "2":
                    return "duzentos";
                default:
                    return String.Empty;
            }

        }

        private static string decimais_part_b( string part)
        {
            switch (part)
            {
                case "9":
                    return "noventa";
                case "8":
                    return "oitenta";
                case "7":
                    return "setenta";
                case "6":
                    return "sessenta";
                case "5":
                    return "cinquenta";
                case "4":
                    return "quarenta";
                case "3":
                    return "trinta";
                case "2":
                    return "vinte";
                default:
                    return String.Empty;
            }

        }

        private static string decimais_part_a(string part)
        {
            switch (part)
            {
                case "19":
                    return "dezenove";
                case "18":
                    return "dezoito";
                case "17":
                    return "dezessete";
                case "16":
                    return "dezesseis";
                case "15":
                    return "quinze";
                case "14":
                    return "quartorze";
                case "13":
                    return "treze";
                case "12":
                    return "doze";
                case "11":
                    return "onze";
                case "10":
                    return "dez";
                case "9":
                    return "nove";
                case "8":
                    return "oito";
                case "7":
                    return "sete";
                case "6":
                    return "seis";
                case "5":
                    return "cinco";
                case "4":
                    return "quatro";
                case "3":
                    return "três";
                case "2":
                    return "dois";
                case "1":
                    return "um";
                default:
                    return String.Empty;
            }

        }

        private static string _convert(double _number)
        {
            var part_a = String.Empty;
            var part_b = String.Empty;
            var part_c = String.Empty;

            if (_number >= 100 && _number <= 999)
            {
                part_a = _number.ToString()[0].ToString();
                part_b = _number.ToString()[1].ToString();
                part_c = _number.ToString()[2].ToString();

                return $"{centenas(part_a)} e {decimais_part_b(part_b)} e {decimais_part_a(part_c)}";
            }

            else if(_number < 100)
            {
                if(_number > 19)
                {
                    part_a = _number.ToString()[0].ToString();
                    part_b = _number.ToString()[1].ToString();

                    return $"{decimais_part_b(part_a)} e {decimais_part_a(part_b)}";

                }
                else
                {
                    part_a = _number.ToString();

                    return $"{decimais_part_a(part_a)}";
                }

            }

            return "Valor Inválido";

        }

        public static string convert(double _number)
        {
            if (_number == 0)
                return "Zero";           

            if (_number > 999)
                return "Valor Inválido";

            var result = new StringBuilder();

            if (_number < 0)
                result.Append("menos ");

            _number = Math.Abs(_number);

            int inteiro = (int)_number;

            double fracionaria = (_number % 1) * 100;

            if(inteiro > 0)
            {
                var _decimal = _convert(inteiro);
                result.Append(_decimal).Append(" reais");
            }

            if(fracionaria > 0)
            {
                var _fracionaria = _convert(fracionaria);
                result.Append(" ").Append("e ").Append(_fracionaria).Append(" centavos");
            }

            return result.ToString();
        }

    }
}