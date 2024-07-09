using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp_FilterMySQL
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        public static string authorize;
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56118;Password=a2efdeadz2;database=gb_56118;";
        MySqlCommand cmd;

        private async void button_register_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_login.Text != "" && maskedTextBox_password.Text != "" && maskedTextBox_city.Text != "" && maskedTextBox_name.Text != "")
            {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();
                string Query = "SELECT * FROM users WHERE LOGIN = '" + maskedTextBox_login.Text.Trim() + "'";
                MySqlDataAdapter SDA = new MySqlDataAdapter(Query, conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);

                if (DT.Rows.Count >= 1)
                {
                    MessageBox.Show("Такой логин уже существует");

                }
                else
                {
                    Query = "SELECT * FROM users";
                    SDA = new MySqlDataAdapter(Query, conn);
                    DT = new DataTable();
                    SDA.Fill(DT);
                    int new_id = 0;

                        //проверяем на то, есть ли вообще пользователи в таблице
                    if (DT.Rows.Count >=1)
                    {
                        new_id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1].ItemArray[0]) + 1;
                    }

                    try
                    {
                        Query = "INSERT INTO users (ID,LOGIN,PASSWORD,NAME,CITY,PRIVILEGE)VALUES(@ID, @LOGIN, @PASSWORD, @NAME, @CITY, @PRIVILEGE)";
                    cmd = new MySqlCommand(Query, conn);

                    cmd.Parameters.AddWithValue("ID", new_id.ToString());
                    cmd.Parameters.AddWithValue("LOGIN", maskedTextBox_login.Text);
                    cmd.Parameters.AddWithValue("PASSWORD", maskedTextBox_password.Text);
                    cmd.Parameters.AddWithValue("NAME", maskedTextBox_name.Text);
                    cmd.Parameters.AddWithValue("CITY", maskedTextBox_city.Text);
                    cmd.Parameters.AddWithValue("PRIVILEGE", 0.ToString());

                        await cmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Регистрация прошла успешно! Сохраните ваш логин и пароль: \r\n" + "Логин: " + maskedTextBox_login.Text + "\r\n" + "Пароль: " + maskedTextBox_password.Text);
                        authorize = "user";
                        Hide();
                        FormMain formmain1 = new FormMain();
                        DialogResult dr = formmain1.ShowDialog();
                    }
                    catch (Exception exp)
                    {
                        string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                        MessageBox.Show(err_string, "Ошибка записи", MessageBoxButtons.OKCancel);
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Authorize formauthorize = new Form_Authorize();
            DialogResult dr = formauthorize.ShowDialog();
        }
    }
}
