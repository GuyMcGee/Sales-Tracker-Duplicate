
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TransactionEntity
{
    [Key]
    public int Id { get; set; }

    public List<OrderEntity> Orderlist { get; set; }

    [Required]
    public string PaymentMethod { get; set; }

    public DateTime DateOfTransaction { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; }


    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }
    public OrderEntity Order { get; set; }


    //this is coming from line 25....
    public Decimal GrandTotal
    {
        get
        {
            var grandTotal = Order.ItemsInCart.Sum(i => i.Cost);
            return grandTotal;
        }
    }
}
