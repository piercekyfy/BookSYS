﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class Client
    {
        public int? ClientId { get; set; } = null;
        public string Name { get; set; }
        private const int _nameMaxLength = 64;
        public string Street { get; set; }
        private const int _streetMaxLength = 48;
        public string City { get; set; }
        private const int _cityMaxLength = 48;
        public string County { get; set;}
        private const int _countyMaxLength = 12;
        public string Eircode { get; set; }
        public string Email { get; set; }
        private const int _emailMaxLength = 48;
        public string Phone { get; set; }
        public char Status { get; set; }

        public Client()
        {

        }

        public Client(int id, string name, string street, string city, string county, string eircode, string email, string phone)
        {
            ClientId = id;
            Name = name;
            Street = street;
            City = city;
            County = county;
            Eircode = eircode;
            Email = email;
            Phone = phone;
            Status = 'O';
        }

        public Client(string name, string street, string city, string county, string eircode, string email, string phone)
        {
            Name = name;
            Street = street;
            City = city;
            County = county;
            Eircode = eircode;
            Email = email;
            Phone = phone;
            Status = 'O';
        }

        public static bool Validate(Client client, out string invalidProperty, out string error)
        {
            #region Null Checks

            if (String.IsNullOrEmpty(client.Name))
            {
                invalidProperty = nameof(Name);
                error = "Name is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.Street))
            {
                invalidProperty = nameof(Street);
                error = "Street is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.City))
            {
                invalidProperty = nameof(City);
                error = "City is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.County))
            {
                invalidProperty = nameof(County);
                error = "County is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.Eircode))
            {
                invalidProperty = nameof(Eircode);
                error = "Eircode is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.Email))
            {
                invalidProperty = nameof(Email);
                error = "Email is a required field.";
                return false;
            }

            if (String.IsNullOrEmpty(client.Phone))
            {
                invalidProperty = nameof(Phone);
                error = "Phone is a required field.";
                return false;
            }

            #endregion

            #region Name
            invalidProperty = nameof(Name);

            if (client.Name.Length > _nameMaxLength)
            {
                error = $"Name has a maximum length of {_nameMaxLength} characters.";
                return false;
            }

            #endregion

            #region Street 
            invalidProperty = nameof(Street);

            if (client.Street.Length > _streetMaxLength)
            {
                error = $"Street has a maximum length of {_streetMaxLength} characters.";
                return false;
            }

            #endregion

            #region City 
            invalidProperty = nameof(City);

            if (client.City.Length > _cityMaxLength)
            {
                error = $"City has a maximum length of {_cityMaxLength} characters.";
                return false;
            }

            #endregion

            #region County
            invalidProperty = nameof(County);

            if (client.County.Length > _countyMaxLength)
            {
                error = $"City has a maximum length of {_countyMaxLength} characters.";
                return false;
            }

            #endregion

            #region Eircode
            invalidProperty = nameof(Eircode);

            if (client.Eircode.Length != 7)
            {
                error = "Eircode must be 7 characters long.";
                return false;
            }

            #endregion

            #region Email
            invalidProperty = nameof(Email);

            if (client.Email.Length > _emailMaxLength)
            {
                error = $"Email has a maximum length of {_emailMaxLength} characters.";
                return false;
            }

            if (!Regex.Match(client.Email, @"([a-zA-Z][^ \n() *]*@[^ \n,@% *0-9]*)").Success)
            {
                error = "Invalid Email entered.";
                return false;
            }

            #endregion

            #region Phone
            invalidProperty = nameof(Phone);

            if (client.Phone.Length != 9)
            {
                error = "Phone number must be 9 characters long.";
                return false;
            }

            foreach (char c in client.Phone)
            {
                if (!char.IsDigit(c))
                {
                    error = "Phone must be a number.";
                    return false;
                }
            }

            #endregion

            #region Status
            invalidProperty = nameof(Email);

            if (client.Status != 'O' && client.Status != 'C')
            {
                error = "Client Status must be 'O' or 'C'";
                return false;
            }

            #endregion

            invalidProperty = null;
            error = null;
            return true;
        }

        public override string ToString()
        {
            return this.ClientId.ToString() + " (" + this.Name.ToString() + ")";
        }
    }
}
