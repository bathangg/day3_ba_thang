namespace day3_ba_thang.Models
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int categoryID {  get; set; }
        public category? category { get; set; } 
    }
}
