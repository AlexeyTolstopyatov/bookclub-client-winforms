using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    //      (С) Толстопятов Алексей А. 2023
    // Логика окна корзины пользователя
    //      CartForm(IEnumerable<type>)     : получает коллекцию заказанных книг
    //      _books                          : коллекция заказаных книг, которую необходимо отобразить.

    /// <summary>
    /// Форма корзины пользователя.
    /// </summary>
    public partial class CartForm : Form
    {
        private IEnumerable<string> _books;

        /// <summary>
        ///  Для инициализации принимает параметр который содержит список книг
        /// </summary>
        /// <param name="books">Список для отображения выбранных книг пользователя</param>
        public CartForm(IEnumerable<string> books)
        {
            InitializeComponent();
            _books = books;
        }


        private void CartForm_Load(object sender , EventArgs e)
        {
            // Отображение книг в корзине пользователя
            
            if (_books == null) 
                _books = new List<string>();

            foreach (var book in _books)
                OBList.Items.Add(book);
            
        }
    }
}
