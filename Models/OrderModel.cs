﻿namespace APIFurnitureStore.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    [Table("order")]
    public class OrderModel
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("order_number")]
        public int OrderNumber { get; set; }

        [Column("client_id")]
        public int ClientId { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("delivery_date")]
        public DateTime DeliveryDate { get; set; }

        // Many to One: Client
        [JsonIgnore]
        public virtual ClientModel? Client { get; set; }

        // Many to Many: OrderDetail
        public virtual ICollection<OrderDetailModel>? OrderDetails { get; set; }
    }
}
