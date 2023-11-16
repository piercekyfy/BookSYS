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
            if (client.Id < 0)
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
            #region Street 
            if (String.IsNullOrEmpty(client.Street))
            {
                errorMessage = "Street is a required field.";
                return false;
            }
            if(client.Street.Length > 24)
            {
                errorMessage = "Street has a maximum length of 24 characters.";
                return false;
            }
            #endregion
            #region City 
            if (String.IsNullOrEmpty(client.City))
            {
                errorMessage = "City is a required field.";
                return false;
            }
            if (client.City.Length > 24)
            {
                errorMessage = "City has a maximum length of 24 characters.";
                return false;
            }
            #endregion
            #region County
            if (String.IsNullOrEmpty(client.County))
            {
                errorMessage = "City is a required field.";
                return false;
            }
            if (client.County.Length > 12)
            {
                errorMessage = "City has a maximum length of 12 characters.";
                return false;
            }
            #endregion
            #region Eircode
            if (String.IsNullOrEmpty(client.Eircode))
            {
                errorMessage = "Eircode is a required field.";
                return false;
            }
            if (client.Eircode.Length != 7)
            {
                errorMessage = "Eircode must be 7 characters long.";
                return false;
            }
            #endregion
            #region Email
            if (String.IsNullOrEmpty(client.Email))
            {
                errorMessage = "Eircode is a required field.";
                return false;
            }
            if (client.Email.Length > 32)
            {
                errorMessage = "Email has a maximum length of 32 characters.";
                return false;
            }
            // ([a-zA-Z][^ \n()*]*@[^ \n,@%*0-9]*)
            // wip regex ^
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
