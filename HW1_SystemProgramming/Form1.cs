using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaOfGeometricShapes;
using WorkWithText;
using ContactDetails;

namespace HW1_SystemProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_area_Click(object sender, EventArgs e)
        {         
            MessageBox.Show("Площадь квадрата = " + MyAreaOfGeometricShapes.MySquareArea(tb_SidesOfFigure.Text).ToString());
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Площадь прямоугольнака = " + MyAreaOfGeometricShapes.MySquareRectangle(tb_SidesOfFigure.Text).ToString());
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Площадь треугольника = " + MyAreaOfGeometricShapes.MySquareTriangle(tb_SidesOfFigure.Text).ToString());
        }

        private void btn_palindrome_Click(object sender, EventArgs e)
        {
            if (MyWorkWithText.MyIsPalindrome(tb_str.Text))
            {
                MessageBox.Show("Полиндром");
            }
            else
            {
                MessageBox.Show("Это не полиндром");
            }
        }

        private void btn_Proposals_Click(object sender, EventArgs e)
        {           
            MessageBox.Show("Количество предложений в тексте = " + MyWorkWithText.MyNumberProposals(tb_str.Text).ToString());  
        }

        private void btn_Reverse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyWorkWithText.ReverseString(tb_str.Text));
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            if (MyContactDetails.MyNameVerification(tb_name.Text))
            {
                MessageBox.Show("ФИО введено в верном формате");
            }
            else
            {
                MessageBox.Show("ФИО введено в не верном формате");
            }
        }
        private void btn_age_Click(object sender, EventArgs e)
        {
            if (MyContactDetails.MyAgeVerification(tb_age.Text))
            {
                int age = Convert.ToInt32(tb_age.Text);
                if (age > 0 && age < 120)
                {
                    MessageBox.Show("Возраст указан корректно");
                }
                else
                {
                    MessageBox.Show("Возраст указан не корректно. Столько не живут!");
                }
            }
            else
            {
                MessageBox.Show("Возраст указан не корректно");
            }
        }
        private void btn_phone_Click(object sender, EventArgs e)
        {
            if (MyContactDetails.MyPhoneNumberVerification(tb_phone.Text))
            {
                MessageBox.Show("Номер указан в верном формате");
            }
            else
            {
                MessageBox.Show("Номер указан в не верном формате");
            }
        }
        private void btn_email_Click(object sender, EventArgs e)
        {
            if (MyContactDetails.MyEmailVerification(tb_email.Text))
            {
                MessageBox.Show("E-mail указан в верном формате");
            }
            else
            {
                MessageBox.Show("E-mail указан в не верном формате");
            }
        }
    }
}
