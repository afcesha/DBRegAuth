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
using System.Reflection.Emit;

namespace DBRegAuth
{
    public partial class login : Form
    {
        DBCon con1;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            con1 = new DBCon();
            textBox_pass.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_pass.MaxLength = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var usrlogin = textBox_login.Text;
            var usrpass = textBox_pass.Text;

            con1.OpenCon();

            string query = $"Select login, password from Users where login = '{usrlogin}' and password = '{usrpass}'";
            string query1 = $"Select Имя from Users where login = '{usrlogin}'";
            string query2 = $"Select id_users from Users where login = '{usrlogin}'";

            SqlCommand com1 = new SqlCommand(query);
            com1.Connection = con1.GetCon();
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable table = new DataTable();
            da1.Fill(table);

            SqlCommand com2 = new SqlCommand(query1);
            com2.Connection = con1.GetCon();
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            DataTable table1 = new DataTable();
            da2.Fill(table1);
            SqlCommand com3 = new SqlCommand(query2);
            com3.Connection = con1.GetCon();
            SqlDataAdapter da3 = new SqlDataAdapter(com3);
            DataTable table2 = new DataTable();
            da3.Fill(table2);
            string pizda = table2.Rows[0][0].ToString();
            int piska = Convert.ToInt32(pizda);
            



            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Молодец","Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main main = new main();
                this.Hide();
                main.label1.Text = "Добро пожаловать, " + table1.Rows[0][0];
                main.deletelogin = usrlogin.ToString();
                main.ShowDialog();
                
            }
            else
                MessageBox.Show("Данные введены неправильно или такого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con1.CloseCon();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registration registration = new registration();
            this.Hide();
            registration.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
