using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace client
{
    public partial class AdminForm : Form
    {
        //      (С) Толстопятов Алексей А. 2023
        // Логика окна Администратора системы ООО "Книжный клуб"
        // В этом файле описан слой взаимодействия с базой данных. 
        //                      *** AdminServices.cs ***
        //      GetTables()            : Получает таблицы хранимые в базе данных
        //      GetCategories()        : Получает все доступные категории книг из базы данных.
        //      GetBooks()             : Получает список всех доступных книг в Базе данных
        //      GetAccounts()          : Получает список всех пользователей в Базе данных      
        //             
        //                      *** AdminMenuEvents.cs ***
        //      ExitOption()           : Выходит из системы (указать причину)
        //      ForceExitOption()      : Незапланировано выходит из системы
        //      DelUserConfigOption()  : Удаляет файл .../userconfig.t
        //      SetupUserConfigOption(): Перезаписывает .../userconfig.t
        //      RewriteOption()        : Отправляет запрос перезаписи таблицы 
        //
        //                      *** AdminForm.cs ***
        //      AdminForm_Load()       : содержит службы для реализации компонентов формы
        //      AcceptBookButton()     : принимает данные и отправляет в виде запроса "добавить книгу"
        //      AcceptAccountButton()  : принимает данные и отправляет в виде запроса "добавить пользователя"
        //      BrowseIconButton()     : вызывает экземпляр диалог-окна InputForm(string). Сохраняет результат.
        //      BrowseUserIconButton() : вызывает экземпляр диалог-окна {...} Для передачи относительного пути до аватара
        //      DelUserButton()        : Удаляет выбранного в AccountBox пользователя из Базы данных
        //      DelBookButton()        : Удаляет выбранную книгу в BookBox из базы данных
        //
        // * Все "службы", которые указаны в AdminForm_Load(object, EventArgs) хранятся во второй 
        // части класса AdminForm -- AdminServices.cs
        // * Все элементы основного меню (obj: ToolMenuStrip) реализованы в AdminMenuEvents.cs
        // 
        // [!]: Для свойств в DataModels -- Icon необходимо указывать относительный путь. (относительно client.exe)
        //

        private string _bookIcon;
        private string _userIcon;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender , EventArgs e)
        {
            // см. Services.cs
            GetTables();
            GetBooks();
            GetCategiroes();
            GetAccounts();
            GetTypes();
        }
        
        private void AcceptBookButton_Click(object sender , EventArgs e)
        {
            var book = new Book(
               BookName.Text, 
               BookYear.Text,
               BookAuthor.Text, 
               BookDescription.Text, 
               BookPublisher.Text, 
               (BookCategory.SelectedIndex + 1).ToString(), 
               BookCost.Text
            );

            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT COUNT(ID) FROM [Books]", cn);

            try
            {
                cn.Open();
                int book_id = 1 + ( int )cm.ExecuteScalar(); // следующий ID

                cm.CommandText = 
                    @"INSERT [Books] (ID, Year, Pub, Author, Cost, Icon, CID, Context, Title) 
                      VALUES (@id, @year, @pub, @auth, @cost, @ico, @cid, @text, @name)";
                cm.Parameters.AddWithValue("@id" , book_id);
                cm.Parameters.AddWithValue("@year", book.Year);
                cm.Parameters.AddWithValue("@pub" , book.Publisher);
                cm.Parameters.AddWithValue("@auth" , book.Author);
                cm.Parameters.AddWithValue("@cost" , book.Cost);
                cm.Parameters.AddWithValue("@ico" , _bookIcon);
                cm.Parameters.AddWithValue("@cid" , book.Category);
                cm.Parameters.AddWithValue("@text" , book.Description);
                cm.Parameters.AddWithValue("@name" , book.Title);

                cm.ExecuteNonQuery();
                
                cm.Parameters.Clear();
                cm.CommandText = "SELECT [ID] FROM [Books] WHERE [ID] = @id"; 
                cm.Parameters.AddWithValue("@id", book_id);

                if (cm.ExecuteScalar() == null)
                    throw new Exception("Нельзя добавить книгу.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                cn.Close();
                cm.Dispose();
            }
        }
        private void BrowseIconButton_Click(object sender , EventArgs e)
        {
            var imsg = new InputForm("Укажите адрес обложки книги.");
            imsg.ShowDialog();

            if (imsg.DialogResult == DialogResult.OK)
                _bookIcon = imsg.DialogText;

            if (_bookIcon != null)
                AcceptBookButton.Enabled = true;
            
            imsg.Dispose();
        }
        private void AcceptUserButton_Click(object sender , EventArgs e)
        {
            var user = new Account(
                NameBox.Text, 
                FNameBox.Text, 
                SNameBox.Text, 
                PasswordBox.Text, 
                (TypeBox.SelectedIndex + 1).ToString(), 
                BirthDateBox.Text, 
                _userIcon
            );

            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT COUNT(ID) FROM [Accounts]", cn);

            try
            {
                cn.Open();

                // get next-free ident
                int user_id = 1 + ( int )cm.ExecuteScalar();
                
                // fill next-free row
                cm.CommandText = "INSERT [Accounts] (ID, Name, SName, FName, BirthDate, Icon, TID, Password) VALUES (@id, @name, @sname, @fname, @bdate, @ico, @tid, @pass)";


                cm.Parameters.AddWithValue("@id" , user_id);
                cm.Parameters.AddWithValue("@name" , user.Name);
                cm.Parameters.AddWithValue("@sname" , user.SName);
                cm.Parameters.AddWithValue("@fname" , user.FName);
                cm.Parameters.AddWithValue("@bdate" , user.BirthDate);
                cm.Parameters.AddWithValue("@ico" , _userIcon);
                cm.Parameters.AddWithValue("@pass" , user.Password);
                cm.Parameters.AddWithValue("@tid" , user.Type);

                cm.ExecuteNonQuery();

                cm.Parameters.Clear();
                cm.CommandText = "SELECT [ID] FROM [Accounts] WHERE ID = @id";
                cm.Parameters.AddWithValue("@id" , user_id);

                if (( int )cm.ExecuteScalar() == user_id)
                    MessageBox.Show("Готово.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Dispose();
                cn.Close();
                user = null;
            }
        }
        private void BrowseUserIconButton_Click(object sender , EventArgs e)
        {
            var imsg = new InputForm("Выберите аватар пользователя.");
            imsg.ShowDialog();

            if (imsg.DialogResult == DialogResult.OK)
                _userIcon = imsg.DialogText;

            if (_userIcon != null)
                AcceptUserButton.Enabled = true;
            
        }
        private void DelBookButton_Click(object sender , EventArgs e)
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("DELETE FROM [Books] WHERE ID = @id", cn);

            int i = AvaliableBooks.SelectedIndex + 1;
            try
            {
                cn.Open();
                cm.Parameters.AddWithValue("@id" , i);
                cm.ExecuteNonQuery();

                cm.Parameters.Clear();

                cm.CommandText = "SELECT COUNT(*) FROM [Books]";
                if (( int )cm.ExecuteScalar() == i)
                    throw new Exception("не удалось удалить");
                else
                    MessageBox.Show("Удалено");
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
        private void DelUserButton_Click(object sender , EventArgs e)
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("DELETE FROM [Accounts] WHERE ID = @id", cn);

            int i = AvaliableAccounts.SelectedIndex + 1;
            try
            {
                cn.Open();
                cm.Parameters.AddWithValue("@id" , i);
                cm.ExecuteNonQuery();

                cm.Parameters.Clear();

                cm.CommandText = "SELECT COUNT(*) FROM [Accounts]";
                if (( int )cm.ExecuteScalar() == i)
                    throw new Exception("не удалось удалить");
                else
                    MessageBox.Show("Удалено");
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
    }
}
