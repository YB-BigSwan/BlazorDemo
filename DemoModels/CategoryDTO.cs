using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.DemoModels
{
    public class CategoryDTO
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }
    }
}

