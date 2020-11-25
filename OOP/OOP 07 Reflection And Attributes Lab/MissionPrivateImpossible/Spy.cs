using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
     public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            Type investigatedType = Type.GetType(className);
            var privateMethods = investigatedType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}{Environment.NewLine}Base Class: {investigatedType.BaseType.Name}");
            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().TrimEnd();
        }
        

    }
}
