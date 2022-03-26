using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LocalDB_assign
{
    public static class CustomerDB
    {
        public static Customer GetCustomer(int customerID)
        {
            Customer customer = null; // default return value
            string selectStatement =
                "SELECT CustomerID, CompanyName, ContactName, Phone " +
                "FROM Customers " +
                "WHERE CustomerID = @CustomerID";
            using SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                customer = new Customer
                {
                    CustomerID = (int)reader["CustomerID"],
                    CompanyName = reader["CompanyName"].ToString(),
                    ContactName = reader["ContactName"].ToString(),
                    Phone = reader["Phone"].ToString()
                };
            }
            return customer;
        }
    }
}
