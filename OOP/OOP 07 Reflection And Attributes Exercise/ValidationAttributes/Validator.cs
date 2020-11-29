using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            bool isValid = true;
            var props = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in props)
            {
                var attributes = property.GetCustomAttributes().Where(x=>x is MyValidationAttribute);
                foreach (var attr in attributes)
                {
                    isValid = (attr as MyValidationAttribute).IsValid(property.GetValue(obj));
                    if(!isValid)
                    {
                        return isValid;
                    }
                }
            }
            return isValid;
        }
    }
}
