using System;
using System.ComponentModel.DataAnnotations;


namespace trains.Models
{
    public class Train
    {
        public string Id { get; set; }
        public Train(string name, int price, string description)
        {
            Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Price = price;
            this.Description = description;

        }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public string Description { get; set; }
    }
}