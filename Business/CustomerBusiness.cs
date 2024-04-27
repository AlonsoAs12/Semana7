using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CustomerBusiness
    {
        private readonly Data.CustomerData customerData;

        public CustomerBusiness(string connectionString)
        {
            customerData = new Data.CustomerData(connectionString);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerData.GetCustomers();
        }

        public Customer GetCustomerById(int customerId)
        {
            return customerData.GetCustomerById(customerId);
        }

        public void AddCustomer(Customer customer)
        {
            customerData.AddCustomer(customer
