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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


            string query = $"Select * from Users";
            SqlCommand com1 = new SqlCommand(query); // 
            com1.Connection = con1.GetCon();
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable table = new DataTable();
            da1.Fill(table);

            // выше мы получаем данные из таблицы Users в приложение используя запрос Select, и используя адаптер для преобразования, чтобы visual studio понимал данные
            dataGridView1.DataSource = table;
            // здесь мы отображаем полученные данные в datagridView
        }
        public static string deletelogin = "";
        public static int usercode;

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
                string query = $"Delete from Users where login = '{deletelogin}'";
                SqlCommand com1 = new SqlCommand(query);
                com1.Connection = con1.GetCon();
                com1.ExecuteNonQuery();
                con1.CloseCon();
                this.Hide();
                login login = new login();
                login.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insert insert = new insert();
            insert.Show();
            // кнопка открывает новую форму, где можно будет ввести данные которые нужно добавить
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $"Select * from Users";
            SqlCommand com1 = new SqlCommand(query); // 
            com1.Connection = con1.GetCon();
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable table = new DataTable();
            da1.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
