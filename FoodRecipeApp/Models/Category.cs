using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FoodRecipeApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
