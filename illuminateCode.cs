using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shifr
{
    
    class illuminateCode
    {

        public illuminateCode() 
        {
            
        }

        static public void Decoding(string massenge, FlowLayoutPanel image)
        {
            string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя", n = "", result = "";
            var exePath = AppDomain.CurrentDomain.BaseDirectory;

            n = massenge.ToUpper();
            result = lowReg.ToUpper() + " ";
            //Создание массива с индексами элементов
            for(int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (n[i] == result[j] && n[i] != ' ')
                    {
                        image.Controls.Add(new PictureBox()
                        {
                            Image = Image.FromFile(System.IO.Path.Combine(exePath, $"Image\\{n[i]}.png"))
                        });
                    }
                    else if (n[i] == result[j] && n[i] == ' ')
                    {
                        image.Controls.Add(new PictureBox()
                        {
                            Image = Image.FromFile(System.IO.Path.Combine(exePath, "Image\\1.png"))
                        });
                    }
                }
            }
        }
    }
}
