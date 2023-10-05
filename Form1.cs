using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiceMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiceMethod.SelectedIndex == 0)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: сдвиг";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }

            else if (choiceMethod.SelectedIndex == 1)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: слоган";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }
            else if ( choiceMethod.SelectedIndex == 2)
            {
                dopYsl.Visible = false;
                dopYslLabel.Visible = false;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные";
                dopYslLabel.Location = new Point(327, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 3)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: слово";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 4)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: слово";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 5)
            {
                dopYsl.Visible = false;
                dopYslLabel.Visible = false;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные";
                dopYslLabel.Location = new Point(327, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 6)
            {
                dopYsl.Visible = false;
                dopYslLabel.Visible = false;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные";
                dopYslLabel.Location = new Point(327, 99);
                imageOutput.Visible = true;
            }
            else if (choiceMethod.SelectedIndex == 7)
            {
                dopYsl.Visible = false;
                dopYslLabel.Visible = false;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные";
                dopYslLabel.Location = new Point(327, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 8)
            {
                dopYsl.Visible = false;
                dopYslLabel.Visible = false;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные";
                dopYslLabel.Location = new Point(327, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 9)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: слово";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }
            else if (choiceMethod.SelectedIndex == 11)
            {
                dopYsl.Visible = true;
                dopYslLabel.Visible = true;
                dopYsl.Text = "";
                dopYslLabel.Text = "Дополнительные данные: слово";
                dopYslLabel.Location = new Point(292, 99);
                imageOutput.Visible = false;
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (choiceMethod.SelectedIndex == 0)
                itogEncrypt.Text = CeasarCode.Decoding(entryMasseng.Text, Convert.ToInt32(dopYsl.Text));

            else if (choiceMethod.SelectedIndex == 1)
                itogEncrypt.Text = sloganEncryption.Decoding(entryMasseng.Text, dopYsl.Text);

            else if (choiceMethod.SelectedIndex == 2)
                itogEncrypt.Text = polobianSquare.Decoding(entryMasseng.Text);

            else if (choiceMethod.SelectedIndex == 3)
                itogEncrypt.Text = Tritemia.Decoding(entryMasseng.Text, dopYsl.Text);

            else if (choiceMethod.SelectedIndex == 4)
                itogEncrypt.Text = Playfair.Decoding(entryMasseng.Text, dopYsl.Text);

            else if (choiceMethod.SelectedIndex == 5)
                itogEncrypt.Text = systemMultivalued.Decoding(entryMasseng.Text);

            else if (choiceMethod.SelectedIndex == 6)
            {
                imageOutput.Controls.Clear();
                illuminateCode.Decoding(entryMasseng.Text, imageOutput);
            }

            else if (choiceMethod.SelectedIndex == 7)
                itogEncrypt.Text = Porta.Decoding(entryMasseng.Text);

            else if (choiceMethod.SelectedIndex == 8)
                itogEncrypt.Text = Hill.Decoding(entryMasseng.Text);

            else if (choiceMethod.SelectedIndex == 9)
                itogEncrypt.Text = OptionShifr.Decoding(entryMasseng.Text, dopYsl.Text);

            else if (choiceMethod.SelectedIndex == 11)
                itogEncrypt.Text = VisenerShifr.Decoding(entryMasseng.Text, dopYsl.Text);
        }
    }
}
