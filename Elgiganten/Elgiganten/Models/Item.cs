﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Elgiganten.Models
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item()
        {
        }

        public Item(int id, string name, string brand, string description, double price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
        }
    }
}