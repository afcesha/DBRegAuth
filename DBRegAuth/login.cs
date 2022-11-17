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

            var login = textBox_login.Text;
            var pass = textBox_pass.Text;

            con1.OpenCon();

            string query = $"Select user_login, user_password from Пользователи where user_login = '{login}' and user_password = '{pass}'";

            SqlCommand _comSel2 = new SqlCommand(query);
            _comSel2.Connection = con1.GetCon();
            //_comSel2.ExecuteNonQuery();

            SqlDataAdapter _da1 = new SqlDataAdapter(_comSel2);
            DataTable table = new DataTable();

            _da1.Fill(table);


            /*adapter.SelectCommand = com1;
            adapter.Fill(table);*/


            //MessageBox.Show(table.Rows[0][0].ToString());

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Молодец","Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Не молодец", "Дебил", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
