using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Student
    {
        [Required, RegularExpression(@"^([0-9]{2}-[0-9]{5}-[1-3]{1})+$", ErrorMessage = "Id must be xx-xxxxx-x this format")]
        public string Id { get; set; }

        [Required, RegularExpression(@"^([a-zA-Z\s]+)$", ErrorMessage = "Name must be alphabatic")]
        public string Name { get; set; }

        [Required, ValidateDob]
        public DateTime Dob { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, RegularExpression(@"^((male)|(female)|(other))+$")]
        public string Gender { get; set; }

        [Required, RegularExpression(@"^((cs)|(eee))+$")]
        public string Dept { get; set; }
    }
}