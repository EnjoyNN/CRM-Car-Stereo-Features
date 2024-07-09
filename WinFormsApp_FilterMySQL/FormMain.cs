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
    public partial class FormMain : Form
    {
        MySqlConnection conn;
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56118;Password=a2efdeadz2;database=gb_56118;";
        List<String> DataBaseList = new List<String>();

        public FormMain()
        {
            InitializeComponent();
        }
        string authorize;

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AboutProgram formabout1 = new Form_AboutProgram();
            DialogResult dr = formabout1.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //узнаем кто зашел - админ, пользователь или гость в форму
            if (Form_Authorize.authorize != "")
            {
                authorize = Form_Authorize.authorize;
            }
            else if (Form_Register.authorize != "")
            {
                authorize = Form_Register.authorize;
            }
            else
            {
                authorize = "guest";
            }

            if (authorize == "guest")
            {
                tabControl1.Visible = false;
            }
            else if (authorize == "user")
            {
                tabControl1.Visible = false;
            }
            else if (authorize == "admin")
            {
                tabControl1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте перезапустить программу и войти в аккаунт.");
                Application.Exit();
            }
        }



        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();

                string SearchQuery = "SELECT * FROM car_stereos WHERE ";

                if (!string.IsNullOrEmpty(maskedTextBox_Search.Text) && !string.IsNullOrWhiteSpace(maskedTextBox_Search.Text) &&
                    !string.IsNullOrEmpty(comboBox_PO.Text) && !string.IsNullOrWhiteSpace(comboBox_PO.Text))
                {
                    if (comboBox_PO.Text == "ID")
                        SearchQuery += "ID = '" + maskedTextBox_Search.Text.Trim() + "' and ";
                    else if (comboBox_PO.Text == "Название")
                        SearchQuery += "NAME = '" + maskedTextBox_Search.Text.Trim() + "' and ";
                    else if (comboBox_PO.Text == "Цена")
                        SearchQuery += "PRICE = '" + maskedTextBox_Search.Text.Trim().Replace(".",",") + "' and ";
                    else if (comboBox_PO.Text == "Поддерживаемые форматы")
                        SearchQuery += "SOFTWARE = '" + maskedTextBox_Search.Text.Trim() + "' and ";
                    else if (comboBox_PO.Text == "Производитель")
                        SearchQuery += "MANUFACTURER = '" + maskedTextBox_Search.Text.Trim() + "' and ";
                }

                if (checkBox_bluetooth.Checked)
                    SearchQuery += "SUPPORT_BLUETOOTH = '" + 1.ToString() + "' and ";

                if (checkBox_Garant.Checked)
                    SearchQuery += "SUPPORT_GUARANTEE = '" + 1.ToString() + "' and ";

                if (checkBox_Vhod.Checked)
                    SearchQuery += "SUPPORT_INPUT = '" + 1.ToString() + "' and ";
                SearchQuery = SearchQuery.Remove(SearchQuery.Length - 5, 5);

                while (DG_Table.Rows.Count != 0) //очищаем таблицу
                    DG_Table.Rows.Remove(DG_Table.Rows[DG_Table.Rows.Count - 1]);
                DG_Table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

                DataBaseList.Clear();
                int k = 0;

                MySqlDataReader sqlReader = null;

                MySqlCommand cmd = new MySqlCommand(SearchQuery, conn);

                try
                {
                    sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        DataBaseList.Add(Convert.ToString(sqlReader["ID"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["NAME"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["ID_BUYER"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["IMAGE"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["PRICE"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["SOFTWARE"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["MANUFACTURER"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["SUPPORT_BLUETOOTH"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["SUPPORT_GUARANTEE"]));
                        DataBaseList.Add(Convert.ToString(sqlReader["SUPPORT_INPUT"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }

                for (int i = 0; i < DataBaseList.Count; i = i + 10)
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    Row.Height = 26;
                    DG_Table.Rows.Add(Row);

                    DG_Table.Rows[k].Cells[0].Value = DataBaseList[i];
                    DG_Table.Rows[k].Cells[1].Value = DataBaseList[i + 1];
                    DG_Table.Rows[k].Cells[2].Value = DataBaseList[i + 4];
                    DG_Table.Rows[k].Cells[3].Value = DataBaseList[i + 5];
                    DG_Table.Rows[k].Cells[4].Value = DataBaseList[i + 6];
                    if (DataBaseList[i + 7] == "1")
                        DG_Table.Rows[k].Cells[5].Value = "Есть";
                    else
                        DG_Table.Rows[k].Cells[5].Value = "Нет";
                    if (DataBaseList[i + 8] == "1")
                        DG_Table.Rows[k].Cells[6].Value = "Есть";
                    else
                        DG_Table.Rows[k].Cells[6].Value = "Нет";
                    if (DataBaseList[i + 9] == "1")
                        DG_Table.Rows[k].Cells[7].Value = "Есть";
                    else
                        DG_Table.Rows[k].Cells[7].Value = "Нет";
                    k++;
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Возможно вы неправильно ввели нужные данные поиска");
            }
            conn.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM car_stereos WHERE ID=" + numericUpDown_Delete.Value, conn);
                MySqlDataReader sqlReader = null;
                string namefile = "";
                try
                {
                    sqlReader = cmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        namefile = Convert.ToString(sqlReader["NAME"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }

                if (namefile == "")
                {
                    MessageBox.Show("Автомагнитолы с таким ID не существует");
                    return;
                }

                cmd = new MySqlCommand("DELETE FROM car_stereos WHERE ID=@ID", conn);
                cmd.Parameters.AddWithValue("ID", numericUpDown_Delete.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Автомагнитола с ID " + numericUpDown_Delete.Value.ToString() + " успешно удалена из базы.");
            conn.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_Updatetext.Text != "" && comboBox_Updateparam.Text != "")
            {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM car_stereos WHERE ID=" + numericUpDown_IDUpdate.Value, conn);
                MySqlDataReader sqlReader = null;
                string namefile = "";
                try
                {
                    sqlReader = cmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        namefile = Convert.ToString(sqlReader["NAME"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
                if (namefile == "")
                {
                    MessageBox.Show("Автомагнитолы с таким ID не существует");
                    return;
                }
                if (comboBox_Updateparam.Text == "Поддержка Bluetooth")
                {
                    if (maskedTextBox_Updatetext.Text == "Есть")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_BLUETOOTH=@SUPPORT_BLUETOOTH WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(),conn);
                        cmd.Parameters.AddWithValue("SUPPORT_BLUETOOTH", 1);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Поддержка Bluetooth автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменена.");
                    }
                    else if (maskedTextBox_Updatetext.Text == "Нет")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_BLUETOOTH=@SUPPORT_BLUETOOTH WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("SUPPORT_BLUETOOTH", 0);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Поддержка Bluetooth автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменена.");
                    }
                    else
                        MessageBox.Show("Неправильно введено значение. (Есть/Нет)");
                }
                else if (comboBox_Updateparam.Text == "Гарантия")
                {
                    if (maskedTextBox_Updatetext.Text == "Есть")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_GUARANTEE=@SUPPORT_GUARANTEE WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("SUPPORT_GUARANTEE", 1);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Гарантия автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменена.");
                    }
                    else if (maskedTextBox_Updatetext.Text == "Нет")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_GUARANTEE=@SUPPORT_GUARANTEE WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("SUPPORT_GUARANTEE", 0);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Гарантия автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменена.");
                    }
                    else
                        MessageBox.Show("Неправильно введено значение. (Есть/Нет)");
                }
                else if (comboBox_Updateparam.Text == "Вход аудио на передней панели")
                {
                    if (maskedTextBox_Updatetext.Text == "Есть")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_INPUT=@SUPPORT_INPUT WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("SUPPORT_INPUT", 1);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вход аудио на передней панели автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменен.");
                    }
                    else if (maskedTextBox_Updatetext.Text == "Нет")
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET SUPPORT_INPUT=@SUPPORT_INPUT WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("SUPPORT_INPUT", 0);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вход аудио на передней панели автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменен.");
                    }
                    else
                        MessageBox.Show("Неправильно введено значение. (Есть/Нет)");
                }
                else if (comboBox_Updateparam.Text == "Название")
                {
                        cmd = new MySqlCommand("UPDATE car_stereos SET NAME=@NAME WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("NAME", maskedTextBox_Updatetext.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Название автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменено.");
                }
                else if (comboBox_Updateparam.Text == "Поддерживаемые форматы")
                {
                    cmd = new MySqlCommand("UPDATE car_stereos SET SOFTWARE=@SOFTWARE WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                    cmd.Parameters.AddWithValue("SOFTWARE", maskedTextBox_Updatetext.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Поддерживаемые форматы автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменены.");
                }
                else if (comboBox_Updateparam.Text == "Производитель")
                {
                    cmd = new MySqlCommand("UPDATE car_stereos SET MANUFACTURER=@MANUFACTURER WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                    cmd.Parameters.AddWithValue("MANUFACTURER", maskedTextBox_Updatetext.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Производитель автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменен.");
                }
                else if (comboBox_Updateparam.Text == "Цена")
                {
                    try
                    {
                        cmd = new MySqlCommand("UPDATE car_stereos SET PRICE=@PRICE WHERE ID=" + numericUpDown_IDUpdate.Value.ToString(), conn);
                        cmd.Parameters.AddWithValue("PRICE", Convert.ToDecimal(maskedTextBox_Updatetext.Text.Replace('.', ',')));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Цена автомагнитолы с ID " + numericUpDown_IDUpdate.Value.ToString() + " успешно изменена.");
                    }
                    catch
                    {
                        MessageBox.Show("Вы не верно ввели цену. Пример: 4500.00");
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля");
            }
            conn.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_Insertformats.Text != "" && maskedTextBox_Insertmanufacturer.Text != "" && maskedTextBox_InsertName.Text != "" && maskedTextBox_InsertPrice.Text != "")
            {
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();

                string Query = "SELECT * FROM car_stereos";
                MySqlDataAdapter SDA = new MySqlDataAdapter(Query, conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                int new_id = 0;

                if (DT.Rows.Count >= 1)
                {
                    new_id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1].ItemArray[0]) + 1;
                }
                try
                {
                    conn = new MySqlConnection(webAppConnection_string);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO car_stereos (ID,NAME,ID_BUYER,IMAGE,PRICE,SOFTWARE,MANUFACTURER,SUPPORT_BLUETOOTH,SUPPORT_GUARANTEE,SUPPORT_INPUT)VALUES(@ID, @NAME, @ID_BUYER, @IMAGE, @PRICE, @SOFTWARE, @MANUFACTURER, @SUPPORT_BLUETOOTH, @SUPPORT_GUARANTEE, @SUPPORT_INPUT)", conn);

                    cmd.Parameters.AddWithValue("ID", new_id);
                    cmd.Parameters.AddWithValue("NAME", maskedTextBox_InsertName.Text);
                    cmd.Parameters.AddWithValue("ID_BUYER", null);
                    cmd.Parameters.AddWithValue("IMAGE", null);
                    cmd.Parameters.AddWithValue("PRICE", Convert.ToDecimal(maskedTextBox_InsertPrice.Text.Replace('.', ',')));
                    cmd.Parameters.AddWithValue("SOFTWARE", maskedTextBox_Insertformats.Text);
                    cmd.Parameters.AddWithValue("MANUFACTURER", maskedTextBox_Insertmanufacturer.Text);
                    if (checkBox_insertbluetooth.Checked)
                        cmd.Parameters.AddWithValue("SUPPORT_BLUETOOTH", 1);
                    else
                        cmd.Parameters.AddWithValue("SUPPORT_BLUETOOTH", 0);
                    if (checkBox_insertguarantee.Checked)
                        cmd.Parameters.AddWithValue("SUPPORT_GUARANTEE", 1);
                    else
                        cmd.Parameters.AddWithValue("SUPPORT_GUARANTEE", 0);
                    if (checkBox_insertinput.Checked)
                        cmd.Parameters.AddWithValue("SUPPORT_INPUT", 1);
                    else
                        cmd.Parameters.AddWithValue("SUPPORT_INPUT", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Автомагнитола успешно добавлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
            conn.Close();
        }
    }
}
