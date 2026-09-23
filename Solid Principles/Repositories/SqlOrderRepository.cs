using System.Data.SqlClient;
using Solid_Principles.Models;

namespace Solid_Principles.Repositories
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly string connectionString;

        public SqlOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Save(Order order)
        {
            using (SqlConnection conn =
                   new SqlConnection(connectionString))
            {
                conn.Open();

                string sql =
                    "INSERT INTO Orders (Email, Total) " +
                    "VALUES (@email, @total)";

                using (SqlCommand cmd =
                       new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@email", order.Email);

                    cmd.Parameters.AddWithValue(
                        "@total", order.Total);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}