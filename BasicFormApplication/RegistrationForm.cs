using System.Data.OleDb;

namespace BasicFormApplication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            string register = "INSERT INTO tbl_users VALUES ('" + tbUsername.Text + "','" + tbPassword.Text + "')";
            cmd = new OleDbCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}