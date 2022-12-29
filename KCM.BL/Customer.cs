using K.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCM.BL
{
    public class Customer : EntityBase, ILoggable
    {
      
        public Customer() : this(0)
        {
            
        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressesList = new List<Address>();
        }
        public List<Address> AddressesList { get; set; }
        public int CustomerID { get; set; }
        public int CutomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if(!string.IsNullOrWhiteSpace(LastName)) {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName+= LastName;
                
                }
                return fullName;

            }
        }
        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {

                return _lastName;

            }
            set
            {
                _lastName = value;
            }



        }


        //public string Log()
        //{
        //    var logstring = CustomerID + ": " + FullName + " " +
        //        "Email: " + EmailAddress + " " + "Status: " + EntityState.ToString();

        //    return logstring;
        //}
        public string Log() => $"{CustomerID}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        //public bool Save()
        //{
        //    return true;
        //}
        //public Customer Retrieve(int customerID)
        //{
        //    return new Customer();
        //}
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}
        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
   
    }
}