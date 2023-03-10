using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public static class TypeEngines
    {
        public class OrderedByHorsepower : Specification<TypeEngine>
        {
            public OrderedByHorsepower()
            {
                Query
                    .OrderBy(te => te.Name);
            }
        }
        public class ById : Specification<TypeEngine>
        {
            public ById(int id)
            {
                Query
                    .Where(te => te.Id == id);
            }
        }
    }
}
