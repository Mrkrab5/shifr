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
                n = "", result = "", placeDopSymbol = "";
            //Убираем повторяющиеся буквы из word
            for (int i = 0; i < word.Length; i++)
            {
                int tmp = 0;

                for (int j = 0; j < n.Length; j++)
                {
                    //Если встретили поторяющийся символ
                    if (n[j] == word[i])
                        tmp++;
                }
                //Если повторов не было то добавляем в строку
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
                    else if (newHightReg[6 * i + j] == 'Я')
                        placeDopSymbol = i + " " + j;
                }
            }
            
            //Из-за того что все буквы в массиве в верхнем регистре
            //переводим в верхний регистр
            n = massenge.ToUpper();
            //int[,] masIndex = new int[massenge.Length / 2, 4]; 

            for (int i = 0; i < massenge.Length / 2; i += 2)
            {
                string a = "", b = "";
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        //Если длина сообщения чётная
                        if (massenge.Length % 2 == 0)
                        {
                            if (n[i] == array[j, k])
                                a = j + " " + k;

                            else if (n[i + 1] == array[j, k])
                                b = j + " " + k;
                        }
                        //Если длина сообщения нечётная
                        else
                        {
                            //Когда последний символ остался без пары, дополняем пробелом
                            if (n[i + 1] == array[j, k] && j == 5 && k <= 3)
                                b = 5 + " " + 3;

                            else if (n[i] == array[j, k])
                                a = j + " " + k;

                            else if (n[i + 1] == array[j, k])
                                b = j + " " + k;
                        }
                    }
                }
                //Когда символы находятся в одной строке
                if (a[0] == b[0])
                {
                    //Если элементы одинаковые и находяться не в последнем столбце,
                    //и не на последней строчке
                    if (a[2] == b[2] && a[2] < 5 && a[0] <= 4)
                        result += array[a[0], a[2] + 1] + array[placeDopSymbol[0], placeDopSymbol[2]];
                    //Если элементы одинаковые и находяться в крайнем столбце,
                    //и не на последней строчке 
                    else if (a[2] == b[2] && a[2] == 5 && a[0] <= 4)
                        result += array[a[0], 0] + array[placeDopSymbol[0], placeDopSymbol[2]];
                    //Если элементы одинаковые и находяться не в последнем столбце,
                    //но на последней строчке 
                    else if (a[2] == b[2] && a[2] < 3 && a[0] == 5)
                        result += array[a[0], a[2] + 1] + array[placeDopSymbol[0], placeDopSymbol[2]];
                    //Если элементы одинаковые и находяться в последнем столбце
                    //и на последней строчке 
                    else if (a[2] == b[2] && a[2] == 3 && a[0] == 5)
                        result += array[a[0], 0] + array[placeDopSymbol[0], placeDopSymbol[2]];
                    //Если столбец символов не является самым крайним
                    else if (a[2] < 5 && b[2] < 5)
                        result += array[a[0], a[2] + 1] + array[b[0], b[2] + 1];
                    //Если столбец первого крайний, а второй нет
                    else if (a[2] == 5 && b[2] < 5)
                        result += array[a[0], 0] + array[b[0], b[2] + 1];
                    //Когда столбец второго крайний, а первый нет
                    else if (a[2] < 5 && b[2] == 5)
                        result += array[a[0], a[2] + 1] + array[b[0], 0];
                }
                //Когда символы находяться в одном столбце
                else if (a[2] == b[2])
                {
                    //Если элементы являются одинаковыми и находяться выше
                    //предпоследней строки
                    if (a[0] == b[0] && a[2] <= 3)
                        result += array[a[0] + 1, a[2]] + array[placeDopSymbol[0], placeDopSymbol[2]];
                    //Если 
                    //Если строчка символов не является последней
                    else if (a[0] < 4 && b[0] < 4)
                        result += array[a[0] + 1, a[2]] + array[b[0] + 1, b[2]];
                    //Если строка является предпоследней и столбцы не находятся в столбцах с 
                    //пустыми значениями
                    else if ((a[0] == 4 || b[0] == 4) && a[2] < 4)
                        ;//result += array
                }
            }

            return result;
        }
    }
}
