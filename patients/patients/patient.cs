using System;
using System.Collections.Generic;
using System.Text;

namespace patients
{
    /// <summary>
    /// Patient class is a blueprint for create person objects and to record their relevant information
    /// </summary>
    class patient
    {
        //Class fields
        private string _fullName;
        private string _mobile;
        private string _addressStreet;
        private string _addressCity;

        /// <summary>
        /// Constructor, initializes class fields
        /// </summary>
        /// <param name="fullName">Stores patients full name</param>
        /// <param name="mobile">Stores patients mobile number</param>
        /// <param name="addressStreet">Stores patients street address</param>
        /// <param name="addressCity">Stores patients city address</param>
        public patient(string fullName, string mobile, string addressStreet, string addressCity)
        {
            _fullName = fullName;
            _mobile = mobile;
            _addressStreet = addressStreet;
            _addressCity = addressCity;
        }

        /// <summary>
        /// Getter and setter methods for clients full name
        /// </summary>
        public string FullName { get => _fullName; set => _fullName = value; }
        /// <summary>
        /// Getter and setter methods for clients mobile
        /// </summary>
        public string Mobile { get => _mobile; set => _mobile = value; }
        /// <summary>
        /// Getter and setter methods for clients street address
        /// </summary>
        public string Street { get => _addressStreet; set => _addressStreet = value; }
        /// <summary>
        /// Getter and setter methods for clients city address
        /// </summary>
        public string City { get => _addressCity; set => _addressCity = value; }
    }
}
