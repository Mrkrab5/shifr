using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    internal class VisenerShifr
    {

        public VisenerShifr() 
        { 
        
        }

        static public string Decoding(string massenge, string word)
        {
            string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ", result = "", n = massenge.ToLower(),
                key = "";
            //Создаём 2 массива в которых будем хранить позиции элементов из текста
            int[] arrayMassenge = new int[massenge.Length], arrayWord = new int[massenge.Length];
            //Заполняем ключ до длины massenge
            for (int i = 0; i < massenge.Length; i++)
            {
                if (key.Length < massenge.Length)
                    key += word[i % word.Length];
            }
            //Заполнение массивов индексов элементов
            for(int i = 0; i < lowReg.Length; i++)
            {
                for(int j = 0; j < massenge.Length; j++)
                {
                    if (n[j] == lowReg[i])
                        arrayMassenge[j] = i;
                    if (key[j] == lowReg[i])
                        arrayWord[j] = i;
                }
            }
            //Формарование результата
            for(int i = 0; i < massenge.Length; i++)
                result += lowReg[(arrayMassenge[i] + arrayWord[i]) % lowReg.Length];

            return result;
        }
    }
}
