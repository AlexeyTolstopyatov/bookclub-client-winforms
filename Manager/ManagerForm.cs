using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using client.Security;

namespace client.Manager
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();

            GetUsers();
            UpdateOrders();
            GetOrders();
        }

        private void ManagerForm_Load(object sender , EventArgs e)
        {

        }

        private void GetUsers()
        {
            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [Name] FROM [Accounts]" , cn);
            

            cn.Open();

            try 
            {
                var reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    UserList.Items.Add(reader.GetString(0));
                }
            }
            catch
            {
                
            }
        }
        private void UpdateOrders() 
        {

            var cn = new SqlConnection("SERVER=NIDOMPC\\SQLEXPRESS;DATABASE=dbook;trusted_connection=true");
            var cm = new SqlCommand("SELECT [ID], [List] FROM [Orders]", cn);
            
            // 1) получить списки (файлами)
            var list = new List<string>();
            var idlist = new List<string>();

            if (!Directory.Exists("orders"))
                Directory.CreateDirectory("orders");

            cn.Open();
            try
            {
                var reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    // 2) расшифровать заказы
                    list = Sequence.Decode(reader.GetString(0));
                    foreach (var str in list)
                    {
                        using (var writer = new StreamWriter($"orders/{reader.GetString(0)}", true))
                        {
                            writer.WriteLine(str);
                        }
                    }
                }
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void GetOrders()
        {
            string[] files = Directory.GetFiles("orders");


            try 
            {
                for (int i = 0; i < files.Length; i++)
                    foreach (var strs in File.ReadAllLines($"orders/{files[i]}", Encoding.UTF8))
                    {
                        OrdersView.DataSource += strs;
                    }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
