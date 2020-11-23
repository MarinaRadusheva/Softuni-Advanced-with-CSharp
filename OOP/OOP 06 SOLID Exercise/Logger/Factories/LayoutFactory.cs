using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using Logger.Common;

namespace Logger.Factories
{
    public class LayoutFactory 
    {
        public LayoutFactory()
        {

        }
        public ILayout CreateLayout(string layoutTypeInput)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type layoutType = assembly.GetTypes().FirstOrDefault(x => x.Name.Equals(layoutTypeInput, StringComparison.InvariantCultureIgnoreCase));
            if (layoutType==null)
            {
                throw new InvalidOperationException(GlobalConstants.INVALID_INPUT);
            }
            object[] ctorArgs = new object[] { };
            ILayout layout = (ILayout)Activator.CreateInstance(layoutType, ctorArgs);
            return layout;
        }
    }
}
