namespace EncoderRSA
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Plain_Text = new System.Windows.Forms.RichTextBox();
            this.groupBox_text = new System.Windows.Forms.GroupBox();
            this.Copy = new System.Windows.Forms.Button();
            this.richTextBox_Cipher_Text = new System.Windows.Forms.RichTextBox();
            this.Decode = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Close_In_File = new System.Windows.Forms.Button();
            this.Close_Of_File = new System.Windows.Forms.Button();
            this.Open_In_Fail = new System.Windows.Forms.Button();
            this.Open_Of_File = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.GeneratingKey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_phi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_text.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Plain_Text
            // 
            this.richTextBox_Plain_Text.Location = new System.Drawing.Point(6, 22);
            this.richTextBox_Plain_Text.Name = "richTextBox_Plain_Text";
            this.richTextBox_Plain_Text.Size = new System.Drawing.Size(738, 192);
            this.richTextBox_Plain_Text.TabIndex = 1;
            this.richTextBox_Plain_Text.Text = "";
            // 
            // groupBox_text
            // 
            this.groupBox_text.Controls.Add(this.Copy);
            this.groupBox_text.Controls.Add(this.richTextBox_Cipher_Text);
            this.groupBox_text.Controls.Add(this.Decode);
            this.groupBox_text.Controls.Add(this.richTextBox_Plain_Text);
            this.groupBox_text.Controls.Add(this.Encode);
            this.groupBox_text.Location = new System.Drawing.Point(12, 4);
            this.groupBox_text.Name = "groupBox_text";
            this.groupBox_text.Size = new System.Drawing.Size(750, 470);
            this.groupBox_text.TabIndex = 3;
            this.groupBox_text.TabStop = false;
            this.groupBox_text.Text = "Работа с текстом";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(697, 221);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(47, 24);
            this.Copy.TabIndex = 4;
            this.Copy.Text = "^";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // richTextBox_Cipher_Text
            // 
            this.richTextBox_Cipher_Text.Location = new System.Drawing.Point(6, 256);
            this.richTextBox_Cipher_Text.Name = "richTextBox_Cipher_Text";
            this.richTextBox_Cipher_Text.Size = new System.Drawing.Size(738, 196);
            this.richTextBox_Cipher_Text.TabIndex = 3;
            this.richTextBox_Cipher_Text.Text = "";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(383, 221);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(115, 29);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Расшифровать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(258, 221);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(119, 29);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Зашифровать";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Close_In_File);
            this.groupBox7.Controls.Add(this.Close_Of_File);
            this.groupBox7.Controls.Add(this.Open_In_Fail);
            this.groupBox7.Controls.Add(this.Open_Of_File);
            this.groupBox7.Location = new System.Drawing.Point(768, 302);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(262, 172);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Работа с файлом";
            // 
            // Close_In_File
            // 
            this.Close_In_File.Location = new System.Drawing.Point(6, 133);
            this.Close_In_File.Name = "Close_In_File";
            this.Close_In_File.Size = new System.Drawing.Size(249, 31);
            this.Close_In_File.TabIndex = 5;
            this.Close_In_File.Text = "Загрузка закрыт. текста в файл";
            this.Close_In_File.UseVisualStyleBackColor = true;
            this.Close_In_File.Click += new System.EventHandler(this.Close_In_File_Click);
            // 
            // Close_Of_File
            // 
            this.Close_Of_File.Location = new System.Drawing.Point(6, 96);
            this.Close_Of_File.Name = "Close_Of_File";
            this.Close_Of_File.Size = new System.Drawing.Size(249, 31);
            this.Close_Of_File.TabIndex = 2;
            this.Close_Of_File.Text = "Выгрузка закрыт. текста из файла";
            this.Close_Of_File.UseVisualStyleBackColor = true;
            this.Close_Of_File.Click += new System.EventHandler(this.Close_Of_File_Click);
            // 
            // Open_In_Fail
            // 
            this.Open_In_Fail.Location = new System.Drawing.Point(6, 57);
            this.Open_In_Fail.Name = "Open_In_Fail";
            this.Open_In_Fail.Size = new System.Drawing.Size(249, 32);
            this.Open_In_Fail.TabIndex = 1;
            this.Open_In_Fail.Text = "Загрузка открыт. текста в файл";
            this.Open_In_Fail.UseVisualStyleBackColor = true;
            this.Open_In_Fail.Click += new System.EventHandler(this.Open_In_Fail_Click);
            // 
            // Open_Of_File
            // 
            this.Open_Of_File.Location = new System.Drawing.Point(6, 22);
            this.Open_Of_File.Name = "Open_Of_File";
            this.Open_Of_File.Size = new System.Drawing.Size(249, 29);
            this.Open_Of_File.TabIndex = 0;
            this.Open_Of_File.Text = "Выгрузка открыт. текста из файла";
            this.Open_Of_File.UseVisualStyleBackColor = true;
            this.Open_Of_File.Click += new System.EventHandler(this.Open_Of_File_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.GeneratingKey);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.textBox_e);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.textBox_d);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.textBox_n);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.textBox_p);
            this.groupBox8.Controls.Add(this.textBox_q);
            this.groupBox8.Location = new System.Drawing.Point(768, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(262, 236);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Работа с ключами(открытым и закрытым)";
            // 
            // GeneratingKey
            // 
            this.GeneratingKey.Location = new System.Drawing.Point(10, 199);
            this.GeneratingKey.Name = "GeneratingKey";
            this.GeneratingKey.Size = new System.Drawing.Size(246, 31);
            this.GeneratingKey.TabIndex = 5;
            this.GeneratingKey.Text = "Сгенерировать ключи";
            this.GeneratingKey.UseVisualStyleBackColor = true;
            this.GeneratingKey.Click += new System.EventHandler(this.GeneratingKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "e";
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(155, 163);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(100, 25);
            this.textBox_e.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "n";
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(155, 132);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 25);
            this.textBox_d.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "q";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(155, 100);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 25);
            this.textBox_n.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "p";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(155, 37);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 25);
            this.textBox_p.TabIndex = 9;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(155, 68);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 25);
            this.textBox_q.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Функция Эйлера";
            // 
            // textBox_phi
            // 
            this.textBox_phi.Location = new System.Drawing.Point(155, 22);
            this.textBox_phi.Name = "textBox_phi";
            this.textBox_phi.Size = new System.Drawing.Size(100, 25);
            this.textBox_phi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_phi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(768, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_text.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Plain_Text;
        private System.Windows.Forms.GroupBox groupBox_text;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.RichTextBox richTextBox_Cipher_Text;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Close_In_File;
        private System.Windows.Forms.Button Close_Of_File;
        private System.Windows.Forms.Button Open_In_Fail;
        private System.Windows.Forms.Button Open_Of_File;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button GeneratingKey;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_phi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

