using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKParliament.CodeTest.Data
{
    public class Person
    {

        /// Change Log:
        /// simonjpearson | 06 Nov, 2021 | Modified to include additional properties
        public int Id { get; set; }

        public string Name { get; set; }

        // simonjpearson 06 Nov, 2021: All fields below added as part of interview demo.
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        public string Street { get; set; }

        [Display(Name = "Post Town")]
        public string PostTown { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    }
}