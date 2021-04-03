using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Bookinist.DAL.Entityes.Base;

namespace Bookinist.DAL.Entityes
{
    public class Deal : Entity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Buyer Buyer { get; set; }

    }
}