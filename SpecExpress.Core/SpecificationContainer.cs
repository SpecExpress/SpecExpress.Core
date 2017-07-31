using SpecExpress.Core.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecExpress.Core
{
    /// <summary>
    /// Container for Specifications backed by an IList of Specifications
    /// </summary>
    public class SpecificationContainer
    {
        private List<ISpecificationBase> _registry = new List<ISpecificationBase>();

        public void Add<TEntity>(ISpecificatonBase<TEntity> expression)
        {
            Add((ISpecificationBase)expression);
        }

        public void Add(ISpecificationBase spec)
        {
            if (spec != null)
            {
                _registry.Add(spec);
            }
        }

        public void AddRange(IEnumerable<ISpecificationBase> specs)
        {
            if (specs != null)
            {
                _registry.AddRange(specs);
            }
        }

        public void Reset()
        {
            _registry.Clear();
        }

    }
}
