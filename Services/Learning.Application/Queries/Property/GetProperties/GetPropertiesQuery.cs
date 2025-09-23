using BuildingBlocks.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.Queries.Property.GetProperties
{
    public class GetPropertiesQuery : IQuery<GetPropertiesResult>
    {

    }

    public class GetPropertiesResult
    {
        public IEnumerable<Domain.Models.Property> Properties { get; set; } = default!;
    }
}
