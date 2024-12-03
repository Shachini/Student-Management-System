using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace StudentManagementSystem
{
    public partial class Stuents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Hide message label
            SuccessLabel.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int studentId;
            string studentName;
            string city;
            int courseId;

            // Validate Student Id 
            if (!int.TryParse(TextBox1.Text.Trim(), out studentId) || studentId <= 0)
            {
                SuccessLabel.Text = "Invalid Student ID. Please enter a valid positive number.";
                SuccessLabel.ForeColor = System.Drawing.Color.Red;
                SuccessLabel.Visible = true;
                return;
            }

            // Assign values from text boxes
            studentName = TextBox2.Text.Trim();
            city = TextBox3.Text.Trim();

            // Validate Course Id input
            if (!int.TryParse(TextBox4.Text.Trim(), out courseId) || courseId <= 0)
            {
                SuccessLabel.Text = "Invalid Course ID. Please enter a valid positive number.";
                SuccessLabel.ForeColor = System.Drawing.Color.Red;
                SuccessLabel.Visible = true;
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=DTC;Initial Catalog=School;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlTransaction transaction = cnn.BeginTransaction();

                try
                {
                    //Check whether Student Id already exists
                    string checkQuery = "SELECT COUNT(*) FROM Student WHERE StudentId = @StudentId";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, cnn, transaction))
                    {
                        checkCommand.Parameters.AddWithValue("@StudentId", studentId);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            SuccessLabel.Text = "Student is already registered!";
                            SuccessLabel.ForeColor = System.Drawing.Color.Red;
                            SuccessLabel.Visible = true;
                            transaction.Rollback(); 
                            return;
                        }
                    }

                    //  Insert the new student
                    string insertQuery = "INSERT INTO Student(StudentId, StudentName, City, CourseId) VALUES(@StudentId, @StudentName, @City, @CourseId)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, cnn, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@StudentId", studentId);
                        insertCommand.Parameters.AddWithValue("@StudentName", studentName);
                        insertCommand.Parameters.AddWithValue("@City", city);
                        insertCommand.Parameters.AddWithValue("@CourseId", courseId);

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
