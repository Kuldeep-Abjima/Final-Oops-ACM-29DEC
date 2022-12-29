using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId) {

            Address address = new Address(addressId);




                  if (addressId == 1)
            {
                    address.AddressType = 1;
                    address.StreetLine1 = "bell tower";
                    address.StreetLine = "baker's Street";
                    address.city = "LA";
                    address.State = "USA";
                    address.Country = "America";
                    address.PostalCode= "144";
            }
                  return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId){ 
        
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "bag End",
                StreetLine = "Bagshot row",
                city = "hobbiton",
                State = "shire",
                Country = "Middle earth",
                PostalCode = "144"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                city = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);
        
            return addressList;
        
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
