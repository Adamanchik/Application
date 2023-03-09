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

namespace бабры_
{
    public partial class Login : Form
    {
        string connectionString = @" Data Source=DESKTOP-CL5JFKU\VIKTOR;Initial Catalog=Trade2;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection (connectionString);
            try
            {
                conn.Open();


                SqlCommand command = conn.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "login_procedure";
                command.Parameters.AddWithValue("@userlogin", log_textbox.Text);
                command.Parameters.AddWithValue("@userpassword", pass_textbox.Text);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                if (reader.HasRows)
                {
                    MessageBox.Show("Вход был произведен успешно");
                    Data_viewer fm = new Data_viewer();
                    fm.Show();

                }
                else
                {
                    MessageBox.Show("Неверные логин или пароль");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");

            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
