using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            var allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static);
            foreach (var method in allMethods)
            {
                if (method.CustomAttributes.Any(n=>n.AttributeType==typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attr in attributes)
                    {
                        Console.WriteLine("{0} is written by {1}", method.Name, attr.Name);
                    }
                }
            }
        }
    }
}
