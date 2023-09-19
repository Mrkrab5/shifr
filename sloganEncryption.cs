using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace shifr
{
    class sloganEncryption
    {

        public sloganEncryption()
        {

        }

        static public string Decoding(string massenge, string slogan)
        {
            string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
                hightReg = lowReg.ToUpper(), newHightReg = "",
                n = "", result = "";
            //Убираем повотряющиеся буквы из slogan
            for (int i = 0; i < slogan.Length; i++)
            {
                int tmp = 0;

                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == slogan[i])
                        tmp++;
                }

                if (tmp == 0)
                    n += slogan[i];
            }

            string newLowReg = n;

            //Смещение всех букв из slogan в начало новой строки
            for (int i = 0; i < lowReg.Length; i++)
            {
                int tmp = 0;
                //Цикл для проверки что буква не находиться в slogan
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

            for (int i = 0; i < massenge.Length; i++)
            {
                //Суть та же что и в шифре Цезаря
                if (lowReg.Contains(massenge[i]))
                    n = lowReg;
                else if (hightReg.Contains(massenge[i]))
                    n = hightReg;
                else
                    result += massenge[i];

                if (n.Contains(massenge[i]))
                {
                    for (int j = 0; j < n.Length; j++)
                    {
                        if (n[j] == massenge[i] && newLowReg.Contains(n[j]))
                            result += newLowReg[j];
                        else if (n[j] == massenge[i])
                            result += newHightReg[j];
                    }
                }
            }

            return result;
        }
    }
}
