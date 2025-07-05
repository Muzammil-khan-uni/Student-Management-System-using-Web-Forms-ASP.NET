using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StudentCRUDApp
{
    public partial class _Default : Page
    {
        private string connectionString = "Data Source=DESKTOP-THLGAI4\\SQLEXPRESS;Initial Catalog=Studentweb;Integrated Security=True"; // Replace with your database connection string

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students ORDER BY StudentId ASC", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridViewStudents.DataSource = dt;
                GridViewStudents.DataBind();
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Students WHERE StudentId = @Id", conn);
                checkCmd.Parameters.AddWithValue("@Id", TxtStudentId.Text);
                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    LblMessage.Text = "Error: A student with this ID already exists.";
                    LblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Students (StudentId, StudentName, RollNo, Email, Age) VALUES (@Id, @Name, @RollNo, @Email, @Age)", conn);
                cmd.Parameters.AddWithValue("@Id", TxtStudentId.Text);
                cmd.Parameters.AddWithValue("@Name", TxtStudentName.Text);
                cmd.Parameters.AddWithValue("@RollNo", TxtStudentRollNo.Text);
                cmd.Parameters.AddWithValue("@Email", TxtStudentEmail.Text);
                cmd.Parameters.AddWithValue("@Age", TxtStudentAge.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LblMessage.Text = "Record added successfully.";
                LblMessage.ForeColor = System.Drawing.Color.Green;
            }
            LoadStudents();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Students SET StudentName = @Name, RollNo = @RollNo, Email = @Email, Age = @Age WHERE StudentId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", TxtStudentId.Text);
                cmd.Parameters.AddWithValue("@Name", TxtStudentName.Text);
                cmd.Parameters.AddWithValue("@RollNo", TxtStudentRollNo.Text);
                cmd.Parameters.AddWithValue("@Email", TxtStudentEmail.Text);
                cmd.Parameters.AddWithValue("@Age", TxtStudentAge.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LblMessage.Text = "Record updated successfully.";
                LblMessage.ForeColor = System.Drawing.Color.Green;
            }
            LoadStudents();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", TxtStudentId.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LblMessage.Text = "Record deleted successfully.";
                LblMessage.ForeColor = System.Drawing.Color.Green;
            }
            LoadStudents();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE StudentId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", TxtStudentId.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    TxtStudentName.Text = row["StudentName"].ToString();
                    TxtStudentRollNo.Text = row["RollNo"].ToString();
                    TxtStudentEmail.Text = row["Email"].ToString();
                    TxtStudentAge.Text = row["Age"].ToString();
                    LblMessage.Text = "Record found.";
                    LblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    ClearFields();
                    LblMessage.Text = "No record found with this ID.";
                    LblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            TxtStudentId.Text = "";
            TxtStudentName.Text = "";
            TxtStudentRollNo.Text = "";
            TxtStudentEmail.Text = "";
            TxtStudentAge.Text = "";
            LblMessage.Text = "";
        }
    }
}