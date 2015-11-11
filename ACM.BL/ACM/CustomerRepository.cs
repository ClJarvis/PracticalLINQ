﻿using System;
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

            /*   foreach (var c in customerList)
               {
                   if (c.CustomerId == customerId)
                   {
                       foundCustomer = c;
                       break;
                   }
               } */

            /*    var query = from c in customerList
                           where c.CustomerId == customerId
                           select c;
                foundCustomer = query.First();

        */
              foundCustomer = customerList.FirstOrDefault( c =>
                                       c.CustomerId == customerId);           
/*
            foundCustomer = customerList.Where(c =>
                            c.CustomerId == customerId)
                            .Skip(1)
                            .FirstOrDefault();                       
    */            
            return foundCustomer;
        }
        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }

        public dynamic GetNamesandEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
            {
                Name = c.LastName + ", " + c.FirstName,
                c.EmailAddress
            });
            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ":" + item.EmailAddress);
            }
            return query;
        }

        public dynamic GetNamesAndType(List<Customer> customerList,
                                List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                                c => c.CustomerTypeId,
                                ct => ct.CustomerTypeId,
                                (c, ct) => new
                                {
                                    Name = c.LastName + ", " + c.FirstName,
                                    CustomerTypeName = ct.TypeName
                                });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }

            return query;
        }


        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Frodo",
                            LastName = "Baggins",
                            EmailAddress = "fb@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Bilbo",
                            LastName = "Baggins",
                            EmailAddress = "bb@hob.me",
                            CustomerTypeId=null},
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Samwise",
                            LastName = "Gamgee",
                            EmailAddress = "sg@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 4,
                            FirstName="Rosie",
                            LastName = "Cotton",
                            EmailAddress = "rc@hob.me",
                            CustomerTypeId=2}};
            return custList;
        }

        public object GetNamesAndType(List<Customer> customerList, object customerTypeList)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
            {
           // return customerList.OrderByDescending(c => c.LastName)
             //     .ThenByDescending(c => c.FirstName);

            return SortByName(customerList).Reverse();
            }
        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                .ThenBy(c=>c.CustomerTypeId);
               
        }
    }
}

