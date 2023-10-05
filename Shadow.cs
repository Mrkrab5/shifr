using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shifr
{
    internal class Shadow
    {

        public Shadow() 
        { 
        
        }

        static public void Decoding(string massenge, FlowLayoutPanel image)
        {
            string lowReg = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя 1234", n = lowReg.ToUpper(), result = massenge.ToUpper();
            var exePath = AppDomain.CurrentDomain.BaseDirectory;
            int shift = 0;

            for (int i = 0; i < massenge.Length; i++)
            {
                for(int j = 0; j < lowReg.Length; j++)
                {
                    if (result[i] == n[j] && j < 34)
                    {
                        image.Controls.Add(new PictureBox()
                        {
                            Image = Image.FromFile(System.IO.Path.Combine(exePath, $"Shadow\\{n[(j + shift) % 34]}.png"))
                        });
                    }
                    else if (result[i] == n[j] && j > 34)
                    {
                        image.Controls.Add(new PictureBox()
                        {
                            Image = Image.FromFile(System.IO.Path.Combine(exePath, $"Shadow\\{n[j]}.png"))
                        });
                        shift = Convert.ToInt32(lowReg[j]) - 1;
                    }
                }
            }  
        }
    }
}
