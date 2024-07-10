using System;

namespace Librarys
{
    public static class Money
    {
        private const char DOT_SYMBOL = '.';
        public const string currency = Constants.VIETNAM_CURRECY;
        public const string balanceHide = Constants.CHARACTER_HIDE_MONEY + currency;


        public static string ConvertNumberToMoney(long value)
        {
            bool isNegative = false;
            if (value < 0)
            {
                isNegative = true;
                value *= -1;
            }

            string stringValue = value.ToString();
            string newMoney = string.Empty;

            for (int i = stringValue.Length - 1; i > -1; --i)
            {
                if ((stringValue.Length - 1 - i) % 3 == 0 && i != (stringValue.Length - 1))
                {
                    newMoney = DOT_SYMBOL + newMoney;
                }
                newMoney = stringValue[i] + newMoney;
            }
            return ((isNegative == true) ? "-" : "") + newMoney + currency;
        }


        public static long ConvertMoneyToNumber(string value)
        {
            string newNumber = string.Empty;
            for (int i = 0; i < value.Length; ++i)
            {
                if (value[i] != '.')
                {
                    newNumber += value[i];
                }
            }

            return Convert.ToInt64(newNumber);
        }


        public static string convertNumberToMoneyNoCurrency(long value)
        {
            string stringValue = value.ToString();
            string newMoney = string.Empty;

            for (int i = stringValue.Length - 1; i > -1; --i)
            {
                if ((stringValue.Length - 1 - i) % 3 == 0 && i != (stringValue.Length - 1))
                {
                    newMoney = DOT_SYMBOL + newMoney;
                }
                newMoney = stringValue[i] + newMoney;
            }
            return newMoney;
        }

        public static string convertStringToMoney(string value)
        {
            string newMoney = "";

            for (int i = value.Length - 1; i > -1; --i)
            {
                if ((value.Length - 1 - i) % 3 == 0 && i != (value.Length - 1))
                {
                    newMoney = "." + newMoney;
                }
                newMoney = value[i] + newMoney;
            }
            return newMoney + currency;
        }
    }
}
