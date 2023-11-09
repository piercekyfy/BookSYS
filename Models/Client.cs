using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set;}
        public string Eircode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Client()
        {

        }

        public Client(int id, string name, string street, string city, string county, string eircode, string email, string phone)
        {
            Id = id;
            Name = name;
            Street = street;
            City = city;
            County = county;
            Eircode = eircode;
            Email = email;
            Phone = phone;
        }

        public static bool VerifyClient(Client client, out string errorMessage)
        {
            #region ClientId
            if(client.Id < 0)
            {
                errorMessage = "Id cannot be less than zero.";
                return false;
            }
            if (client.Id > 9999)
            {
                errorMessage = "Id cannot be larger than 9999.";
                return false;
            }
            #endregion
            #region Name
            if (String.IsNullOrEmpty(client.Name))
            {
                errorMessage = "Name is a required field.";
                return false;
            }
            if (client.Name.Length > 48)
            {
                errorMessage = "Name has a maximum length of 48 characters.";
                return false;
            }
            #endregion

            errorMessage = null;
            return true;
        }

        public override string ToString()
        {
            return this.Id.ToString() + " (" + this.Name.ToString() + ")";
        }
    }
}
