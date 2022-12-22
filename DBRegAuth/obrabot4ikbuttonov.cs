using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBRegAuth
{
    class MakeButtonsInHall : Panel
    {
        string user = main.deletelogin;
        DataTable seansTable;
        DataTable hallTable;
        DataTable userTickets;
        DataTable mesto;
       // DataTable code;
        Button[] button1;
        DBCon con1;
        int _seans;

        public MakeButtonsInHall(int seans)
        {
            userTickets = new DataTable();
            hallTable = new DataTable();
            seansTable = new DataTable();
            mesto = new DataTable();
          //  code = new DataTable();
            con1 = new DBCon();
            _seans = seans;
            GetTickets(_seans);
            GetPlacesFromHalls(_seans);
            incom(user);
            GetNumberOfUsers(user);
            PaintButtons();
        }

        public void incom(string user)
        {
            button1 = new Button[Convert.ToInt64(hallTable.Rows[0][0])];

            for (int i = 0; i < Convert.ToInt64(hallTable.Rows[0][0]); i++)
            {
                button1[i] = new Button();
                this.button1[i].Location = new System.Drawing.Point(50 + (i % 15) * 40, 50 + (i / 15) * 40);
                this.button1[i].Name = "button1";
                this.button1[i].Text = $"{i + 1}";
                this.button1[i].Size = new System.Drawing.Size(35, 35);
                this.button1[i].TabIndex = 0;
                this.button1[i].UseVisualStyleBackColor = true;
                this.button1[i].ForeColor = Color.White;
                this.button1[i].FlatStyle = FlatStyle.Flat;
                this.button1[i].FlatAppearance.BorderSize = 0;
                this.Controls.Add(this.button1[i]);
                this.button1[i].Click += new System.EventHandler(this.button1_Click);
            }
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(1000, 500);
        }
        private void PaintButtons()
        {
            for (int i = 0; i < Convert.ToInt64(hallTable.Rows[0][0]); i++)
            {
                button1[i].BackColor = Color.Purple;

                for (int j = 0; j < seansTable.Rows.Count; j++)
                {
                    if (this.button1[i].Text == userTickets.Rows[j][0].ToString())
                    {
                        button1[i].BackColor = Color.Yellow;
                        button1[i].ForeColor = Color.Black;
                    }
                }
                for (int j = 0; j < seansTable.Rows.Count; j++)
                {
                    if (button1[i].Text == seansTable.Rows[j][0].ToString())
                    {
                        button1[i].BackColor = Color.Red;
                        button1[i].Enabled = false;
                        button1[i].ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            for (int i = 0; i < seansTable.Rows.Count; i++)
            {
                if (bt.Text == seansTable.Rows[i][0].ToString())
                {
                    return;
                }
            }
            if (bt.BackColor == Color.Yellow)
            {
                DialogResult dialogWhithYellowButtons = MessageBox.Show("Вы хотите снять бронь??", "Снять бронь?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogWhithYellowButtons == DialogResult.Yes)
                {
                    seance_places.ActiveForm.Hide();
                    BuyTickets buyTickets = new BuyTickets();
                    buyTickets.Show();
                }
            }
            if (bt.BackColor == Color.Purple)
            {
                DialogResult dialogWhithYellowButtons = MessageBox.Show("Забранировать место?", "Забронировать место?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogWhithYellowButtons == DialogResult.Yes)
                {
                    string _sql = $"select * from Билеты, Пользователи where (Билеты.Место = '{bt.Text}')" +
                        $"and (Билеты.Код_пользователя = Пользователи.Код_пользователя) and (Пользователи.user_login = '{main.deletelogin}')";
                    using (SqlCommand cmd = new SqlCommand(_sql, DBCon.connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(mesto);
                    }
                    MessageBox.Show(main.deletelogin);
                    string _sql1 = $"Select Код_пользователя from Пользователи where user_login = '{main.deletelogin}'";
                    SqlCommand com2 = new SqlCommand(_sql1);
                    com2.Connection = con1.GetCon();
                    SqlDataAdapter da2 = new SqlDataAdapter(com2);
                    DataTable table1 = new DataTable();
                    da2.Fill(table1);
                    int pizda = Convert.ToInt32(table1.Rows[0][0]);
                    if (mesto.Rows.Count == 0)
                    {
                        con1.OpenCon();
                        bt.BackColor = Color.Yellow;
                        string query = $"insert Билеты (Код_сеанса, Место, Код_пользователя, Дата_покупки) values ({_seans}, {bt.Text}, {Convert.ToInt32(table1.Rows[0][0])}, '{DateTime.Today}')";
                        SqlCommand com1 = new SqlCommand(query);
                        com1.Connection = con1.GetCon();
                        com1.ExecuteNonQuery();
                    }
                    //seance_places.ActiveForm.Hide();
                    //BuyTickets buyTickets = new BuyTickets();
                    //buyTickets.Show();
                }
            }
        }

        public void GetTickets(int _seans)
        {
            string _sql = $"SELECT Место FROM Билеты where Код_сеанса = {_seans}";
            using (SqlCommand cmd = new SqlCommand(_sql, DBCon.connection))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(seansTable);
            }
        }

        public void GetPlacesFromHalls(int _seans)
        {
            string _sql = $"select Кинозалы.Вместимость from Кинозалы JOIN Сеансы ON Сеансы.Код_кинозала " +
                $"= Кинозалы.Код_кинозала where Кинозалы.Код_кинозала = {_seans}";
            using (SqlCommand cmd = new SqlCommand(_sql, DBCon.connection))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(hallTable);
            }
        }

        public void GetNumberOfUsers(string user)
        {
            string _sql = $"select Место from Билеты " +
                $"join Пользователи on Билеты.Код_Пользователя = Пользователи.Код_Пользователя " +
                $"where Пользователи.user_login = '{user}'";
            using (SqlCommand cmd = new SqlCommand(_sql, DBCon.connection))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(userTickets);
            }
        }

    }
}

