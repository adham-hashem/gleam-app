using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(80)]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = string.Empty;

        public Guid OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Guid? PaymentId { get; set; }
        public Payment Payment { get; set; }

        public Guid? RefundId { get; set; }
        public Refund Refund { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
