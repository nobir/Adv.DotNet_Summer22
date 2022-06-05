using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class ValidateDob : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if(DateTime.Now.Year - Convert.ToDateTime(value).Year > 18)
                {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult("Age must be greter than 18 years old");
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " is required");
            }
        }
    }
}