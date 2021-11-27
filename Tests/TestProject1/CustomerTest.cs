using JLP.BL1;
using System;
using Xunit;

namespace TestProject1
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);

        }
    }
}
