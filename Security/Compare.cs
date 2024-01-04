using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace client.Security
{
    //          (С) Толстопятов Алексей А. 2023
    //  
    public class Compare
    {
        private string _table;
        private SqlConnection _connection;
        private List<int> _indexes;
        private List<string> _items;
        public Compare(SqlConnection connection)
        {
            _connection = connection;   
        }

        public List<int> Indexes 
        {
            set => _indexes = value;
        }
        public List<string> Items
        {
            set => _items = value;
        }
        public string Table 
        {
            get => _table; 
            set => _table = value;
        }

        public List<int> WithID()
        {
            _indexes = new List<int>();

            SqlCommand sqlCommand = new SqlCommand();

            // 1) сборка запроса
            string query = $"SELECT [ID] FROM [{_table}] WHERE [Title] IN (";
            foreach (var item in _items)
            {
                query += "'" + int.Parse(item) + "'";
                if (item != null && !string.IsNullOrEmpty(item))
                {
                    query += ",";
                }
            }
            query += ")";

            // 2) реализация соединения
            sqlCommand.CommandText = query;
            sqlCommand.Connection = _connection;

            try
            {
                _connection.Open();
                var reader = sqlCommand.ExecuteReader();

                // 3) запись в коллекцию
                while (reader.Read()) 
                {
                    _indexes.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            return _indexes;
        }
        public List<string> WithContent() 
        {
            // 1) сборка запроса
            string ordered = string.Join(", " , _items.Select(x => x.ToString()).ToArray());
            string query = $"SELECT [Titles] FROM [{_table}] WHERE [ID] IN ({ordered})";

            // 2) реализация соединения
            SqlCommand sqlCommand = new SqlCommand(query, _connection);

            try 
            {
                // 3) запись в коллекцию
                _connection.Open();
                
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    _items.Add($"{reader.GetString(0)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return _items;
        }


        
    }
}
