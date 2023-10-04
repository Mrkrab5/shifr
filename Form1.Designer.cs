
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
            this.components = new System.ComponentModel.Container();
            this.choiceMethod = new System.Windows.Forms.ComboBox();
            this.choiseLabel = new System.Windows.Forms.Label();
            this.whatEncrypt = new System.Windows.Forms.Label();
            this.entryMasseng = new System.Windows.Forms.TextBox();
            this.dopYsl = new System.Windows.Forms.TextBox();
            this.dopYslLabel = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.Label();
            this.itogEncrypt = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.choiceMethod.Location = new System.Drawing.Point(25, 122);
            this.choiceMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choiceMethod.Name = "choiceMethod";
            this.choiceMethod.Size = new System.Drawing.Size(226, 27);
            this.choiceMethod.TabIndex = 0;
            this.choiceMethod.SelectedIndexChanged += new System.EventHandler(this.choiceMethod_SelectedIndexChanged);
            // 
            // choiseLabel
            // 
            this.choiseLabel.AutoSize = true;
            this.choiseLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseLabel.Location = new System.Drawing.Point(61, 99);
            this.choiseLabel.Name = "choiseLabel";
            this.choiseLabel.Size = new System.Drawing.Size(168, 21);
            this.choiseLabel.TabIndex = 1;
            this.choiseLabel.Text = "Метод шифрования";
            // 
            // whatEncrypt
            // 
            this.whatEncrypt.AutoSize = true;
            this.whatEncrypt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatEncrypt.Location = new System.Drawing.Point(237, 9);
            this.whatEncrypt.Name = "whatEncrypt";
            this.whatEncrypt.Size = new System.Drawing.Size(148, 23);
            this.whatEncrypt.TabIndex = 2;
            this.whatEncrypt.Text = "Что шифровать";
            // 
            // entryMasseng
            // 
            this.entryMasseng.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryMasseng.Location = new System.Drawing.Point(12, 50);
            this.entryMasseng.Name = "entryMasseng";
            this.entryMasseng.Size = new System.Drawing.Size(576, 32);
            this.entryMasseng.TabIndex = 3;
            // 
            // dopYsl
            // 
            this.dopYsl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dopYsl.Location = new System.Drawing.Point(296, 122);
            this.dopYsl.Name = "dopYsl";
            this.dopYsl.Size = new System.Drawing.Size(277, 29);
            this.dopYsl.TabIndex = 4;
            this.dopYsl.Visible = false;
            // 
            // dopYslLabel
            // 
            this.dopYslLabel.AutoSize = true;
            this.dopYslLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dopYslLabel.Location = new System.Drawing.Point(327, 99);
            this.dopYslLabel.Name = "dopYslLabel";
            this.dopYslLabel.Size = new System.Drawing.Size(211, 21);
            this.dopYslLabel.TabIndex = 5;
            this.dopYslLabel.Text = "Дополнительные данные";
            // 
            // itog
            // 
            this.itog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog.Location = new System.Drawing.Point(213, 179);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(200, 21);
            this.itog.TabIndex = 6;
            this.itog.Text = "Результат шифрования:";
            // 
            // itogEncrypt
            // 
            this.itogEncrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogEncrypt.Location = new System.Drawing.Point(52, 235);
            this.itogEncrypt.Name = "itogEncrypt";
            this.itogEncrypt.Size = new System.Drawing.Size(500, 70);
            this.itogEncrypt.TabIndex = 7;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(241, 310);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(144, 44);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.itogEncrypt);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.dopYslLabel);
            this.Controls.Add(this.dopYsl);
            this.Controls.Add(this.entryMasseng);
            this.Controls.Add(this.whatEncrypt);
            this.Controls.Add(this.choiseLabel);
            this.Controls.Add(this.choiceMethod);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ImageList imageList1;
    }
}

