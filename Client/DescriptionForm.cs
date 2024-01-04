using System;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace client
{
    //         (С) Толстопятов Алексей А. 2023
    // Логика окна описания товара в системе ООО "Книжный клуб"
    // В этом файле описан слой взаимодействия с базой данных.
    //          _index      : номер страницы с описанием
    //

    public partial class DescriptionForm : Form
    {
        private Random _rand = new Random();
        private int _index;

        public DescriptionForm(int index)
        {
            InitializeComponent();
            _index = index;
        }

        private void DescriptionForm_Load(object sender , EventArgs e)
        {
            BookCoverBox.BackgroundImageLayout = ImageLayout.Zoom;
            BookCoverBox.BackgroundImage = Image.FromFile($"{Directory.GetCurrentDirectory()}\\covers\\{_index}.jpg");

            costLabel.Text += _rand.Next(300 , 500).ToString();

            try
            {
                textBox1.Text = File.ReadAllText($"{_index}.t");
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
            
        }
    }
}
