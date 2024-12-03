using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SuccessLabel.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int courseId;
            String courseName;
            String lecturerName;

            // Validate Course Id 
            if (!int.TryParse(TextBox1.Text.Trim(), out courseId) || courseId <= 0)
            {
                SuccessLabel.Text = "Invalid Course ID. Please enter a valid positive number.";
                SuccessLabel.ForeColor = System.Drawing.Color.Red;
                SuccessLabel.Visible = true;
                return;
            }

            // Assign values from text boxes
            courseName = TextBox2.Text.Trim();
            lecturerName = TextBox3.Text.Trim();


            // Database connection string
            string connectionString = @"Data Source=DTC;Initial Catalog=School;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlTransaction transaction = cnn.BeginTransaction();

                try
                {
                    //Check whether Student Id already exists
                    string checkQuery = "SELECT COUNT(*) FROM Course WHERE CourseId = @CourseId";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, cnn, transaction))
                    {
                        checkCommand.Parameters.AddWithValue("@CourseId", courseId);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            SuccessLabel.Text = "Course is already registered!";
                            SuccessLabel.ForeColor = System.Drawing.Color.Red;
                            SuccessLabel.Visible = true;
                            transaction.Rollback();
                            return;
                        }
                    }

                    //  Insert the new course
                    string insertQuery = "INSERT INTO Course(CourseId, CourseName, LecturerName) VALUES(@CourseId, @CourseName, @LecturerName)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, cnn, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@CourseId", courseId);
                        insertCommand.Parameters.AddWithValue("@CourseName", courseName);
                        insertCommand.Parameters.AddWithValue("@LecturerName", lecturerName);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            transaction.Commit();
                            SuccessLabel.Text = "Registration is successful.";
                            SuccessLabel.ForeColor = System.Drawing.Color.Green;
                            SuccessLabel.Visible = true;
                        }
                        else
                        {
                            SuccessLabel.Text = "Registration failed. Please try again.";
                            SuccessLabel.ForeColor = System.Drawing.Color.Red;
                            SuccessLabel.Visible = true;
                            transaction.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // on any error
                    SuccessLabel.Text = "An unexpected error occurred. Please try again.";
                    SuccessLabel.ForeColor = System.Drawing.Color.Red;
                    SuccessLabel.Visible = true;

                    System.Diagnostics.Debug.WriteLine($"ERROR: {ex.Message}");
                }
            }

        }
    }
}