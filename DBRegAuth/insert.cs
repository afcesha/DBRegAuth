using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBRegAuth
{
    public partial class insert : Form
    {
        DBCon con1;
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
            con1 = new DBCon();
            textBox1_surname.MaxLength = 50;
            textBox2_name.MaxLength = 50;
            textBox3_fathername.MaxLength = 50; // задаем ограничения по длине
            textBox4_login.MaxLength = 50;
            textBox5_password.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var surname = textBox1_surname.Text;
            var name = textBox2_name.Text;
            var fathername = textBox3_fathername.Text;
            var usrlogin = textBox4_login.Text;  // берем текст из текстбоксов
            var password = textBox5_password.Text;
            var birthday = maskedTextBox1_birthday.Text;

            con1.OpenCon();
            if ((surname.Length == 0) || (name.Length == 0) || (fathername.Length == 0) || (usrlogin.Length == 0) || (password.Length == 0) || (birthday.Length == 0)) // проверяем все ли данные заполнены
            {
                MessageBox.Show("Заполни все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // если нет, то ошибка
            }
            else // если да, то проверяем, есть ли такой пользователь уже
            {
                string query1 = $"Select login from Users where login = '{usrlogin}'";
                SqlCommand com2 = new SqlCommand(query1);
                com2.Connection = con1.GetCon();
                SqlDataAdapter da1 = new SqlDataAdapter(com2);
                DataTable table = new DataTable();
                da1.Fill(table);
                if (table.Rows.Count != 0) // если есть, то ошибка
                {
                    MessageBox.Show("Такой пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else // если нет, то через insert вносим данные через executenonquery. executenonquery используется в функциях insert, delete, update. в selecte нужно использовать sqldataadapter
                {
                    string query = $"insert users ([Фамилия], [Имя], [Отчество],[Дата_рождения], [login], [password]) values ('{surname}', '{name}','{fathername}','{birthday}', '{usrlogin}', '{password}')";
                    SqlCommand com1 = new SqlCommand(query);
                    com1.Connection = con1.GetCon();
                    com1.ExecuteNonQuery();
                    this.Hide();
                }
            }
            con1.CloseCon();
        }
    }
}
