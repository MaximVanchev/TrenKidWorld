using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenKidWorld.Core.CustomAttributes
{
    public class IsBeforeAttribute : ValidationAttribute
    {
        private readonly string propToCompare;

        public IsBeforeAttribute(string _propToCompare , string errorMessage = "")
        {
            propToCompare = _propToCompare;
            this.ErrorMessage = errorMessage;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                DateTime dateToCompare = (DateTime)validationContext.ObjectType.GetProperty(propToCompare).GetValue(validationContext.ObjectInstance);

                if ((DateTime)value < dateToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            catch (Exception)
            {}

            return new ValidationResult(ErrorMessage);
        }
    }
}
