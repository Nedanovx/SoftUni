using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties().Where(x => x.CustomAttributes
            .Any(y => typeof(MyValidationAttribute).IsAssignableFrom(y.AttributeType))).ToArray();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
              IEnumerable<MyValidationAttribute> attributes = propertyInfo
                    .GetCustomAttributes(typeof(MyValidationAttribute), true).Cast<MyValidationAttribute>();

                foreach(MyValidationAttribute attribute in attributes)
                {
                    if(!attribute.IsValid(propertyInfo.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

          
            return true;
        }
    }
}
