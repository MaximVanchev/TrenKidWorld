using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace TrenKidWorld.ModelBinders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueResult != ValueProviderResult.None && !String.IsNullOrEmpty(valueResult.FirstValue))
            {
                decimal actualValue = 0;
                bool success = false;

                try
                {
                    string decValue = valueResult.FirstValue;
                    decValue = decValue.Replace("." , CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    decValue = decValue.Replace("," , CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    actualValue = Convert.ToDecimal(decValue);
                    success = true;
                }
                catch (FormatException fe)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, fe, bindingContext.ModelMetadata);
                }

                if (success)
                {
                    bindingContext.Result = ModelBindingResult.Success(actualValue);
                }
            }

            return Task.CompletedTask;
        }
    }
}
