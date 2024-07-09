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
    public partial class Form_Authorize : Form
    {
        public Form_Authorize()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        public static string authorize;
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56118;Password=a2efdeadz2;database=gb_56118;";

        private void button_byguest_Click(object sender, EventArgs e)
        {
            authorize = "guest";
            Hide();
            FormMain formmain1 = new FormMain();
            DialogResult dr = formmain1.ShowDialog();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Register formregister1 = new Form_Register();
            DialogResult dr = formregister1.ShowDialog();
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_login.Text != "" && maskedTextBox_password.Text != "")
            {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();
                string Query = "SELECT * FROM users WHERE LOGIN = '" + maskedTextBox_login.Text.Trim() + "' and PASSWORD = '" + maskedTextBox_password.Text.Trim() + "'";
                MySqlDataAdapter SDA = new MySqlDataAdapter(Query, conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                
                if (DT.Rows.Count >= 1)
                {
                    if(Convert.ToInt32(DT.Rows[0].ItemArray[5]) == 1)
                    {
                        authorize = "admin";
                        Hide();
                        FormMain formmain1 = new FormMain();
                        DialogResult dr = formmain1.ShowDialog();
                    }
                    else if (Convert.ToInt32(DT.Rows[0].ItemArray[5]) == 0)
                    {
                        authorize = "user";
                        Hide();
                        FormMain formmain1 = new FormMain();
                        DialogResult dr = formmain1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
    }
}
