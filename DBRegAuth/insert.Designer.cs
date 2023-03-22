
namespace DBRegAuth
{
    partial class insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1_birthday = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_fathername = new System.Windows.Forms.TextBox();
            this.textBox5_password = new System.Windows.Forms.TextBox();
            this.textBox4_login = new System.Windows.Forms.TextBox();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.textBox1_surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "dd/mm/yyyy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Дата рождения";
            // 
            // maskedTextBox1_birthday
            // 
            this.maskedTextBox1_birthday.Location = new System.Drawing.Point(422, 235);
            this.maskedTextBox1_birthday.Mask = "00-00-0000";
            this.maskedTextBox1_birthday.Name = "maskedTextBox1_birthday";
            this.maskedTextBox1_birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1_birthday.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBox1_birthday.TabIndex = 30;
            this.maskedTextBox1_birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1_birthday.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Фамилия";
            // 
            // textBox3_fathername
            // 
            this.textBox3_fathername.Location = new System.Drawing.Point(239, 235);
            this.textBox3_fathername.Name = "textBox3_fathername";
            this.textBox3_fathername.Size = new System.Drawing.Size(100, 20);
            this.textBox3_fathername.TabIndex = 21;
            // 
            // textBox5_password
            // 
            this.textBox5_password.Location = new System.Drawing.Point(422, 168);
            this.textBox5_password.Name = "textBox5_password";
            this.textBox5_password.Size = new System.Drawing.Size(100, 20);
            this.textBox5_password.TabIndex = 20;
            // 
            // textBox4_login
            // 
            this.textBox4_login.Location = new System.Drawing.Point(422, 98);
            this.textBox4_login.Name = "textBox4_login";
            this.textBox4_login.Size = new System.Drawing.Size(100, 20);
            this.textBox4_login.TabIndex = 19;
            // 
            // textBox2_name
            // 
            this.textBox2_name.Location = new System.Drawing.Point(239, 168);
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(100, 20);
            this.textBox2_name.TabIndex = 18;
            // 
            // textBox1_surname
            // 
            this.textBox1_surname.Location = new System.Drawing.Point(239, 98);
            this.textBox1_surname.Name = "textBox1_surname";
            this.textBox1_surname.Size = new System.Drawing.Size(100, 20);
            this.textBox1_surname.TabIndex = 17;
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBox1_birthday);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3_fathername);
            this.Controls.Add(this.textBox5_password);
            this.Controls.Add(this.textBox4_login);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.textBox1_surname);
            this.Name = "insert";
            this.Text = "insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_birthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_fathername;
        private System.Windows.Forms.TextBox textBox5_password;
        private System.Windows.Forms.TextBox textBox4_login;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.TextBox textBox1_surname;
    }
}