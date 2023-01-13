
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TransactionEntity
{
    [Key]
    public int Id { get; set; }

    public List<OrderEntity> Orderlist { get; set; } //Why is this here? Isn't there only one Order per Transaction?

    [Required]
    public string PaymentMethod { get; set; }

    public DateTime DateOfTransaction { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }

    public CustomerEntity Customer { get; set; }

    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }

    public OrderEntity Order { get; set; }
}
