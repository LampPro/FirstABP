using Abp.Domain.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.ValueObjects
{
    public class Address : ValueObject<Address>
    {
        [StringLength(10)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string County { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string Street { get; set; }
    }
}
