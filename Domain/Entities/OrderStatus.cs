using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderStatus
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
