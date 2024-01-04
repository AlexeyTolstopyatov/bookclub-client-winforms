using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace client
{
    public partial class AdminForm
    {
        //      (С) Толстопятов Алексей А. 2023
        // Логика окна Администратора системы ООО "Книжный клуб"
        // В этом файле реализованы события основного меню. 
        //  * Все события/операции указываются с окончанием Option и названием события
        // (например):
        //      (+) CreateObjectOption_Click()
        //      (X) CreateObject_ToolStripMenuItem_Click()
        //
        // Название события, обычно, указывается в списке событий конструктора Windows Forms
        // (например):
        //  * MouseDown
        //  * Click
        //  * KeyPress
        //  * etc...
        //


        private void ExitOption_Click(object sender , EventArgs e) => Close();
        private void ForceExitOption_Click(object sender , EventArgs e) => Application.Exit();
        private void GetHelpOption_Click(object sender , EventArgs e)
        {
            string help =
@"
Операции (Добавить / Удалить) используются для записи или перезаписи данных в таблицу. 
";
            MessageBox.Show(help);
        }
        private void RewriteTableOption_KeyDown(object sender , KeyEventArgs e)
        {
            // RewriteTable()
            // да, тут то же самое что и в RewriteTable..._Click(object , EventArgs)
        }
        private void DelUserConfigOption_Click(object sender , EventArgs e)
        {
            if (File.Exists("userconfig.t"))
            {
                File.Delete("userconfig.t");
                MessageBox.Show("Готово.");
            }
            else
                MessageBox.Show("Не существует");
        }
        private void SetupUserConfigOption_Click(object sender , EventArgs e)
        {
            using (var input = new InputForm("Укажите параметр для 'userconfig.t'"))
            {
                // Указать кто следующий будет входить в систему. //
                string parameter;

                if (input.ShowDialog() == DialogResult.OK)
                {
                    parameter = input.DialogText;

                    if (parameter == null)
                        return;

                    // не работает //
                    input.Dispose();
                    if (File.Exists($"{Directory.GetCurrentDirectory()}\\userconfig.t"))
                        File.WriteAllText($"{Directory.GetCurrentDirectory()}\\userconfig.t" , parameter);

                    MessageBox.Show(parameter);
                    MessageBox.Show("Изменено.");
                }
            }
        }
        private void DestroyAllGuestsOption_Click(object sender , EventArgs e)
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("DELETE FROM [Guests]", cn);

            try
            {
                cn.Open();
                cm.ExecuteNonQuery();

                cm.CommandText = "SELECT COUNT(ID) FROM [Guests]";

                int result = ( int )cm.ExecuteScalar();
                if (result == 0)
                    MessageBox.Show("Удалены все сеансы");
                else
                    MessageBox.Show($"Гостей осталось: {result}");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.");
            }
            finally
            {
                cn.Close();
                cm.Dispose();
            }
        }
    }
}
