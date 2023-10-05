
namespace shifr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.choiceMethod = new System.Windows.Forms.ComboBox();
            this.choiseLabel = new System.Windows.Forms.Label();
            this.whatEncrypt = new System.Windows.Forms.Label();
            this.entryMasseng = new System.Windows.Forms.TextBox();
            this.dopYsl = new System.Windows.Forms.TextBox();
            this.dopYslLabel = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.Label();
            this.itogEncrypt = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.imageOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // choiceMethod
            // 
            this.choiceMethod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiceMethod.FormattingEnabled = true;
            this.choiceMethod.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Лозунговый шифр",
            "Полибианский квадрат",
            "Шифрующая система Трисемуса",
            "Шифр Playfair",
            "Система омофонов",
            "Шифр массонов",
            "Биграмный шифр Порты",
            "Шифр Хилла",
            "Вариантный шифр",
            "Шифр Тени",
            "Шифр Виженера"});
            this.choiceMethod.Location = new System.Drawing.Point(33, 150);
            this.choiceMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choiceMethod.Name = "choiceMethod";
            this.choiceMethod.Size = new System.Drawing.Size(300, 30);
            this.choiceMethod.TabIndex = 0;
            this.choiceMethod.SelectedIndexChanged += new System.EventHandler(this.choiceMethod_SelectedIndexChanged);
            // 
            // choiseLabel
            // 
            this.choiseLabel.AutoSize = true;
            this.choiseLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseLabel.Location = new System.Drawing.Point(81, 122);
            this.choiseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choiseLabel.Name = "choiseLabel";
            this.choiseLabel.Size = new System.Drawing.Size(213, 27);
            this.choiseLabel.TabIndex = 1;
            this.choiseLabel.Text = "Метод шифрования";
            // 
            // whatEncrypt
            // 
            this.whatEncrypt.AutoSize = true;
            this.whatEncrypt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatEncrypt.Location = new System.Drawing.Point(316, 11);
            this.whatEncrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.whatEncrypt.Name = "whatEncrypt";
            this.whatEncrypt.Size = new System.Drawing.Size(193, 31);
            this.whatEncrypt.TabIndex = 2;
            this.whatEncrypt.Text = "Что шифровать";
            // 
            // entryMasseng
            // 
            this.entryMasseng.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryMasseng.Location = new System.Drawing.Point(16, 62);
            this.entryMasseng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryMasseng.Name = "entryMasseng";
            this.entryMasseng.Size = new System.Drawing.Size(767, 38);
            this.entryMasseng.TabIndex = 3;
            // 
            // dopYsl
            // 
            this.dopYsl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dopYsl.Location = new System.Drawing.Point(395, 150);
            this.dopYsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dopYsl.Name = "dopYsl";
            this.dopYsl.Size = new System.Drawing.Size(368, 35);
            this.dopYsl.TabIndex = 4;
            this.dopYsl.Visible = false;
            // 
            // dopYslLabel
            // 
            this.dopYslLabel.AutoSize = true;
            this.dopYslLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dopYslLabel.Location = new System.Drawing.Point(436, 122);
            this.dopYslLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dopYslLabel.Name = "dopYslLabel";
            this.dopYslLabel.Size = new System.Drawing.Size(269, 27);
            this.dopYslLabel.TabIndex = 5;
            this.dopYslLabel.Text = "Дополнительные данные";
            // 
            // itog
            // 
            this.itog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog.Location = new System.Drawing.Point(284, 220);
            this.itog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(267, 26);
            this.itog.TabIndex = 6;
            this.itog.Text = "Результат шифрования:";
            // 
            // itogEncrypt
            // 
            this.itogEncrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogEncrypt.Location = new System.Drawing.Point(16, 265);
            this.itogEncrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itogEncrypt.Name = "itogEncrypt";
            this.itogEncrypt.Size = new System.Drawing.Size(767, 86);
            this.itogEncrypt.TabIndex = 7;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(321, 382);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(192, 54);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // imageOutput
            // 
            this.imageOutput.Location = new System.Drawing.Point(16, 246);
            this.imageOutput.Margin = new System.Windows.Forms.Padding(0);
            this.imageOutput.Name = "imageOutput";
            this.imageOutput.Size = new System.Drawing.Size(767, 132);
            this.imageOutput.TabIndex = 9;
            this.imageOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageOutput);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.itogEncrypt);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.dopYslLabel);
            this.Controls.Add(this.dopYsl);
            this.Controls.Add(this.entryMasseng);
            this.Controls.Add(this.whatEncrypt);
            this.Controls.Add(this.choiseLabel);
            this.Controls.Add(this.choiceMethod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choiceMethod;
        private System.Windows.Forms.Label choiseLabel;
        private System.Windows.Forms.Label whatEncrypt;
        private System.Windows.Forms.TextBox entryMasseng;
        private System.Windows.Forms.TextBox dopYsl;
        private System.Windows.Forms.Label dopYslLabel;
        private System.Windows.Forms.Label itog;
        private System.Windows.Forms.Label itogEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.FlowLayoutPanel imageOutput;
    }
}

