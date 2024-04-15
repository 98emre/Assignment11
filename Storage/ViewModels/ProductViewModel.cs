using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
