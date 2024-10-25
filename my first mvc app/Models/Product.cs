namespace my_first_mvc_app.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot be longer than 50 characters")]
        public string Category { get; set; }

        [StringLength(20, ErrorMessage = "Shelf cannot be longer than 20 characters")]
        public string Shelf { get; set; }

        [Range(0, 1000, ErrorMessage = "Count must be between 0 and 1000")]
        public int Count { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string Description { get; set; }
    }

}
