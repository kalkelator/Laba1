using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Dmytro" && textBox_Password.Text == "1234567")
            {
                MessageBox.Show("Hello Dmytro");
                label_OK.BackColor = Color.Green;
            }
            else if (textBox_Login.Text == "" || textBox_Login.Text == "Введіть логін")
            {
                MessageBox.Show("Введіть логін");
                label_OK.BackColor = Color.Red;
            }
            else if (textBox_Password.Text == "" || textBox_Password.Text == "Введіть пароль")
            {
                MessageBox.Show("Введіть пароль");
                label_OK.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Невірний логін чи пароль");
                label_OK.BackColor = Color.Red;
                textBox_Login.Text = "";
                textBox_Password.Text = "";
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
