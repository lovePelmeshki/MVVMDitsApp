using MVVMDitsApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MVVMDitsApp.ViewModels
{
    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _Customer = new Customer("Alex");
        }

        private Customer _Customer;
        public Customer Customer
        {
            get => _Customer;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated", Customer.Name));
        }

    }
}
