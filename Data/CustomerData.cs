using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();

        using (SqlConnection connection = new SqlConnection("LAB1504-31"))
        {
            SqlCommand command = new SqlCommand("GetCustomersProc", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer
                {
                    CustomerId = (int)reader["customer_id"],
                    Name = reader["name"].ToString(),
                    Address = reader["address"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Active = (bool)reader["active"]
                };
                customers.Add(customer);
            }
        }

        return customers;
    }
}