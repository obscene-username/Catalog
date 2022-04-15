using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public class UpdateItemDTO
    {
        [Required]
        public string Name {get; init;}

        [Required]
        [Range(1,9999)]
        public decimal Price { get; init;}
    }
}