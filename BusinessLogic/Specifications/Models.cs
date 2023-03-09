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
    public static class Models
    {
        public class OrderedByName : Specification<Model>
        {
            public OrderedByName()
            {
                Query
                    .OrderBy(m => m.Name)
                    .Include(m => m.Year);
            }
        }
        public class OrderedByYear : Specification<Model>
        {
            public OrderedByYear()
            {
                Query
                    .Include(m => m.Year)
                    .OrderBy(m => m.Year.Date);
            }
        }
        public class ById : Specification<Model>
        {
            public ById(int id)
            {
                Query
                    .Where(m => m.Id == id)
                    .Include(m => m.Year);
            }
        }
    }
}
