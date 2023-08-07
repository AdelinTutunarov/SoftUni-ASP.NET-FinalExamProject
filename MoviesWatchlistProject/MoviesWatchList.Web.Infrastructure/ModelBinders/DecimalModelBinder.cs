using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace MoviesWatchList.Web.Infrastructure.ModelBinders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if(bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if(valueResult != ValueProviderResult.None && !string.IsNullOrEmpty(valueResult.FirstValue))
            {
                decimal parcedValue = 0m;
                bool success = false;

                try
                {
                    string formDecValue = valueResult.FirstValue;
                    formDecValue = formDecValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    formDecValue = formDecValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    parcedValue = Convert.ToDecimal(formDecValue);
                    success = true;
                }
                catch(FormatException fe)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, fe, bindingContext.ModelMetadata);
                }

                if (success)
                {
                    bindingContext.Result = ModelBindingResult.Success(parcedValue);
                }
            }

            return Task.CompletedTask;
        }
    }
}
