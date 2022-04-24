namespace Lab1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типПодстановкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одноалфавитнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 175);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(300, 101);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(183, 175);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сдвиг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исходный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зашифрованный текст";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типПодстановкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типПодстановкиToolStripMenuItem
            // 
            this.типПодстановкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одноалфавитнаяToolStripMenuItem,
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem,
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem});
            this.типПодстановкиToolStripMenuItem.Name = "типПодстановкиToolStripMenuItem";
            this.типПодстановкиToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.типПодстановкиToolStripMenuItem.Text = "Тип подстановки";
            // 
            // одноалфавитнаяToolStripMenuItem
            // 
            this.одноалфавитнаяToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.одноалфавитнаяToolStripMenuItem.Name = "одноалфавитнаяToolStripMenuItem";
            this.одноалфавитнаяToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.одноалфавитнаяToolStripMenuItem.Text = "Одноалфавитная";
            this.одноалфавитнаяToolStripMenuItem.Click += new System.EventHandler(this.одноалфавитнаяToolStripMenuItem_Click);
            // 
            // многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem
            // 
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem.Name = "многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem";
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem.Text = "Многоалфавитная одноконтурная обыкновенная";
            this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem.Click += new System.EventHandler(this.многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem_Click);
            // 
            // многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem
            // 
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem.Name = "многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem";
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem.Text = "Многоалфавитная одноконтурная монофоническая";
            this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem.Click += new System.EventHandler(this.многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шифрование одноалфавитной подстановкой";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(521, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Шифрование одноалфавитной подстановкой";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типПодстановкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одноалфавитнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

