
namespace WFAManagePassword
{
    partial class frmManagePassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonEncrypt = new Button();
            textBoxPasswordInChiaro = new TextBox();
            textBoxPasswordCriptata = new TextBox();
            label2 = new Label();
            textBoxPasswordDecriptata = new TextBox();
            buttonDecrypt = new Button();
            label3 = new Label();
            textBoxConnectionString = new TextBox();
            label4 = new Label();
            buttonManageConnectionString = new Button();
            textBoxConnectionStringInChiaro = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 138);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Password in chiaro:";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(360, 134);
            buttonEncrypt.Margin = new Padding(1);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(79, 21);
            buttonEncrypt.TabIndex = 1;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // textBoxPasswordInChiaro
            // 
            textBoxPasswordInChiaro.Location = new Point(130, 136);
            textBoxPasswordInChiaro.Margin = new Padding(1);
            textBoxPasswordInChiaro.Name = "textBoxPasswordInChiaro";
            textBoxPasswordInChiaro.PasswordChar = '*';
            textBoxPasswordInChiaro.Size = new Size(222, 23);
            textBoxPasswordInChiaro.TabIndex = 2;
            // 
            // textBoxPasswordCriptata
            // 
            textBoxPasswordCriptata.Location = new Point(130, 166);
            textBoxPasswordCriptata.Margin = new Padding(1);
            textBoxPasswordCriptata.Name = "textBoxPasswordCriptata";
            textBoxPasswordCriptata.Size = new Size(222, 23);
            textBoxPasswordCriptata.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 168);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Password Criptata:";
            // 
            // textBoxPasswordDecriptata
            // 
            textBoxPasswordDecriptata.Location = new Point(130, 202);
            textBoxPasswordDecriptata.Margin = new Padding(1);
            textBoxPasswordDecriptata.Name = "textBoxPasswordDecriptata";
            textBoxPasswordDecriptata.Size = new Size(222, 23);
            textBoxPasswordDecriptata.TabIndex = 8;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(360, 162);
            buttonDecrypt.Margin = new Padding(1);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(79, 21);
            buttonDecrypt.TabIndex = 7;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 204);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Password in chiaro:";
            // 
            // textBoxConnectionString
            // 
            textBoxConnectionString.Location = new Point(13, 46);
            textBoxConnectionString.Margin = new Padding(1);
            textBoxConnectionString.Multiline = true;
            textBoxConnectionString.Name = "textBoxConnectionString";
            textBoxConnectionString.Size = new Size(709, 60);
            textBoxConnectionString.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 24);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 9;
            label4.Text = "Connection String:";
            // 
            // buttonManageConnectionString
            // 
            buttonManageConnectionString.Location = new Point(530, 135);
            buttonManageConnectionString.Margin = new Padding(1);
            buttonManageConnectionString.Name = "buttonManageConnectionString";
            buttonManageConnectionString.Size = new Size(192, 21);
            buttonManageConnectionString.TabIndex = 11;
            buttonManageConnectionString.Text = "Manage Connection String";
            buttonManageConnectionString.UseVisualStyleBackColor = true;
            buttonManageConnectionString.Click += buttonManageConnectionString_Click;
            // 
            // textBoxConnectionStringInChiaro
            // 
            textBoxConnectionStringInChiaro.Location = new Point(10, 263);
            textBoxConnectionStringInChiaro.Margin = new Padding(1);
            textBoxConnectionStringInChiaro.Multiline = true;
            textBoxConnectionStringInChiaro.Name = "textBoxConnectionStringInChiaro";
            textBoxConnectionStringInChiaro.Size = new Size(712, 58);
            textBoxConnectionStringInChiaro.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 241);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 12;
            label5.Text = "Connection String in chiaro:";
            // 
            // frmManagePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 331);
            Controls.Add(textBoxConnectionStringInChiaro);
            Controls.Add(label5);
            Controls.Add(buttonManageConnectionString);
            Controls.Add(textBoxConnectionString);
            Controls.Add(label4);
            Controls.Add(textBoxPasswordDecriptata);
            Controls.Add(buttonDecrypt);
            Controls.Add(label3);
            Controls.Add(textBoxPasswordCriptata);
            Controls.Add(label2);
            Controls.Add(textBoxPasswordInChiaro);
            Controls.Add(buttonEncrypt);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "frmManagePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crypt - Decrypt Password";
            Load += frmManagePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmManagePassword_Load(object sender, EventArgs e)
        {
            textBoxConnectionString.Text = "Data Source=PATRIZIO2024;Initial Catalog=CorsoAcademy;Integrated Security=False;User=CorsoAdmin;Password=Q29yc29BZG1pbjAxIQ==;TrustServerCertificate=Yes;MultipleActiveResultSets=true;";
            textBoxPasswordInChiaro.Text = "CorsoAdmin01!";
            textBoxPasswordCriptata.Text = string.Empty;
            textBoxPasswordDecriptata.Text = string.Empty;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string passwordinchiaro = textBoxPasswordInChiaro.Text;
            
            string passwordcriptata = string.Empty;
            try
            {
                oPWD = new ManagePwd();
                passwordcriptata = oPWD.EncodePasswordToBase64(passwordinchiaro);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, TITLEWFA);
            }

            textBoxPasswordCriptata.Text = passwordcriptata;
            
        }
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string passwordinchiaro = string.Empty;
            string passwordcriptata = textBoxPasswordCriptata.Text;
            try
            {
                oPWD = new ManagePwd();
                passwordinchiaro = oPWD.DecodeFrom64(passwordcriptata);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITLEWFA);
            }
            textBoxPasswordDecriptata.Text = passwordinchiaro;
        }

        

        

        #endregion

        private Label label1;
        private Button buttonEncrypt;
        private TextBox textBoxPasswordInChiaro;
        private TextBox textBoxPasswordCriptata;
        private Label label2;
        private TextBox textBoxPasswordDecriptata;
        private Button buttonDecrypt;
        private Label label3;
        private TextBox textBoxConnectionString;
        private Label label4;
        private Button buttonManageConnectionString;
        private TextBox textBoxConnectionStringInChiaro;
        private Label label5;
    }
}
