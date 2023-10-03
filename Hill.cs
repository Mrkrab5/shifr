using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    internal class Hill
    {

        public Hill() 
        {
            
        }

        static public string Decoding(string massenge)
        {
            string n = massenge.ToLower(), result = "", lowRegChar = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ";
            int[,] array = { { 4, 5 }, { 3, 4 } };

            Dictionary<char, int> lowReg = new Dictionary<char, int>
            { {'а', 0},  {'б', 1},  {'в', 2},  {'г', 3},  {'д', 4},  {'е', 5},  {'ё', 6},  {'ж', 7},  {'з', 8},  {'и', 9},
              {'й', 10}, {'к', 11}, {'л', 12}, {'м', 13}, {'н', 14}, {'о', 15}, {'п', 16}, {'р', 17}, {'с', 18}, {'т', 19},
              {'у', 20}, {'ф', 21}, {'х', 22}, {'ц', 23}, {'ч', 24}, {'ш', 25}, {'щ', 26}, {'ъ', 27}, {'ы', 28}, {'ь', 29}, 
              {'э', 30}, {'ю', 31}, {'я', 32}, {' ', 33}};

            if (n.Length % 2 == 1)
                n += ' ';

            for (int i = 0; i < n.Length; i += 2)
            {
                int a, b;
                a = (array[0, 0] * lowReg[n[i]] + array[0, 1] * lowReg[n[i + 1]]) % lowReg.Count;
                b = (array[1, 0] * lowReg[n[i]] + array[1, 1] * lowReg[n[i + 1]]) % lowReg.Count;
                result += $"{lowRegChar[a]}{lowRegChar[b]} ";
            }

            return result;
        }
    }
}
