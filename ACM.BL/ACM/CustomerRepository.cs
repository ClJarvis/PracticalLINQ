using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            foreach (var c in customerList)
            {
                if (c.CustomerId == customerId)
                {
                    foundCustomer = c;
                    break;
                }
            }
            return foundCustomer;
        }
        public List<Customer> Retrieve()
        {
            return null; //stopped here
        }
    }
}
