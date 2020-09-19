using System;
using System.Collections.Generic;
using System.Text;

namespace AmazoneShowProduct.Models
{
   public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
