using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Microsoft.Ajax.Utilities;
using System.Data;

namespace Imdb
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fg66xu\\Onedrive - NN\\desktop\\IMDB\\Imdb\\Imdb\\App_Data\\Imdbdb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
 
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Registerbtn_Click(Object sender, EventArgs e)
        {
            Button clickedbtn = (Button)sender;
            if (!string.IsNullOrEmpty(usernameid.Text) && !string.IsNullOrEmpty(emailid.Text) && !string.IsNullOrEmpty(pwid.Text) && !string.IsNullOrEmpty(rpwid.Text))
            {
                allow_registration(usernameid.Text, emailid.Text, pwid.Text, rpwid.Text);
            }
            else
            {
                information.Text = "You have to fill all fields!";
            }
        }
        protected void allow_registration(string username,string email,string password, string rpassword)
        {
            string columnUserName = "UserName";
            string columnEmail = "Email";
            try
            {
                check_password(password, rpassword);
                find_record(columnUserName, username);
                find_record(columnEmail, email);
                add_record();
                information.Text = "Registration successfull";
            }
            catch
            {
                pwid.Text = "";
                rpwid.Text = "";
            }
        }
        protected void add_record()
        {
            string ins = "Insert into [UserTable](UserName, Email, Password, Role, Posts, Assessments) values ('" + usernameid.Text + "', '" + emailid.Text + "', '" + pwid.Text + "','" + 1 + "', '" + 0 + "', '" + 0 + "')";
            SqlCommand com = new SqlCommand(ins, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void find_record(string columnName, string inputValue)
        {
            string ins = String.Format("SELECT * FROM [UserTable] WHERE {0}='{1}'", columnName, inputValue);
            SqlCommand com = new SqlCommand(ins, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    error_mess(inputValue);
                    throw new Exception();
                }
            }
        }
        protected void error_mess()
        {
            if(pwid.Text.Length < 7)
            {
                information.Text = String.Format("Password needs to have more then 8 characters!");
            }
            else
            {
                information.Text = String.Format("Password and confirmed password is not matching!");
            }

        }
        public void error_mess(string input)
        {
            information.Text = String.Format("{0} is already in use!", input);
        }

        protected void check_password(string password, string rpassword)
        {
            if(pwid.Text.Length < 7)
            {
                error_mess();
                throw new Exception();
            }
            else
            {
                if(password != rpassword)
                {
                    error_mess();
                    throw new Exception();
                }
            }
        }
    }

}