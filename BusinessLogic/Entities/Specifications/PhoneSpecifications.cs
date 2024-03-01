using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Entities.Specifications
{
    internal static class Phones
    {
        public class AllWithCateg : Specification<Phone>
        {
            public AllWithCateg()
            {
                Query.Include(p => p.Category);
            }
        }
        public class AllWithPrice : Specification<Phone>
        {
            public AllWithPrice(double from, double to)
            {
                Query
                    .Where(p => from <= p.Price && p.Price <= to)
                    .Include(p => p.Category);
            }
        }
    }
}
