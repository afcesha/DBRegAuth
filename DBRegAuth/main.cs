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
    public partial class main : Form
    {
        DBCon con1;
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            con1 = new DBCon();
        }
        public string deletelogin = "";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var del = MessageBox.Show("Вы действительно хотите удалить аккаунт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del== DialogResult.Yes)
            {
                con1.OpenCon();
                string query = $"Delete from Пользователи where login = '{deletelogin}'";
                SqlCommand com1 = new SqlCommand(query);
                com1.Connection = con1.GetCon();
                com1.ExecuteNonQuery();
                con1.CloseCon();
                this.Hide();
                login login = new login();
                login.Show();
            }
            
        }
    }
}
