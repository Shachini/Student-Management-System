using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace StudentManagementSystem
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DTC;Initial Catalog=School;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                string sql = "SELECT StudentId, StudentName, City, CourseId FROM Student";
                SqlCommand command = new SqlCommand(sql, cnn);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    GridView1.DataSource = dataReader;
                    GridView1.DataBind();
                }
                cnn.Close();
            }
        }
    }
}
