﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TrenKidWorld.ModelBinders
{
    public class DateTimeModelBinderProvider : IModelBinderProvider
    {
        private readonly string dateFormat;

        public DateTimeModelBinderProvider(string _dateFormat)
        {
                dateFormat = _dateFormat;
        }

        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(DateTime) || context.Metadata.ModelType == typeof(DateTime?)) 
            {
                return new DateTimeModelBinder(dateFormat);
            }

            return null;
        }
    }
}
