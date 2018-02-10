using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace UI.RichClient
{
    public partial class Login : Form
    {
        /////////////////////////////////////////////////////////////////////////// FORM SETUP
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
        /////////////////////////////////////////////////////////////////////////// BUTTONS
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This username and password are provided to you by a developer in beta, or by purchasing a key from the website");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = DATABASEURL; Initial Catalog = TsLsSqlDb; Persist Security Info = True; User ID = USERNAME; Password = PASSWORD;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username= '" + Username.Text + "' and Password = '" + Password.Text + "' ",connection);
            DataTable data = new DataTable();
            sda.Fill(data);
            //uncomment these lines for product release
            if (data.Rows[0][0].ToString() == "1")
            //if (true)
            {
                Hub main = new Hub();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please insert a valid username and password");
            }
            
        }
        /////////////////////////////////////////////////////////////////////////// LABEL CLICKED
        private void ShowPassword(object sender, EventArgs e)
        {
            if (HidePass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }

        }
    }
}
