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
    //         (С) Толстопятов Алексей А. 2023
    //  Логика диалогового окна системы ООО "Книжный клуб"
    // В этом файле описан слой взаимодействия c окнами в системе. 
    //      InputForm(string)            : принимает сообщение с которым откроет окно
    //      MessageLabel                 : принимает сообщение из конструктора
    //      DialogResult -> DialogResult : возвращает кнопку, выбранную для выхода из диалога
    //      DialogText -> string         : возвращает установленое пользователем значение
    //      
    //      CancelButton()               : закрывает окно, DialogText == null
    //      DoneButton()                 : закрывает окно, сохраняет параметр DialogText
    //

    public partial class InputForm : Form
    {
        
        public InputForm(string context)
        {
            InitializeComponent();
            MessageLabel.Text = context;

        }

        /// <summary>
        /// Хранит установленое значение, (по идее) может быть получено по закрытию экземпляра формы
        /// </summary>
        public string DialogText
        { 
            get => ParameterBox.Text;
            private set => ParameterBox.Text = value; 
        }

        private void CancelButton_Click(object sender , EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            DialogText = null;
            Close();
        }
        private void DoneButton_Click(object sender , EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
