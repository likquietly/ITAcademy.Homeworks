using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW._09._10.Checkin
{
    class ValidationHelper
    {
        private protected bool Validation(ValidationContext context, string user)
        {
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(user, context, results))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}