using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imdb
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fg66xu\\Onedrive - NN\\desktop\\IMDB\\Imdb\\Imdb\\App_Data\\Imdbdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        string columnUserName = "UserName";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            Button clickedbtn = (Button)sender;
            try
            {
                check_pw(pw.Text);
                clickedbtn.Text = "Done!";
            }
            catch
            {
                pw.Text = "";
                clickedbtn.Text = "Not done!";
            }
        }
        protected void check_pw(string pw)
        {
            string columnPw = "Password";
            string ins = String.Format("SELECT * FROM [UserTable] WHERE {0}='{1}'", columnUserName, userName.Text);
            SqlCommand com = new SqlCommand(ins, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][3] != pw)
                error_mess();
                throw new Exception();
            else
            {
                information.Text = "Login successfull";
            }

        }
        protected void error_mess()
        {
            information.Text = "Username or password are wrong!";
        }
    }
}