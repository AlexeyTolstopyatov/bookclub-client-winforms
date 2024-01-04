using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{

    //         (С) Толстопятов Алексей А. 2023
    // Логика окна регистрации в системе ООО "Книжный клуб"
    // В этом файле описан слой взаимодействия с базой данных
    //      CreateButton()      : записывает данные нового пользователя в БД 
    //      ChangePhotoButton() : сохраняет путь до аватара пользователя в _userImage
    //      DelPhotoButton()    : стирает _userImage
    //
    //      _userImage          : хранит нормализованный путь до файла аватара пользователя 
    //

    public partial class RegForm : Form
    {
        private string _userImage;
        public RegForm()
        {
            InitializeComponent();
        }

        
        private void CreateButton_Click(object sender , EventArgs e)
        {
            
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand();

            cm.Connection = cn;

            try
            {
                cn.Open();
                // 1) Если данные нового пользователя совпадают с данными пользователей в базе данных
                cm.CommandText = "SELECT COUNT(*) FROM [Accounts] WHERE Name = @name";
                cm.Parameters.AddWithValue("@name", UserBox.Text);

                if (( int )cm.ExecuteScalar() > 0)
                    throw new Exception("Пользователь с таким именем уже существует");

                // 2) Если совпадений нет, найти id следующего пользователя
                cm.Parameters.Clear();
                cm.CommandText = "SELECT COUNT(ID) FROM [Accounts]";

                int result = 1 + ( int )cm.ExecuteScalar();

                // 3) Собрать данные пользователя
                cm.Parameters.Clear();
                var user = new Account(UserBox.Text, FNameBox.Text, SNameBox.Text, PasswordBox.Text, "3", BirthDayBox.Text, _userImage);

                cm.CommandText = @"INSERT [Accouns] (ID, Name, SName, FName, BirthDate, Icon, TID, Password)
                                   VALUES (@id, @name, @sname, @fname, @bd, @ico, @tid, @pass)";

                cm.Parameters.AddWithValue("@id", result);
                cm.Parameters.AddWithValue("@name", user.Name);
                cm.Parameters.AddWithValue("@sname", user.SName);
                cm.Parameters.AddWithValue("@fname", user.FName);
                cm.Parameters.AddWithValue("@bd", user.BirthDate);
                cm.Parameters.AddWithValue("@ico", user.Url);
                cm.Parameters.AddWithValue("@tid", user.Type);
                cm.Parameters.AddWithValue("@pass", user.Password);

                cm.ExecuteNonQuery();

                // 4) Проверить наличие нового пользователя в БД
                cm.Parameters.Clear();
                cm.CommandText = "SELECT [ID] FROM [Accounts] WHERE ID = @id";
                cm.Parameters.AddWithValue("@id", result);

                if (( int )cm.ExecuteScalar() == result)
                    MessageBox.Show("Готово.");
                else
                    throw new Exception("Не удалось добавить.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void ChangePhotoButton_Click(object sender , EventArgs e)
        {

            if (OpenPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                _userImage = OpenPhotoDialog.FileName;
            }

        }
        private void DelPhotoButton_Click(object sender , EventArgs e)
        {
            _userImage = "";
        }
    }
}
