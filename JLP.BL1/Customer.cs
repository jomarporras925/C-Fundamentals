﻿using System;

namespace JLP.BL1
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, { FirstName}";
            }
        }

    }
}
