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
            seance_list();
         
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
                string query = $"Delete from Пользователи where user_login = '{deletelogin}'";
                SqlCommand com1 = new SqlCommand(query);
                com1.Connection = con1.GetCon();
                com1.ExecuteNonQuery();
                con1.CloseCon();
                this.Hide();
                login login = new login();
                login.Show();
            }
            
        }

        private void seance_list()
        {
            string seance_query = $"SELECT Сеансы.Код_сеанса, Сеансы.Код_кинозала, Сеансы.Дата, " +
                "Сеансы.Время, Фильмы.Название FROM Сеансы " +
                "JOIN Фильмы ON Сеансы.Код_фильма = Фильмы.Код_фильма";

            SqlCommand com2 = new SqlCommand(seance_query);
            com2.CommandType = CommandType.Text;
            com2.Connection = con1.GetCon();
            SqlDataAdapter da1 = new SqlDataAdapter(com2);
            DataTable table = new DataTable();
            da1.Fill(table);
            comboBox_seance.DisplayMember = "Код_сеанса";
            comboBox_seance.ValueMember = "Код_сеанса";
            comboBox_seance.DataSource = table;
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seance_places seance_Places = new seance_places(Convert.ToInt32(comboBox_seance.SelectedValue));
            this.Hide();
            seance_Places.Show();
        }
    }
}
