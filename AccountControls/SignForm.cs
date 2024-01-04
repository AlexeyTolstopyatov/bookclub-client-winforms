using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace client
{
    //         (С) Толстопятов Алексей А. 2023
    //  Логика окна входа в систему ООО "Книжный клуб"
    // В этом файле описан слой взаимодействия с базой данных.
    //          ConnectButton()     : соединяет с базой данных и проверяет введенные данные
    //          
    //          fname               : хранит (Фамилия Имя О.) для передачи в основное окно, по
    //                                завершению проверки данных.
    // 
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }
        static string fname; // ПЛОХО.
        private void ConnectButton_Click(object sender , EventArgs e)
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT COUNT([ID]) FROM [Accounts] WHERE [Name] = @name AND [Password] = @pass", cn);
            
            try 
            {
                cn.Open();
                cm.Parameters.AddWithValue("@name" , UserBox.Text);
                cm.Parameters.AddWithValue("@pass" , PasswordBox.Text);

                int result = ( int )cm.ExecuteScalar();
                if (result == 0)
                {
                    throw new Exception("Пользователь не найден");
                }
                else if (result > 1)
                {
                    throw new Exception("В системе зарегистрировано несколько пользователей с одинаковыми данными. Похоже это недостаток Администраторов приложения. Обратитесь по телефону: +7(пошел нахуй)-блять-ок?");
                }
                cm.Parameters.Clear();

                cm.CommandText = "SELECT [SName], [TID] FROM [Accounts] WHERE [Name] = @name AND [Password] = @pass";
                cm.Parameters.AddWithValue("@name" , UserBox.Text);
                cm.Parameters.AddWithValue("@pass" , PasswordBox.Text);

                var reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    fname = reader.GetString(0);
                    result = reader.GetInt32(1);                
                }
                
                if (fname != null) 
                {
                    cn.Close();
                    cm.Dispose();

                    switch (result)
                    {
                        case 1:
                            Hide();
                            var x = new AdminForm();
                                x.Show();
                        break;

                        default:
                        var form_ref = new ShopForm();
                            form_ref.User = fname;
                            form_ref.Show();
                        break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fname = ex.Message;
            }
            
        }
    }
}
