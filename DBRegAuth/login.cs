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
    public partial class login : Form
    {
        DBCon con1 = new DBCon();
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_pass.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_pass.MaxLength = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var login = textBox_login.Text;
            var pass = textBox_pass.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"Select user_password from dbo.Пользователи where  user_password = '{pass}'";

            SqlCommand com1 = new SqlCommand(query, con1.GetCon());

            adapter.SelectCommand = com1;
            // adapter.Fill(table);

            MessageBox.Show(table.ToString());

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Молодец","Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Не молодец", "Дебил", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
