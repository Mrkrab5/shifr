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
            int rowDopSymbol = 0, columnDopSymbol = 0, resultLenght = 0;

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
                    {
                        array[i, j] = newHightReg[6 * i + j];

                        if (newHightReg[6 * i + j] == 'Я')
                        {
                            rowDopSymbol = i;
                            columnDopSymbol = j;
                        }
                    }

                    //Если закончились то следующим символом будет пробел для ФИО
                    else if (6 * i + j == newHightReg.Length)
                        array[i, j] = ' ';

                }
            }
            
            //Из-за того что все буквы в массиве в верхнем регистре
            //переводим в верхний регистр и добавляем пробел в конец
            //если длина сообщения нечётная

            if (massenge.Length % 2 == 0)
            {
                n = massenge.ToUpper();
                resultLenght = n.Length;
            }
            else
            {
                n = massenge.ToUpper() + " ";
                resultLenght = massenge.Length + 1; 
            }

            for (int i = 0; i < resultLenght; i += 2)
            {
                int rowFirst = 0, columnFirst = 0, rowSecond = 0, columnSecond = 0;

                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (n[i] == array[j, k])
                        {
                            rowFirst = j;
                            columnFirst = k;
                        }

                        if (n[i + 1] == array[j, k])
                        {
                            rowSecond = j;
                            columnSecond = k;
                        }
                    }
                }
                //Когда символы находятся в одной строке
                if (rowFirst == rowSecond)
                {
                    //Если элементы одинаковые 
                    if (columnFirst == columnSecond)
                    {
                        
                        //Если элементы находятся не в последнем столбце,
                        //и не на последней строчке
                        if (columnFirst < 5 && rowFirst < 5)
                            result += $"{array[rowFirst, columnFirst + 1]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если элементы находяться в крайнем столбце, и не на последней строчке
                        else if (columnFirst == 5 && rowFirst <= 4)
                            result += $"{array[rowFirst, 0]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если элементы находятся не в последнем столбце,
                        //но на последней строчке
                        else if (columnFirst < 3 && rowFirst == 5)
                            result += $"{array[rowFirst, columnFirst + 1]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если элементы находятся в последнем столбце и на последней строчке
                        else if (columnFirst == 3 && rowFirst == 5)
                            result += $"{array[rowFirst, 0]}{array[rowDopSymbol, columnDopSymbol]}";
                    }
                    else
                    {
                        //Если элементы находяться не на последней строке,
                        //и не в последнем столбце
                        if (rowFirst < 5 && columnFirst < 5 && columnSecond < 5)
                            result += $"{array[rowFirst, columnSecond + 1]}{array[rowSecond, columnSecond + 1]}";

                        //Если 1-й эл-т находится в последнем столбце, но не в последней строчке,
                        //а 2-й эл-т находится не в последнем столбце и не в последней строчке 
                        else if (rowFirst < 5 && columnFirst == 5)
                            result += $"{array[rowFirst, 0]}{array[rowSecond, columnSecond + 1]}";

                        //Если 1-й эл-т находится не в последнем столбце и не в последней строчке,
                        //а 2-й эл-т находится в последнем столбце, но не в последней строчке
                        else if (rowFirst < 5 && columnSecond == 5)
                            result += $"{array[rowFirst, columnSecond + 1]}{array[rowSecond, 0]}";

                        //Если 1-й и 2-й эл-ты находятся не в последнем столбце,
                        //но в последней строчке
                        else if (rowFirst == 5 && columnSecond < 3 && columnSecond < 3)
                            result += $"{array[rowFirst, columnFirst + 1]}{array[rowSecond, columnSecond + 1]}";

                        //Если 1-й эл-т и 2-й эл-т находятся на последней строчке,
                        //1-й эл-т находится на последнем столбце, а 2-й нет
                        else if (rowFirst == 5 && columnFirst == 3)
                            result += $"{array[rowFirst, 0]}{array[rowSecond, columnSecond + 1]}";

                        //Если 1-й и 2-й эл-ты находятся на последней строчке,
                        //1-й эл-т находится не на последнем столбце, а 2-й на последнем
                        else if (rowFirst == 5 && columnSecond == 3)
                            result += $"{array[rowFirst, columnFirst + 1]}{array[rowSecond, 0]}";
                    }
                }
                //Когда символы находяться в одном столбце
                else if (columnFirst == columnSecond)
                {
                    //Если элементы одинаковые
                    if (rowFirst == rowSecond)
                    {
                        //Если эл-ты находятся не в последней строке и не над пустыми значениями
                        if (rowFirst < 5 && columnFirst < 4)
                            result += $"{array[rowFirst + 1, columnFirst]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если эл-ты находтся не на предпоследней строчке, но на последних 2-х столбцах
                        else if (rowFirst < 4 && columnFirst >= 4)
                            result += $"{array[rowFirst + 1, columnFirst]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если эл-ты находятся на предпоследней строчке и в столбцах с пустыми значениями
                        else if (rowFirst == 4 && columnFirst >= 4)
                            result += $"{array[0, columnFirst]}{array[rowDopSymbol, columnDopSymbol]}";

                        //Если эл-ты находятся на последней строке
                        else if (rowFirst == 5)
                            result += $"{array[0, columnFirst]}{array[rowDopSymbol, columnDopSymbol]}";
                    }
                    else
                    {
                        //Если эл-ты находятся выше предпоследней строчки
                        if (rowFirst < 4 && rowSecond < 4)
                            result += $"{array[rowFirst + 1, columnFirst]}{array[rowSecond + 1, columnSecond]}";

                        //Если 1-й эл-т находится в предпоследней строчке в столбцах с пустыми значениями,
                        //а 2-й эл-т находится не в последней строчке
                        else if (rowFirst == 4 && columnFirst >= 4)
                            result += $"{array[0, columnFirst]}{array[rowSecond + 1, columnSecond]}";

                        //Если 1-й эл-т находится не в предпоследней строчке,
                        //а 2-й эл-т находится на предпоследней строке и в столбцах с пустыми значениями
                        else if (columnSecond >= 4 && rowSecond == 4)
                            result += $"{array[rowFirst + 1, columnFirst]}{array[0, columnSecond]}";

                        //Если 1-й эл-т находится на последней строке, а 2-й нет
                        else if (rowFirst == 5)
                            result += $"{array[0, columnFirst]}{array[rowSecond + 1, columnSecond]}";

                        //Если 2-й эл-т находится на последней строке, а 1-й нет
                        else if (rowSecond == 5)
                            result += $"{array[rowFirst + 1, columnFirst]}{array[0, columnSecond]}";
                    }
                }
                else
                    result += $"{array[rowFirst, columnSecond]}{array[rowSecond, columnFirst]}";

                result += " ";
            }
            return result;
        }
    }
}
