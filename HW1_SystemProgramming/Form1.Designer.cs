namespace HW1_SystemProgramming
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
            this.tb_SidesOfFigure = new System.Windows.Forms.TextBox();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.lb_figure = new System.Windows.Forms.Label();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.tb_str = new System.Windows.Forms.TextBox();
            this.btn_palindrome = new System.Windows.Forms.Button();
            this.btn_Proposals = new System.Windows.Forms.Button();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_age = new System.Windows.Forms.Button();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.btn_phone = new System.Windows.Forms.Button();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_SidesOfFigure
            // 
            this.tb_SidesOfFigure.Location = new System.Drawing.Point(9, 64);
            this.tb_SidesOfFigure.Name = "tb_SidesOfFigure";
            this.tb_SidesOfFigure.Size = new System.Drawing.Size(232, 20);
            this.tb_SidesOfFigure.TabIndex = 0;
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(9, 90);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(176, 23);
            this.btn_area.TabIndex = 1;
            this.btn_area.Text = "Расчитать площадь квадрата";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Location = new System.Drawing.Point(9, 119);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(232, 23);
            this.btn_rectangle.TabIndex = 1;
            this.btn_rectangle.Text = "Расчитать площадь прямоугольника";
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // lb_figure
            // 
            this.lb_figure.AutoSize = true;
            this.lb_figure.Location = new System.Drawing.Point(6, 9);
            this.lb_figure.Name = "lb_figure";
            this.lb_figure.Size = new System.Drawing.Size(235, 52);
            this.lb_figure.TabIndex = 2;
            this.lb_figure.Text = "Для расчета площади фигуры введите: \r\n- сторону квадрата\r\n- стороны прямоугольник" +
    "а через \";\"\r\n- основание и высоту треугольника через \";\"";
            // 
            // btn_triangle
            // 
            this.btn_triangle.Location = new System.Drawing.Point(9, 148);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(232, 23);
            this.btn_triangle.TabIndex = 1;
            this.btn_triangle.Text = "Расчитать площадь треугольника";
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // tb_str
            // 
            this.tb_str.Location = new System.Drawing.Point(281, 25);
            this.tb_str.Multiline = true;
            this.tb_str.Name = "tb_str";
            this.tb_str.Size = new System.Drawing.Size(385, 59);
            this.tb_str.TabIndex = 0;
            // 
            // btn_palindrome
            // 
            this.btn_palindrome.Location = new System.Drawing.Point(281, 90);
            this.btn_palindrome.Name = "btn_palindrome";
            this.btn_palindrome.Size = new System.Drawing.Size(91, 23);
            this.btn_palindrome.TabIndex = 1;
            this.btn_palindrome.Text = "Полиндром?";
            this.btn_palindrome.UseVisualStyleBackColor = true;
            this.btn_palindrome.Click += new System.EventHandler(this.btn_palindrome_Click);
            // 
            // btn_Proposals
            // 
            this.btn_Proposals.Location = new System.Drawing.Point(519, 90);
            this.btn_Proposals.Name = "btn_Proposals";
            this.btn_Proposals.Size = new System.Drawing.Size(147, 23);
            this.btn_Proposals.TabIndex = 1;
            this.btn_Proposals.Text = "Количесво предложений";
            this.btn_Proposals.UseVisualStyleBackColor = true;
            this.btn_Proposals.Click += new System.EventHandler(this.btn_Proposals_Click);
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(387, 90);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(126, 23);
            this.btn_Reverse.TabIndex = 1;
            this.btn_Reverse.Text = "Перевернуть текст";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(278, 9);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(75, 13);
            this.lb_text.TabIndex = 2;
            this.lb_text.Text = "Введите текс";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(9, 207);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(232, 20);
            this.tb_name.TabIndex = 0;
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(9, 233);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(105, 23);
            this.btn_name.TabIndex = 3;
            this.btn_name.Text = "Проверить ФИО";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(6, 191);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(79, 13);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Введите ФИО";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(6, 273);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(93, 13);
            this.lb_age.TabIndex = 2;
            this.lb_age.Text = "Введите возраст";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(9, 289);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(125, 20);
            this.tb_age.TabIndex = 0;
            // 
            // btn_age
            // 
            this.btn_age.Location = new System.Drawing.Point(9, 315);
            this.btn_age.Name = "btn_age";
            this.btn_age.Size = new System.Drawing.Size(125, 23);
            this.btn_age.TabIndex = 3;
            this.btn_age.Text = "Проверить возраст";
            this.btn_age.UseVisualStyleBackColor = true;
            this.btn_age.Click += new System.EventHandler(this.btn_age_Click);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(6, 350);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(283, 13);
            this.lb_phone.TabIndex = 2;
            this.lb_phone.Text = "Введите номер телефона в формате: +7(999)999-99-99";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(9, 366);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(194, 20);
            this.tb_phone.TabIndex = 0;
            // 
            // btn_phone
            // 
            this.btn_phone.Location = new System.Drawing.Point(9, 392);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(194, 23);
            this.btn_phone.TabIndex = 3;
            this.btn_phone.Text = "Проверить номер телефона";
            this.btn_phone.UseVisualStyleBackColor = true;
            this.btn_phone.Click += new System.EventHandler(this.btn_phone_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(6, 432);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(79, 13);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Введите e-mail";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(9, 448);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(194, 20);
            this.tb_email.TabIndex = 0;
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(9, 474);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(194, 23);
            this.btn_email.TabIndex = 3;
            this.btn_email.Text = "Проверить e-mail";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_phone);
            this.Controls.Add(this.btn_age);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_figure);
            this.Controls.Add(this.btn_triangle);
            this.Controls.Add(this.btn_rectangle);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.btn_Proposals);
            this.Controls.Add(this.btn_palindrome);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.tb_str);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_SidesOfFigure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SidesOfFigure;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Label lb_figure;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.TextBox tb_str;
        private System.Windows.Forms.Button btn_palindrome;
        private System.Windows.Forms.Button btn_Proposals;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_age;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Button btn_phone;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_email;
    }
}

