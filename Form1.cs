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
        //connect to database
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vistula\ATM\ATM\Users.mdf;Integrated Security=True";
        DataTable table = new DataTable(); //створення таблиці данних
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
            labelPIN.Visible = false;
            txtPIN.Visible = false;
            txtCustomerID.Text = "11111111116";
            txtPIN.Text = "0000";
            panelChangePIN.Visible = false;
            panelCashPayment.Visible = false;
            panelTypeOfTransaction.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnChekID_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync(); //відкриваємо зв'язок з базою
            //SqlDataReader sqlReader = null; //омагає нам получати таблицю в табличному представленні (у вигляді таблиці)
           
            //зчитуємо дані про ID та пароль
            String customerID = txtCustomerID.Text;
            String customerPassword = txtPIN.Text;
            //тут повинна бути перевідка на небукви в ID
            //прописуємо команду, яку ми відтворюємо по відношенню до бази даних
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
            //@ID - заглушки, щоб було важче взламати "банк"
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;

            DataTable table = new DataTable(); //створення таблиці данних
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command; //вибрали потрібно команду, виконали її
            adapter.Fill(table); //помістили всі значення в об'єкт table

            if (table.Rows.Count > 0)
            {
                labelPIN.Visible = true;
                txtPIN.Visible = true;
                btnChekID.Enabled = false;
                btnChekID.FlatStyle = FlatStyle.System;
                txtCustomerID.Enabled = false;
                txtChangePIN.Enabled = false;

            }
            else
                MessageBox.Show("Сard does not exist or is locked");
            sqlConnection.Close();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync(); 
            String customerID = txtCustomerID.Text;
            String customerPassword = txtPIN.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID AND [Password] =@PW", sqlConnection);           
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
            command.Parameters.Add("@PW", SqlDbType.VarChar).Value = customerPassword;
                       
            adapter.SelectCommand = command; //вибрали потрібно команду, виконали її
            adapter.Fill(table); //помістили всі значення в об'єкт table

            //перевірка пароля 
                        
            adapter.SelectCommand = command; //вибрали потрібно команду, виконали її
            adapter.Fill(table); //помістили всі значення в об'єкт table
            if (labelPIN.Visible == true)
            {
                if (table.Rows.Count > 0)
                {
                    panelEkran.Visible = false;
                    panelTypeOfTransaction.Visible = true;


                }
                else
                    MessageBox.Show("Irregular PIN");
            }
            
            if (txtChangePIN.Enabled == true)
            {
                if (labelNowyPIN.Visible == true)
                {
                    command = new SqlCommand("UPDATE [User] SET [Password] ='" + txtChangePIN.Text + "'" +
                         "WHERE [PersonalId] = '" + txtCustomerID.Text + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("PIN jest zmieniony");
                    labelNowyPIN.Visible = false;
                    customerPassword = txtChangePIN.Text;

                }
                if (customerPassword == txtChangePIN.Text && panelChangePIN.Visible == true)
                {
                    if (labelNowyPIN.Visible == false)
                    {
                        labelNowyPIN.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Nie nie");
                    }
                }

                

            }
            
            sqlConnection.Close();

        }


        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // можливість вводу тільки цифр
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
                e.Handled = true; 
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if(txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
            txtCustomerID.Text = txtCustomerID.Text + "0";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
            txtPIN.Text = txtPIN.Text + "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "1";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "1"; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "2";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "3";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "4";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "5";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "6";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength<11)
                txtCustomerID.Text = txtCustomerID.Text + "7";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "8";
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text = txtPIN.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text = txtCustomerID.Text + "9";
            if (txtPIN.Enabled == true && txtPIN.TextLength<4)
                txtPIN.Text = txtPIN.Text + "9";
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true)
                txtCustomerID.Text = "";
            if (txtPIN.Enabled == true)
                txtPIN.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true)
                txtCustomerID.Text = txtCustomerID.Text.Substring(0,
                    txtCustomerID.Text.Length - 1);
            else
            {
                if (txtPIN.Enabled == true)
                    txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1);
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Give cart");
            Environment.Exit(0);
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnWYplata_Click(object sender, EventArgs e)
        {

        }

        private void btnWlpata_Click(object sender, EventArgs e)
        {
            panelCashPayment.Visible = true;
            panelTypeOfTransaction.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelTypeOfTransaction.Visible = true;
            panelCashPayment.Visible = false;
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("UPDATE [User] SET [Saldo] = [Saldo]+'"+txtCash.Text+"'" +
                "WHERE [PersonalId] = '"+ txtCustomerID.Text+"'",sqlConnection);
            command.ExecuteNonQuery();
            labelCash.Text = Convert.ToString(Convert.ToDouble(labelCash.Text) + Convert.ToDouble(txtCash.Text));
            sqlConnection.Close();
        }

        private void btnPIN_Click(object sender, EventArgs e)
        {
            txtChangePIN.Enabled = true;
            panelChangePIN.Visible = true;
            panelTypeOfTransaction.Visible = false;
        }
    }
}
