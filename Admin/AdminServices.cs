using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    //      (С) Толстопятов Алексей А. 2023 
    // Логика окна Администратора системы ООО "Книжный клуб"
    // В этом файле реализованы необходимые "службы" для корректного запуска.
    //  * При изменении UI, ЕСЛИ изменение требует внесения операции в список вызываемых при 
    // загрузке формы, операция указывается здесь, и вызывается в AdminForm_Load(object, EventArgs)
    // 


    public partial class AdminForm
    {
        private void GetTables()
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT name FROM sys.tables", cn);

            try
            {
                // Данные о таблицах в бд //
                cn.Open();

                var rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    var mi = new ToolStripMenuItem(rd.GetString(0));
                    mi.Enabled = false;
                    TablesMenuItem.DropDownItems.Add(mi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Dispose();
                cn.Close();
            }


        }
        private void GetBooks()
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [Title] FROM [Books]", cn);

            try
            {
                // Данные о таблицах в бд //
                cn.Open();

                var rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    AvaliableBooks.Items.Add(rd.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Dispose();
                cn.Close();
            }
        }
        private void GetCategiroes()
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [Context] FROM [Categories]", cn);

            try
            {
                // Данные о таблицах в бд //
                cn.Open();

                var rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    BookCategory.Items.Add(rd.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Dispose();
                cn.Close();
            }
        }
        private void GetAccounts()
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [SName], [FName] FROM [Accounts]", cn);

            try
            {
                // Данные о таблицах в бд //
                cn.Open();

                var rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    AvaliableAccounts.Items.Add($"{rd.GetString(0)} {rd.GetString(1)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ну и ну блять. Вообще-то {ex.Message}");
            }
            finally
            {
                cm.Dispose();
                cn.Close();
            }
        }
        private void GetTypes()
        {

            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [Context] FROM [Type]", cn);

            try
            {
                cn.Open();
                var reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    TypeBox.Items.Add(reader.GetString(0));
                }
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
