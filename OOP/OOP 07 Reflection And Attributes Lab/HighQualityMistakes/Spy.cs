using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
     public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            Type investigatedClass = Type.GetType(className);
            StringBuilder sb = new StringBuilder();
            if (investigatedClass != null)
            {
                var wrongFields = investigatedClass.GetFields().Where(x => !x.IsPrivate).ToArray();
                var wrongGetters = investigatedClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static).Where(x => x.Name.StartsWith("get"));
                var wrongSetters = investigatedClass.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(x => x.Name.StartsWith("set"));
                foreach (var field in wrongFields)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
                foreach (var method in wrongGetters)
                {
                    sb.AppendLine($"{method.Name} have to be public!");
                }
                foreach (var method in wrongSetters)
                {
                    sb.AppendLine($"{method.Name} have to be private!");

                }
               
            }
            return sb.ToString().TrimEnd();
        }
        

    }
}
