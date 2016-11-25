using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentalsOOP
{
    public class Customer
    {
        public Customer()
        {
            MyInstanceCount += 1;
        }

        #region property lastName
        //defining properties
        private string _lastName;

        //public-any code could access and modify 
        //internal-access within classes in the component
        public String LastName {
            get
            {
                //any code here
                return _lastName;
            }

            set
            {
                //any code here-assigns the value to the backend field
                _lastName = value;
            }
        }
        #endregion

        #region property firstName
        public String FirstName { get; set; }
        #endregion

        public String EmailAdress { get; set; }

        public int CustomerId { get; set; }

        public String FullName
        {
            get {
                String fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }

        }

        public static int MyInstanceCount { get; set; }

        public Decimal? Money { get; set; }

        public bool Validate()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(FullName)) result = false;
            if (string.IsNullOrWhiteSpace(LastName)) result = false;

            return result;
        }

        /// <summary>
        /// overrides object method toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " - " + LastName;
        }

    }
}
