using System.Drawing;

namespace client
{
    //          (С) Толстопятов Алексей А. 2023
    //              *** DataModels.cs ***
    // Описание модели данных для передачи в Базу данных
    //      Book    : содержит всю информацию о добавляемой/изменяемой книге
    //      Account : содержит всю информацию о пользователе
    //      Order   : содержит "сырые" данные заказа, которые необходимо шифровать.
    //      
    // В основном используются для добавления "объекта" и сообщений массивов структур внутри клиента.
    //
    
    /// <summary>
    /// Структура книги
    /// </summary>
    class Book
    {
        private string _description;
        private string _author;
        private string _title;
        private string _publisher;
        private string _category;
        private string _cost;
        private string _year;
        public Book(string name , string year , string author , string desc , string pub , string cat , string cost)
        {
            _title = name;
            _author = author;
            _publisher = pub;
            _category = cat;
            _cost = cost;
            _description = desc;
            _year = year;
        }

        public string Title => _title;
        public string Author => _author;
        public string Publisher => _publisher;
        public string Category => _category;
        public string Cost => _cost;
        public string Description => _description;
        public string Year => _year;

    }

    /// <summary>
    /// Структура данных пользователя
    /// </summary>
    class Account 
    {
        private string _name;
        private string _sname;
        private string _fname;
        private string _password;
        private string _type;
        private string _date;
        private string _url;

        public Account(string name, string fname , string sname , string password , string type , string birthdate , string url)
        {
            _name = name;
            _sname = sname;
            _fname = fname;
            _password = password;
            _type = type;
            _date = birthdate;
            _url = url;
        }

        public string Name => _name;
        public string SName => _sname;
        public string FName => _fname;
        public string Password => _password;
        public string Type => _type;
        public string BirthDate => _date;
        public string Url => _url;

    }
}
