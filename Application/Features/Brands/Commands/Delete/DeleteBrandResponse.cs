using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Delete
{
    internal class DeleteBrandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime DeletedDate { get; set; }
     }
}
