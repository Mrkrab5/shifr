using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    internal class Playfair
    {

        public Playfair() 
        { 
        
        }

        static public string Decoding(string massenge, string word)
        {
            string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
                hightReg = lowReg.ToUpper(), newHightReg = "",
                n = "", result = "";
            //Убираем повторяющиеся буквы из word
            for (int i = 0; i < word.Length; i++)
            {
                int tmp = 0;

                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == word[i])
                        tmp++;
                }

                if (tmp == 0)
                    n += word[i];
            }

            string newLowReg = n;

            //Смещение всех букв из word в начало новой строки
            for (int i = 0; i < lowReg.Length; i++)
            {
                int tmp = 0;
                //Цикл для проверки что буква не находиться в word
                for (int j = 0; j < n.Length; j++)
                {
                    if (newLowReg[j] != lowReg[i])
                        tmp++;
                }
                //Если прошло проверку то добавлять в новую строку
                if (tmp == n.Length)
                    newLowReg += lowReg[i];
            }

            newHightReg = newLowReg.ToUpper();

            char[,] array = new char[6, 6];
            //Создание матрицы значений
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //Если не закончились буквы
                    if (6 * i + j < newHightReg.Length)
                        array[i, j] = newHightReg[6 * i + j];
                    //Если закончились то следующим символом будет пробел для ФИО
                    else if (6 * i + j == newHightReg.Length)
                        array[i, j] = ' ';
                }
            }
            
            //Из-за того что все буквы в массиве в верхнем регистре
            //переводим в верхний регистр
            n = massenge.ToUpper();
            int[,] masIndex = new int[massenge.Length / 2, 4]; 

            for (int i = 0; i < massenge.Length / 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (massenge.Length % 2 == 0)
                        {
                            if (n[i] == array[j, k])
                                ;// massenge[i, ]
                        }
                    }
                }
            }

            return result;
        }
    }
}
