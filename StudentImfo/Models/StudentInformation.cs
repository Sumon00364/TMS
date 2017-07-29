using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentImfo.Models
{
    public class StudentInformation
    {
        public string Name { get; set; }
        public  string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string Dropdown1 { get; set; }
        public string DropDown2 { get; set; }
        public string Address { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}