namespace ATM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelEkran = new System.Windows.Forms.Panel();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panelTypeOfTransaction = new System.Windows.Forms.Panel();
            this.btnDoladowanie = new System.Windows.Forms.Button();
            this.btnAktywacja = new System.Windows.Forms.Button();
            this.btnPIN = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnWlpata = new System.Windows.Forms.Button();
            this.btnWYplata = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChekID = new System.Windows.Forms.Button();
            this.panelCashPayment = new System.Windows.Forms.Panel();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panelChangePIN = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChangePIN = new System.Windows.Forms.TextBox();
            this.labelStaryPIN = new System.Windows.Forms.Label();
            this.labelNowyPIN = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panelEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTypeOfTransaction.SuspendLayout();
            this.panelCashPayment.SuspendLayout();
            this.panelChangePIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEkran
            // 
            this.panelEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.panelEkran.Controls.Add(this.txtPIN);
            this.panelEkran.Controls.Add(this.labelPIN);
            this.panelEkran.Controls.Add(this.txtCustomerID);
            this.panelEkran.Controls.Add(this.pictureBox1);
            this.panelEkran.Location = new System.Drawing.Point(16, 34);
            this.panelEkran.Name = "panelEkran";
            this.panelEkran.Size = new System.Drawing.Size(556, 340);
            this.panelEkran.TabIndex = 0;
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPIN.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtPIN.Location = new System.Drawing.Point(171, 214);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(72, 31);
            this.txtPIN.TabIndex = 4;
            this.txtPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.labelPIN.Location = new System.Drawing.Point(169, 181);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(74, 34);
            this.labelPIN.TabIndex = 3;
            this.labelPIN.Text = "PIN";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCustomerID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtCustomerID.Location = new System.Drawing.Point(141, 118);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.MaxLength = 11;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(260, 42);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.Text = "Customer ID";
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.iconfinder_credit_card_3671752;
            this.pictureBox1.Location = new System.Drawing.Point(105, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(207, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(263, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(153, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(209, 443);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(263, 443);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(153, 498);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(209, 498);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 49);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(263, 498);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 49);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(209, 550);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 49);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(58)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(319, 388);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 49);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonCansel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCansel.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCansel.Location = new System.Drawing.Point(319, 440);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(118, 49);
            this.buttonCansel.TabIndex = 12;
            this.buttonCansel.Text = "CANCEL";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(255)))), ((int)(((byte)(98)))));
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(319, 494);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(118, 49);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panelTypeOfTransaction
            // 
            this.panelTypeOfTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.panelTypeOfTransaction.Controls.Add(this.btnDoladowanie);
            this.panelTypeOfTransaction.Controls.Add(this.btnAktywacja);
            this.panelTypeOfTransaction.Controls.Add(this.btnPIN);
            this.panelTypeOfTransaction.Controls.Add(this.btnSaldo);
            this.panelTypeOfTransaction.Controls.Add(this.btnAnuluj);
            this.panelTypeOfTransaction.Controls.Add(this.btnWlpata);
            this.panelTypeOfTransaction.Controls.Add(this.btnWYplata);
            this.panelTypeOfTransaction.Controls.Add(this.label3);
            this.panelTypeOfTransaction.Controls.Add(this.label4);
            this.panelTypeOfTransaction.ForeColor = System.Drawing.Color.Black;
            this.panelTypeOfTransaction.Location = new System.Drawing.Point(16, 380);
            this.panelTypeOfTransaction.Name = "panelTypeOfTransaction";
            this.panelTypeOfTransaction.Size = new System.Drawing.Size(556, 340);
            this.panelTypeOfTransaction.TabIndex = 16;
            this.panelTypeOfTransaction.Visible = false;
            // 
            // btnDoladowanie
            // 
            this.btnDoladowanie.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnDoladowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnDoladowanie.FlatAppearance.BorderSize = 0;
            this.btnDoladowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoladowanie.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoladowanie.Location = new System.Drawing.Point(0, 228);
            this.btnDoladowanie.Name = "btnDoladowanie";
            this.btnDoladowanie.Size = new System.Drawing.Size(247, 49);
            this.btnDoladowanie.TabIndex = 3;
            this.btnDoladowanie.Text = "Doladowanie telefonu";
            this.btnDoladowanie.UseVisualStyleBackColor = false;
            // 
            // btnAktywacja
            // 
            this.btnAktywacja.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnAktywacja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnAktywacja.FlatAppearance.BorderSize = 0;
            this.btnAktywacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktywacja.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktywacja.Location = new System.Drawing.Point(0, 173);
            this.btnAktywacja.Name = "btnAktywacja";
            this.btnAktywacja.Size = new System.Drawing.Size(247, 49);
            this.btnAktywacja.TabIndex = 3;
            this.btnAktywacja.Text = "Aktywacja karty";
            this.btnAktywacja.UseVisualStyleBackColor = false;
            // 
            // btnPIN
            // 
            this.btnPIN.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnPIN.FlatAppearance.BorderSize = 0;
            this.btnPIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPIN.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPIN.Location = new System.Drawing.Point(310, 228);
            this.btnPIN.Name = "btnPIN";
            this.btnPIN.Size = new System.Drawing.Size(247, 49);
            this.btnPIN.TabIndex = 3;
            this.btnPIN.Text = "Zmiana PIN";
            this.btnPIN.UseVisualStyleBackColor = false;
            this.btnPIN.Click += new System.EventHandler(this.btnPIN_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.Location = new System.Drawing.Point(310, 173);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(247, 49);
            this.btnSaldo.TabIndex = 3;
            this.btnSaldo.Text = "Dostępne środki";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnAnuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnAnuluj.FlatAppearance.BorderSize = 0;
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuluj.Location = new System.Drawing.Point(0, 118);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(247, 49);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnWlpata
            // 
            this.btnWlpata.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnWlpata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnWlpata.FlatAppearance.BorderSize = 0;
            this.btnWlpata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWlpata.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWlpata.Location = new System.Drawing.Point(310, 283);
            this.btnWlpata.Name = "btnWlpata";
            this.btnWlpata.Size = new System.Drawing.Size(247, 49);
            this.btnWlpata.TabIndex = 3;
            this.btnWlpata.Text = "Wpłata gotówki";
            this.btnWlpata.UseVisualStyleBackColor = false;
            this.btnWlpata.Click += new System.EventHandler(this.btnWlpata_Click);
            // 
            // btnWYplata
            // 
            this.btnWYplata.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnWYplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnWYplata.FlatAppearance.BorderSize = 0;
            this.btnWYplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWYplata.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWYplata.Location = new System.Drawing.Point(310, 118);
            this.btnWYplata.Name = "btnWYplata";
            this.btnWYplata.Size = new System.Drawing.Size(247, 49);
            this.btnWYplata.TabIndex = 3;
            this.btnWYplata.Text = "Wypłata gotówki";
            this.btnWYplata.UseVisualStyleBackColor = false;
            this.btnWYplata.Click += new System.EventHandler(this.btnWYplata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proszę, wybierz typ operazcji";
            // 
            // btnChekID
            // 
            this.btnChekID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChekID.BackgroundImage")));
            this.btnChekID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChekID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChekID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChekID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChekID.Location = new System.Drawing.Point(579, 34);
            this.btnChekID.Name = "btnChekID";
            this.btnChekID.Size = new System.Drawing.Size(188, 202);
            this.btnChekID.TabIndex = 15;
            this.btnChekID.UseVisualStyleBackColor = true;
            this.btnChekID.Click += new System.EventHandler(this.btnChekID_Click);
            // 
            // panelCashPayment
            // 
            this.panelCashPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.panelCashPayment.Controls.Add(this.txtCash);
            this.panelCashPayment.Controls.Add(this.button11);
            this.panelCashPayment.Controls.Add(this.button10);
            this.panelCashPayment.Controls.Add(this.btnPayment);
            this.panelCashPayment.Controls.Add(this.label1);
            this.panelCashPayment.Controls.Add(this.labelCash);
            this.panelCashPayment.Controls.Add(this.label6);
            this.panelCashPayment.Controls.Add(this.label2);
            this.panelCashPayment.Location = new System.Drawing.Point(867, 34);
            this.panelCashPayment.Name = "panelCashPayment";
            this.panelCashPayment.Size = new System.Drawing.Size(556, 340);
            this.panelCashPayment.TabIndex = 18;
            this.panelCashPayment.Visible = false;
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtCash.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(54, 209);
            this.txtCash.MaxLength = 4;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(223, 42);
            this.txtCash.TabIndex = 4;
            this.txtCash.Text = "0,00";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button10
            // 
            this.button10.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(0, 283);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(189, 49);
            this.button10.TabIndex = 3;
            this.button10.Text = "Powrót do menu";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(212)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(309, 205);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(247, 49);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Wpłać środki";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wpłata gotówki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Suma wpłaty: ";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.labelCash.Location = new System.Drawing.Point(235, 121);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(72, 34);
            this.labelCash.TabIndex = 0;
            this.labelCash.Text = "0,00";
            // 
            // button11
            // 
            this.button11.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(368, 283);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(189, 49);
            this.button11.TabIndex = 3;
            this.button11.Text = "Zakończ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // panelChangePIN
            // 
            this.panelChangePIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.panelChangePIN.Controls.Add(this.button14);
            this.panelChangePIN.Controls.Add(this.labelNowyPIN);
            this.panelChangePIN.Controls.Add(this.txtChangePIN);
            this.panelChangePIN.Controls.Add(this.label5);
            this.panelChangePIN.Controls.Add(this.labelStaryPIN);
            this.panelChangePIN.Controls.Add(this.label7);
            this.panelChangePIN.ForeColor = System.Drawing.Color.Black;
            this.panelChangePIN.Location = new System.Drawing.Point(637, 34);
            this.panelChangePIN.Name = "panelChangePIN";
            this.panelChangePIN.Size = new System.Drawing.Size(556, 340);
            this.panelChangePIN.TabIndex = 16;
            this.panelChangePIN.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zmiana PIN";
            // 
            // txtChangePIN
            // 
            this.txtChangePIN.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtChangePIN.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtChangePIN.Location = new System.Drawing.Point(150, 165);
            this.txtChangePIN.MaxLength = 4;
            this.txtChangePIN.Name = "txtChangePIN";
            this.txtChangePIN.PasswordChar = '*';
            this.txtChangePIN.Size = new System.Drawing.Size(249, 59);
            this.txtChangePIN.TabIndex = 4;
            this.txtChangePIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // labelStaryPIN
            // 
            this.labelStaryPIN.AutoSize = true;
            this.labelStaryPIN.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.labelStaryPIN.Location = new System.Drawing.Point(129, 117);
            this.labelStaryPIN.Name = "labelStaryPIN";
            this.labelStaryPIN.Size = new System.Drawing.Size(310, 34);
            this.labelStaryPIN.TabIndex = 0;
            this.labelStaryPIN.Text = "Wprowadź stary PIN";
            // 
            // labelNowyPIN
            // 
            this.labelNowyPIN.AutoSize = true;
            this.labelNowyPIN.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.labelNowyPIN.Location = new System.Drawing.Point(136, 117);
            this.labelNowyPIN.Name = "labelNowyPIN";
            this.labelNowyPIN.Size = new System.Drawing.Size(312, 34);
            this.labelNowyPIN.TabIndex = 5;
            this.labelNowyPIN.Text = "Wprowadź nowy PIN";
            this.labelNowyPIN.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(937, 534);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 89);
            this.button13.TabIndex = 20;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(799, 554);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(141, 48);
            this.button12.TabIndex = 23;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(0, 283);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(189, 49);
            this.button14.TabIndex = 6;
            this.button14.Text = "Powrót do menu";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1360, 730);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panelTypeOfTransaction);
            this.Controls.Add(this.panelCashPayment);
            this.Controls.Add(this.panelChangePIN);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChekID);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.panelEkran);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEkran.ResumeLayout(false);
            this.panelEkran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTypeOfTransaction.ResumeLayout(false);
            this.panelTypeOfTransaction.PerformLayout();
            this.panelCashPayment.ResumeLayout(false);
            this.panelCashPayment.PerformLayout();
            this.panelChangePIN.ResumeLayout(false);
            this.panelChangePIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEkran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button btnChekID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTypeOfTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoladowanie;
        private System.Windows.Forms.Button btnAktywacja;
        private System.Windows.Forms.Button btnPIN;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnWlpata;
        private System.Windows.Forms.Button btnWYplata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCashPayment;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panelChangePIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNowyPIN;
        private System.Windows.Forms.TextBox txtChangePIN;
        private System.Windows.Forms.Label labelStaryPIN;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
    }
}

