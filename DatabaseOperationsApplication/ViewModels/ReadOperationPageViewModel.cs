using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperationsRepository.DatabaseOperations;

namespace DatabaseOperationsApplication.ViewModels
{
    internal class ReadOperationPageViewModel
    {
        internal void ReadCustomer(string customerIdentification)
        {
            SqlCustomerOperations operations = new SqlCustomerOperations();
            operations.SelectCustomer(customerIdentification);
        }

     
    }
}
