using Kendo.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class KendoUtilities
    {
        public IEnumerable<FilterDescriptor> GetAllFilter(IFilterDescriptor Descriptor)
        {
            List<FilterDescriptor> filterDescriptors = new List<FilterDescriptor>();

            if (Descriptor is null) return filterDescriptors;

            string typeName = Descriptor.GetType().Name;

            if (typeName == nameof(FilterDescriptor))
            {
                filterDescriptors.Add((FilterDescriptor)Descriptor);
            }
            else if (typeName == nameof(CompositeFilterDescriptor))
            {
                foreach (var item in ((CompositeFilterDescriptor)Descriptor).FilterDescriptors)
                {
                    typeName = item.GetType().Name;

                    if (typeName == nameof(FilterDescriptor))
                    {
                        filterDescriptors.Add((FilterDescriptor)item);
                    }
                    else if (typeName == nameof(CompositeFilterDescriptor))
                    {
                        filterDescriptors.AddRange(GetAllFilter((CompositeFilterDescriptor)item));
                    }
                }
            }

            return filterDescriptors;
        }
    }
}
