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
    public partial class registration : Form
    {
        DBCon con1;
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            con1 = new DBCon();
            textBox5_password.PasswordChar= '*';
            textBox4_login.MaxLength = 50;
            textBox5_password.MaxLength = 50;
            textBox6_confirmpassword.MaxLength = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var surname = textBox1_surname.Text;
            var name = textBox2_name.Text;
            var fathername = textBox3_fathername.Text;
            var usrlogin = textBox4_login.Text;
            var password = textBox5_password.Text;
            var confirmpassword = textBox6_confirmpassword.Text;

            con1.OpenCon();
            if ((surname == " ") || (name == " ") || (fathername == " ") || (usrlogin == " ") || (password == " ") || (confirmpassword == " "))
            {
                MessageBox.Show("Заполни все данные", "Дебил", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password == confirmpassword)
                {
                    string query = $"insert Пользователи ([Фамилия], [Имя], [Отчество], [login], [password]) values (N'{surname}', N'{name}',N'{fathername}', N'{usrlogin}', N'{password}')";
                    SqlCommand com1 = new SqlCommand(query);
                    com1.Connection = con1.GetCon();
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Молодец", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    login login = new login();
                    login.Show();
                }
                else
                    MessageBox.Show("Пароли не совпадают", "Дебил", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                


        }
    }
}
