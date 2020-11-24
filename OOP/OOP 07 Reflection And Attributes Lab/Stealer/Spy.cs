using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
     public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            Type investigatedType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.FullName == className);
            var someObject = Activator.CreateInstance(investigatedType);
            var allFields = investigatedType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            var matchingFields = allFields.Where(x => fieldsNames.Contains(x.Name));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {className}");
            foreach (var field in matchingFields)
            {
                sb.AppendLine($"{ field.Name} = { field.GetValue(someObject)}");
            }
            return sb.ToString().TrimEnd();
            // Class under investigation: Stealer.Hacker
            //username = securityGod82
            //password = mySuperSecretPassw0rd
        }

    }
}
