namespace ConvertNum
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
            this.SetNum = new System.Windows.Forms.TextBox();
            this.OneNum = new System.Windows.Forms.ComboBox();
            this.EndNum = new System.Windows.Forms.ComboBox();
            this.Sum = new System.Windows.Forms.Button();
            this.UserNum = new System.Windows.Forms.Label();
            this.Rezultat = new System.Windows.Forms.Label();
            this.IzNum = new System.Windows.Forms.Label();
            this.Vnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetNum
            // 
            this.SetNum.Location = new System.Drawing.Point(111, 195);
            this.SetNum.Name = "SetNum";
            this.SetNum.Size = new System.Drawing.Size(112, 20);
            this.SetNum.TabIndex = 0;
            this.SetNum.TextChanged += new System.EventHandler(this.SetNum_TextChanged);
            // 
            // OneNum
            // 
            this.OneNum.FormattingEnabled = true;
            this.OneNum.Location = new System.Drawing.Point(229, 194);
            this.OneNum.Name = "OneNum";
            this.OneNum.Size = new System.Drawing.Size(103, 21);
            this.OneNum.TabIndex = 1;
            this.OneNum.SelectedIndexChanged += new System.EventHandler(this.OneNum_SelectedIndexChanged);
            // 
            // EndNum
            // 
            this.EndNum.FormattingEnabled = true;
            this.EndNum.Location = new System.Drawing.Point(338, 194);
            this.EndNum.Name = "EndNum";
            this.EndNum.Size = new System.Drawing.Size(94, 21);
            this.EndNum.TabIndex = 2;
            this.EndNum.SelectedIndexChanged += new System.EventHandler(this.EndNum_SelectedIndexChanged);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(462, 186);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(122, 36);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Вычислить";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // UserNum
            // 
            this.UserNum.AutoSize = true;
            this.UserNum.Location = new System.Drawing.Point(108, 168);
            this.UserNum.Name = "UserNum";
            this.UserNum.Size = new System.Drawing.Size(81, 13);
            this.UserNum.TabIndex = 4;
            this.UserNum.Text = "Введите число";
            this.UserNum.Click += new System.EventHandler(this.UserNum_Click);
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSize = true;
            this.Rezultat.Location = new System.Drawing.Point(108, 233);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(71, 13);
            this.Rezultat.TabIndex = 5;
            this.Rezultat.Text = "Результат: 0";
            this.Rezultat.Click += new System.EventHandler(this.Rezultat_Click);
            // 
            // IzNum
            // 
            this.IzNum.AutoSize = true;
            this.IzNum.Location = new System.Drawing.Point(226, 168);
            this.IzNum.Name = "IzNum";
            this.IzNum.Size = new System.Drawing.Size(80, 13);
            this.IzNum.TabIndex = 6;
            this.IzNum.Text = "Перевести из:";
            this.IzNum.Click += new System.EventHandler(this.IzNum_Click);
            // 
            // Vnum
            // 
            this.Vnum.AutoSize = true;
            this.Vnum.Location = new System.Drawing.Point(335, 168);
            this.Vnum.Name = "Vnum";
            this.Vnum.Size = new System.Drawing.Size(74, 13);
            this.Vnum.TabIndex = 7;
            this.Vnum.Text = "Перевести в:";
            this.Vnum.Click += new System.EventHandler(this.Vnum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vnum);
            this.Controls.Add(this.IzNum);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.UserNum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.EndNum);
            this.Controls.Add(this.OneNum);
            this.Controls.Add(this.SetNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetNum;
        private System.Windows.Forms.ComboBox OneNum;
        private System.Windows.Forms.ComboBox EndNum;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Label UserNum;
        private System.Windows.Forms.Label Rezultat;
        private System.Windows.Forms.Label IzNum;
        private System.Windows.Forms.Label Vnum;
    }
}

