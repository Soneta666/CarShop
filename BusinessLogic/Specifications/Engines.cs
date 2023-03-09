﻿using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public static class Engines
    {
        public class OrderedByVolume : Specification<Engine>
        {
            public OrderedByVolume()
            {
                Query
                    .OrderBy(e => e.Volume)
                    .Include(e => e.TypeEngine);
            }
        }
        public class OrderedByHorsepower : Specification<Engine>
        {
            public OrderedByHorsepower()
            {
                Query
                    .OrderBy(e => e.Horsepower)
                    .Include(e => e.TypeEngine);
            }
        }
        public class ById : Specification<Engine>
        {
            public ById(int id)
            {
                Query
                    .Where(e => e.Id == id)
                    .Include(e => e.TypeEngine);
            }
        }
    }
}
