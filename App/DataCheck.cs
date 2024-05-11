using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class DataCheck
    {
        public class DataError : Exception
        {
            public DataError(string message) : base(message) { }
        }

        public static string CheckForm(string text, string name)
        {
            if (text == "")
                throw new DataError($"Поле \"{name}\" не может быть пустым.");
            return text;
        }

        public static int CheckFormInt(string text, string name)
        {
            if (text == "")
                throw new DataError($"Поле \"{name}\" не может быть пустым.");
            if (!int.TryParse(text, out int result))
                throw new DataError($"Вы должны ввести число в поле \"{name}\".");
            return result;
        }
    }
}
