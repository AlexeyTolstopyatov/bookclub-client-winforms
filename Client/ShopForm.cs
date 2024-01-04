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
using System.Threading;
using System.Linq.Expressions;
using System.IO;

namespace client
{
    //      (С) Толстопятов Алексей А. 2023
    // Логика окна магазина
    // * При загрузке окна (ShopForm_Load) необходимо соединение с базой данных
    // При успешном соединении будет создан гостевой сеанс
    // В противном случае приложение будет закрыто.
    //      Создание гостевого сеанса подразумевает создание записи в Базе данных.
    //                  *** ShopForm.cs ***
    //          User -> string    : возвращает пользователя, вошедшего в систему.
    //          Guest -> int      : возвращает номер незарегистрированного пользователя
    //                              (если NULL -- пользователя в системе нет)
    //          CartButton()      : создает экземпляр окна-корзины
    //          GetInfoButton()   : создает экземпляр окна-описания товара. (так же как и ItemSelected_DoubleClick())
    //          BuyButton()       : добавляет выбранную книгу в коллекцию
    //          LoginButton()     : вызывает окно входа в систему. Удаляет гостевой сеанс. 
    //                              При выходе из окна, клиент будет закрыт.          
    //                  *** ClientServices.cs ***
    //          GetBooks()        : возвращает коллекцию книг для отображения в ListView
    //          SaveData()        : обновляет данные
    //          CreateGuest()     : устанавливает гостевой сеанс
    //          DestroyGuest()    : уничтожает гостевой сеанс
    //          

    public partial class ShopForm : Form
    {
        private string _connection;
        private string _user;
        private int _guest;
        private Random _rand = new Random();
        public List<string> _books;

        public ShopForm()
        {
            InitializeComponent();

            _connection = $"SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;Integrated Security=true";
            _guest = _rand.Next();
            _books = new List<string>();
        }

        /// <summary>
        /// Возвращает и устанавливает пользователя в системе. ВАЖНО: Имя пользователя это параметры SName + FName
        /// </summary>
        public string User
        {
            get => _user;
            set => _user = value;
        }
        public int Guest 
        {
            get => _guest;
            private set => _guest = value;
        }
       
        private void ShopForm_Load(object sender , EventArgs e)
        {
            if (User == null)
            {
                CreateGuest(_guest);
                UserBox.Text = "Добро пожаловать!";
            }
            else
            {
                UserBox.Text = User;
            }

            GetBooks();
            SaveData();
        }
        private void ShopForm_FormClosing(object sender , FormClosingEventArgs e)
        {
            if (User == null)
                DestroyGuest(_guest);

            Application.Exit(); 
        }
        private void SelectedItem_DoubleClick(object sender , EventArgs e) => 
            new DescriptionForm(BookView.SelectedIndices[0] + 1).Show();
        private void CartButton_Click(object sender , EventArgs e) => 
            new CartForm(_books).Show();
        private void GetInfo_Click(object sender , EventArgs e) =>
            new DescriptionForm(BookView.SelectedIndices[0] + 1).Show();
        private void BuyButton_Click(object sender , EventArgs e) =>
            _books.Add($"{BookView.SelectedItems[0].Text}"); // x((((        
        private void LoginButton_Click(object sender , EventArgs e)
        {
            Hide();
            if (User == null)
                DestroyGuest(_guest);

            var login = new SignForm().ShowDialog();
        }
    }
}
