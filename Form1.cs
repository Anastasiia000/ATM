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

        public Form1()
        {
            
            InitializeComponent();
            labelPIN.Visible = false;
            txtPIN.Visible = false;
            txtCustomerID.Text = "11111111116";
            //txtPIN.Text = "0000";
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
                btnChekID.FlatStyle = FlatStyle.Standard;
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
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command; //вибрали потрібно команду, виконали її
            adapter.Fill(table); //помістили всі значення в об'єкт table

            //перевірка пароля 
                        
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

            if (panelCashPayment.Visible == true)
            {
               
                command = new SqlCommand("UPDATE [User] SET [Saldo] = [Saldo]+'" + txtCash.Text + "'" +
                    "WHERE [PersonalId] = '" + txtCustomerID.Text + "'", sqlConnection);
                command.ExecuteNonQuery();
                labelCash.Text = Convert.ToString(Convert.ToDouble(labelCash.Text) + Convert.ToDouble(txtCash.Text));
                sqlConnection.Close();
            }

            if (txtChangePIN.Enabled == true)
            {
                if (labelNowyPIN.Visible == true)
                {
                    command = new SqlCommand("UPDATE [User] SET [Password] ='" + txtChangePIN.Text + "'" +
                         "WHERE [PersonalId] = '" + txtCustomerID.Text + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("PIN został zmieniony");
                    MessageBox.Show("Give cart");
                    Environment.Exit(0);

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
            
            if (panelEntrywithdrawal.Visible == true)
            {
                command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
                SqlDataReader dataReader = null;
                dataReader = await command.ExecuteReaderAsync();
                while (await dataReader.ReadAsync())
                {
                    if (Convert.ToDouble(dataReader["Saldo"]) < Convert.ToDouble(txtEntrywithdrawal.Text))
                    {
                        MessageBox.Show("You don't have enough money\nOn your balans: " + Convert.ToString(dataReader["Saldo"]));
                    }
                    else
                    {
                        dataReader.Close();
                        command = new SqlCommand("UPDATE [User] SET [Saldo] = [Saldo]-'" + txtEntrywithdrawal.Text + "'" +
                                "WHERE [PersonalId] = '" + txtCustomerID.Text + "'", sqlConnection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
                        command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
                        dataReader = await command.ExecuteReaderAsync();
                        while (await dataReader.ReadAsync())
                            MessageBox.Show("          Paragon         \nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\n" +
                               "BlaBlaBlaBla\nBlaBlaBlaBla\nStan Saldo: " + Convert.ToString(dataReader["Saldo"]));
                        MessageBox.Show("Give money");
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

        #region Action with button

 #region buttonN_Click

        private void buttonAction (int N)
        {
            if (txtCustomerID.Enabled == true && txtCustomerID.TextLength < 11)
                txtCustomerID.Text +=  N;
            if (txtPIN.Enabled == true && txtPIN.TextLength < 4)
                txtPIN.Text += N;
            if (panelEntrywithdrawal.Visible == true && txtEntrywithdrawal.TextLength < 4)
                txtEntrywithdrawal.Text += N;
            if (panelChangePIN.Visible == true && txtChangePIN.TextLength < 4)
                txtChangePIN.Text += N;
            if (panelCashPayment.Visible == true && txtCash.TextLength < 4)
                txtCash.Text += N;
        }


        private void button0_Click(object sender, EventArgs e)
        {
            buttonAction(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buttonAction(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonAction(2);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            buttonAction(3);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            buttonAction(4);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            buttonAction(5);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            buttonAction(6);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            buttonAction(7);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            buttonAction(8);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            buttonAction(9);

        }
        #endregion


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true)
                txtCustomerID.Text = "";
            if (txtPIN.Visible == true)
                txtPIN.Text = "";
            if (panelEntrywithdrawal.Visible == true)
                txtEntrywithdrawal.Text ="";
            if (panelChangePIN.Visible == true)
                txtChangePIN.Text ="";
            if (panelCashPayment.Visible == true)
                txtCash.Text ="";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Enabled == true && panelEkran.Visible == true && txtCustomerID.TextLength!=0)
                txtCustomerID.Text = txtCustomerID.Text.Substring(0, txtCustomerID.Text.Length - 1);
            if (txtPIN.Visible == true && panelEkran.Visible == true && txtPIN.TextLength != 0)
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1);            
            if (panelEntrywithdrawal.Visible == true && txtEntrywithdrawal.TextLength != 0)
                txtEntrywithdrawal.Text = txtEntrywithdrawal.Text.Substring(0, txtEntrywithdrawal.Text.Length - 1);
            if (panelChangePIN.Visible == true && txtChangePIN.TextLength != 0)
                txtChangePIN.Text = txtChangePIN.Text.Substring(0, txtChangePIN.Text.Length - 1);
            if (panelCashPayment.Visible == true && txtCash.TextLength != 0)
                txtCash.Text =txtCash.Text.Substring(0, txtCash.Text.Length - 1);
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Give cart");
            Environment.Exit(0);
        }

        private async void btnSaldo_Click(object sender, EventArgs e)
        {
            panelDostepneSrodki.Visible = true;
            panelTypeOfTransaction.Visible = false;
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            String customerID = txtCustomerID.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
            SqlDataReader dataReader = null;
            
                dataReader = await command.ExecuteReaderAsync();
                while (await dataReader.ReadAsync())
                    txtDostepneSrodki.Text = Convert.ToString(dataReader["Saldo"]);
                                

        }

        private void btnWYplata_Click(object sender, EventArgs e)
        {
            panelTypeOfTransaction.Visible = false;
            panelCashWithdrawal.Visible = true;
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
            panelChangePIN.Visible = false;
            panelDostepneSrodki.Visible = false;
            panelCashWithdrawal.Visible = false;
            panelEntrywithdrawal.Visible = false;
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

        private void btnDoladowanie_Click(object sender, EventArgs e)
        {

        }

        private void btnAktywacja_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintReceit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          Paragon         \nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\n" +
                "BlaBlaBlaBla\nBlaBlaBlaBla\nStan Saldo: " +txtDostepneSrodki.Text);
            MessageBox.Show("Give cart");

            Environment.Exit(0);
        }


        #region Action with saldo
        private async void minusSaldo(float N)
        {
            sqlConnection = new SqlConnection(connectionString);
            string customerID = txtCustomerID.Text;
            await sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
            SqlDataReader dataReader = null;
            dataReader = await command.ExecuteReaderAsync();
            while (await dataReader.ReadAsync())
            {
                if (Convert.ToDouble(dataReader["Saldo"]) < N)
                {
                    MessageBox.Show("You don't have enough money\nOn your balans: " + Convert.ToString(dataReader["Saldo"]));
                }
                else
                {
                    dataReader.Close();
                    command = new SqlCommand("UPDATE [User] SET [Saldo] = [Saldo]-'" + N + "'" +
                            "WHERE [PersonalId] = '" + txtCustomerID.Text + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("SELECT * FROM [User] WHERE [PersonalID] = @ID", sqlConnection);
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = customerID;
                    dataReader = await command.ExecuteReaderAsync();
                    while (await dataReader.ReadAsync())
                        MessageBox.Show("          Paragon         \nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\nBlaBlaBlaBla\n" +
                           "BlaBlaBlaBla\nBlaBlaBlaBla\nStan Saldo: " + Convert.ToString(dataReader["Saldo"]));
                    MessageBox.Show("Give money");
                }
            }
            sqlConnection.Close();
            MessageBox.Show("Give cart");

            Environment.Exit(0);
        }

        private void btnfifty_Click(object sender, EventArgs e)
        {
            minusSaldo(50);
        }

        private void btnhundred_Click(object sender, EventArgs e)
        {
            minusSaldo(100);
        }

        private void btnTwoHundred_Click(object sender, EventArgs e)
        {
            minusSaldo(200);
        }

        private void btnthreeHundred_Click(object sender, EventArgs e)
        {
            minusSaldo(300);
        }

        private void btnfiveHundred_Click(object sender, EventArgs e)
        {
            minusSaldo(500);
        }

        private void btnEnother_Click(object sender, EventArgs e)
        {
            panelCashWithdrawal.Visible = false;
            panelEntrywithdrawal.Visible = true;
        }
        #endregion



        #endregion
    }
}
