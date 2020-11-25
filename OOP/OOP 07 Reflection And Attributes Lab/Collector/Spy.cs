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
            Type investigatedType = Type.GetType(className);
            var allMethods = investigatedType.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (var method in allMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in allMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{ method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            
            return sb.ToString().TrimEnd();
        }
        

    }
}
