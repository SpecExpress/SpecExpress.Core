using System;
using System.Collections.Generic;
using System.Text;

namespace SpecExpress.Core
{
    internal class SpecificationContainer
    {
        static SpecificationContainer _instance;

        IServiceProvider serviceProvider;

        private SpecificationContainer() { }

        public 

        public static SpecificationContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new ApplicationException("Must Builde Specification Container first!");
                }
                return _instance;
            }
        }

        
    }
}
