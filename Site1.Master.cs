using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Students.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Course.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Details.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name;
            String email;
            String telephoneNumber;
            String comment;

            name = TextBox1.Text;
            email = TextBox2.Text;
            telephoneNumber = TextBox3.Text;
            comment = TextBox4.Text;

            String connectionString;
            SqlConnection cnn;

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            connectionString = @"Data Source=DTC;Initial Catalog=School;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            sql = "INSERT INTO Comment(UserName,Email,TelephoneNumber,Comment) VALUES('" + name + "','" + email + "','" + telephoneNumber + "','" + comment + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

            // Clear the form fields
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

    }
}