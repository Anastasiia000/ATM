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

namespace ATM
{
    public partial class Form1 : Form
    {
        
        //  string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\vistula\\ATM\\ATM\\Users.mdf;Integrated Security=True";
        void MyConnection()
        {                    
            SqlConnection myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\vistula\\ATM\\ATM\\Users.mdf;Integrated Security=True");
            myConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = 11111111111", myConnection);
            SqlDataReader reader = command.ExecuteReader();
            
        }
        
        public Form1()
        {
            InitializeComponent();
            List<string> inf1 = new List<string>();
            label1.Text = "nvklndlk";
            //MyConnection();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnChekID_Click(object sender, EventArgs e)
        {
            //connect to database
            String CustomerID = txtCustomerID.Text;
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vistula\ATM\ATM\Users.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync(); //відкриваємо зв'язок з базою
            //SqlDataReader sqlReader = null; //омагає нам получати таблицю в табличному представленні (у вигляді таблиці)
           
            //прописуємо команду, яку ми відтворюємо по відношенню до бази даних
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
            //@ID - заглушки, щоб було важче взламати "банк"
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = CustomerID;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command; //вибрали потрібно команду, виконали її
            adapter.Fill(table); //помістили всі значення в об'єкт table

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");


            /*
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["PersonalId"]) + " " +
                        Convert.ToString(sqlReader["Password"]) + " " + Convert.ToString(sqlReader["Saldo"]));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            } 
            */

        }

        private  void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
