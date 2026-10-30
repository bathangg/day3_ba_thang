using System.ComponentModel.DataAnnotations;

namespace day3_ba_thang.Models
{
    public class category
    {
        [Required(ErrorMessage = "Id is required")]

    public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên danh")]
   
    public string Name { get; set; } = string.Empty;

        //Navigation property to Products
public List<product>? products { get; set; }
    }
}
