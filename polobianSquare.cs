using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    class polobianSquare
    {

        public polobianSquare()
        {

        }

        static public string Decoding(string massenge)
        {
            char[,] array = { { 'А', 'Б', 'В', 'Г', 'Д', 'Е'},
                              { 'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
                              { 'Л', 'М', 'Н', 'О', 'П', 'Р'},
                              { 'С', 'Т', 'У', 'Ф', 'Х', 'Ц'},
                              { 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
                              { 'Э', 'Ю', 'Я', ' ', '-', '-'}};

            string result = "", n = massenge.ToUpper();

            for (int i = 0; i < massenge.Length; i ++)
            {
                for(int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (n[i] == array[j, k])
                            result += $"{j + 1}{k + 1}";
                    }
                }
                result += " ";
            }

            return result;
        }
    }
}
