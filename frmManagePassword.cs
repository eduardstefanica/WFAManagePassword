namespace WFAManagePassword
{
    public partial class frmManagePassword : Form
    {
        private const string TITLEWFA = "WFAManagePassword";
        private ManagePwd oPWD = null;
        public frmManagePassword()
        {
            InitializeComponent();
        }

        private void buttonManageConnectionString_Click(object sender, EventArgs e)
        {
            string connString = textBoxConnectionString.Text;
            string[] elemConnString = connString.Split(';');
            string passwordCriptata = string.Empty;
            int indexPassword = 0;
            if (elemConnString.Length > 0)
            {
                
                foreach (string elem in elemConnString)
                {
                    indexPassword++;
                    if (elem.Contains("Password"))
                    {
                        int pos = elem.IndexOf("=");
                        passwordCriptata = elem.Substring(pos + 1);

                        break;
                    }
                }   
                textBoxPasswordCriptata.Text = passwordCriptata;

                try
                {
                    oPWD = new ManagePwd();
                    textBoxPasswordDecriptata.Text = oPWD.DecodeFrom64(passwordCriptata);

                    elemConnString[indexPassword-1] = "Password=" + textBoxPasswordDecriptata.Text;
                    string newConnString = String.Join(";", elemConnString);
                    textBoxConnectionStringInChiaro.Text = newConnString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, TITLEWFA);
                }
            }
            
        }
    }
}
