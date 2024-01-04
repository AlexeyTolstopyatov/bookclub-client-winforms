using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace client
{
    //         (С) Толстопятов Алексей А. 2023
    // Логика окна магазина системы ООО "Книжный клуб"
    // В этом файле реализованы необходимые "службы" для корректной работы.
    // 
    public partial class ShopForm
    {
        private void CreateGuest(int ident)
        {
            var cn = new SqlConnection(_connection);
            var cm = new SqlCommand();

            try
            {
                cn.Open();
                cm.CommandText = $"INSERT [Guests] (ID) VALUES ({ident})";
                cm.Connection = cn;
                cm.ExecuteNonQuery();

                cm.CommandText = "SELECT * FROM [Guests] WHERE ID = @ident";
                cm.Parameters.AddWithValue("@ident" , ident);


                if (( int )cm.ExecuteScalar() == 0)
                    throw new InvalidOperationException();
                else
                    MessageBox.Show($"Вы работаете под guest{ident}");
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
        private void DestroyGuest(int ident)
        {
            var cn = new SqlConnection(_connection);
            var cm = new SqlCommand();

            try
            {
                cn.Open();

                cm.Connection = cn;
                cm.CommandText = "SELECT * FROM [Guests] WHERE ID = @ident";
                cm.Parameters.AddWithValue("@ident" , ident);


                if (( int )cm.ExecuteScalar() == 0)
                {
                    throw new InvalidOperationException("Пользователей не найдено. Закрывай **бло");
                }
                cm.CommandText = "DELETE FROM [Guests] WHERE ID = @ident";
                cm.Parameters.AddWithValue("@ident" , ident);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message , ident);
                MessageBox.Show($"Невозможно. Потому что: {ex.Message}");
            }
            finally
            {
                cn.Close();
                cm.Dispose();

                

            }
        }
        private void GetBooks()
        {
            BookView.Clear();

            var cn = new SqlConnection(_connection);
            var cm = new SqlCommand();

            try
            {
                cn.Open();
                var list = new ImageList();

                cm.Connection = cn;
                cm.CommandText = "SELECT COUNT(*) FROM [Books]";
                var count = ( int )cm.ExecuteScalar();

                cm.CommandText = "SELECT [Author], [Title] FROM [Books]";

                var reader = cm.ExecuteReader();

                BookView.LargeImageList = BookImageList;

                for (int i = 0; i < 20; i++)
                    BookImageList.Images.Add(Image.FromFile($"{Directory.GetCurrentDirectory()}\\covers\\{i + 1}.jpg"));

                BookImageList.ImageSize = new Size(32 , 32);

                int counter = 0;
                while (reader.Read())
                {
                    var item = new ListViewItem(reader.GetString(1), counter);

                    BookView.Items.Add(item);
                    counter++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
                cm.Dispose();
            }

        }
        private void SaveData()
        {
            var cn = new SqlConnection(_connection);
            var cm = new SqlCommand("SELECT [Context] FROM [Books]", cn);

            try
            {
                cn.Open();
                int counter = 1;
                var reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    
                    File.WriteAllText($"{counter}.t" , reader.GetString(0));
                    counter++;

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

    }
}
