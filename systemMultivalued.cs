using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    class systemMultivalued
    {

        public systemMultivalued() 
        {
            
        }

        static public string Decoding(string massenge)
        {
            string result = "", n = massenge.ToUpper(), dictZnach;
            Random rnd = new Random();
            /*
            int[,] znachSymbol = new int[34, 7];

            for (int i = 0; i < n.Length; i ++)
            {
                for (int j = 0; j < lowReg.Length; j++)
                {
                    if (n[i] == lowReg[j])
                    {
                        int y = rnd.Next(7);

                    }
                }
            }*/
            
            Dictionary<char, string> dict = new Dictionary<char, string>
            { {'А', "0 34 53 67 78 "}, {'Б', "1 "}, {'В', "2 35 54 68 "}, {'Г', "3 "}, {'Д', "4 36 55 "}, {'Е', "5 37 56 69 79 86 90 "},
              {'Ё', "6 38 57 70 80 87 91 "}, {'Ж', "7 "}, {'З', "8 39 "}, {'И', "9 40 58 71 "}, {'Й', "10 "}, {'К', "11 41 59 "},
              {'Л', "12 42 60 72 "}, {'М', "13 43 61 "}, {'Н', "14 44 62 73 81 "}, {'О', "15 45 63 74 82 88 92 "}, {'П', "16 46 "},
              {'Р', "17 47 64 75 "}, {'С', "18 48 65 76 83 "}, {'Т', "19 49 66 77 84 "}, {'У', "20 50 "}, {'Ф', "21 "}, {'Х', "22 "},
              {'Ц', "23 "}, {'Ч', "24 "}, {'Ш', "25 "}, {'Щ', "26 "}, {'Ъ', "27 "}, {'Ы', "28 "}, {'Ь', "29 "}, {'Э', "30 "}, {'Ю', "31 "},
              {'Я', "32 52 "}, {' ', "33 "} };

            for (int i = 0; i < n.Length; i++)
            {
                //Count для подсчёта количества вариантов шифрования буквы, tmpCount для выбора шифрования буквы
                //tmpString хранит в себе
                int count = 0, tmpCount;
                string tmpString = "";
                dictZnach = dict[n[i]];
                //Подсчёт количества вариантов шифрования для буквы
                for (int j = 0; j < dictZnach.Length; j++)
                {
                    if (dictZnach[j] == ' ')
                        count++;
                }
                //Выбирается случайная замена для буквы из списка
                tmpCount = rnd.Next(count);
                count = 0;
                bool may = false;

                for (int j = 0; j < dictZnach.Length; j++)
                {
                    if (dictZnach[j] != ' ')
                        tmpString += dictZnach[j];
                    else if (dictZnach[j] == ' ')
                    {
                        count++;
                        //Если буква ещё не зашифрована
                        if ((count == tmpCount && !may)  || (count - 1 == tmpCount && !may))
                            may = true;
                        //Шифруем букву если ещё не зашифрована
                        if (may)
                        {
                            result += tmpString;
                            may = false;
                        }
                        tmpString = "";
                    }
                }
                result += " ";
            }

            return result;
        }
    }
}
