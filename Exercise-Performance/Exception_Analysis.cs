using System.Data.SqlClient;
using Exercise_Performance.Help;

namespace Exercise_Performance
{
    public class Exception_Analysis
    {
        public static void ExecuteSqlCommand()
        {
            string sqlServerName = "TF-198033363952\\SQLEXPRESS";
            string databaseName = "GHC-Workshop";
            string tableName = "Course";

            string connectionString = $"Server={sqlServerName};Database={databaseName};Trusted_Connection=True;";

            Course courseToSave = new Course()
            {
                Amount = 1500,
                DepartmentId = Guid.NewGuid(),
                EndDate = DateTime.Now.AddMonths(6),
                Id = Guid.NewGuid(),
                Lecturer = Guid.NewGuid(),
                Name = "Very long course name which is definitely exceeding lenght limit.",
                StartDate = DateTime.Now
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"INSERT INTO {tableName} (Id, DepartmentId, Lecturer, Name, Amount, StartDate, EndDate) VALUES (@Id, @DepartmentId, @Lecturer, @Name, @Amount, @StartDate, @EndDate)";

                    command.Parameters.AddWithValue("@Id", courseToSave.Id);
                    command.Parameters.AddWithValue("@DepartmentId", courseToSave.DepartmentId);
                    command.Parameters.AddWithValue("@Lecturer", courseToSave.Lecturer);
                    command.Parameters.AddWithValue("@Name", courseToSave.Name);
                    command.Parameters.AddWithValue("@Amount", courseToSave.Amount);
                    command.Parameters.AddWithValue("@StartDate", courseToSave.StartDate);
                    command.Parameters.AddWithValue("@EndDate", courseToSave.EndDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
