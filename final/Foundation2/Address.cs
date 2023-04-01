using System;

namespace ProductOrderingSystem
{
    public class Address
    {
        // Private member variables for the address fields
        private string streetAddress;
        private string city;
        private string stateOrProvince;
        private string country;

        // Constructor to initialize the address fields
        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        // Getter method to retrieve the street address
        public string GetStreetAddress()
        {
            return streetAddress;
        }

        // Setter method to set the street address
        public void SetStreetAddress(string streetAddress)
        {
            this.streetAddress = streetAddress;
        }

        // Getter method to retrieve the city
        public string GetCity()
        {
            return city;
        }

        // Setter method to set the city
        public void SetCity(string city)
        {
            this.city = city;
        }

        // Getter method to retrieve the state/province
        public string GetStateOrProvince()
        {
            return stateOrProvince;
        }

        // Setter method to set the state/province
        public void SetStateOrProvince(string stateOrProvince)
        {
            this.stateOrProvince = stateOrProvince;
        }

        // Getter method to retrieve the country
        public string GetCountry()
        {
            return country;
        }

        // Setter method to set the country
        public void SetCountry(string country)
        {
            this.country = country;
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToLower() == "usa" || country.ToLower() == "united states" || country.ToLower() == "united states of america";
        }

        // Method to return the full address as a string
        public string GetFullAddress()
        {
            return streetAddress + "\n" + city + ", " + stateOrProvince + "\n" + country;
        }
    }
}
