﻿using System.Collections.Generic;

namespace Papu.Entities
{
    public class Wednesday
    {
        public int Id { get; set; }


        //Produkty przypisane do środy
        public virtual List<Product> Products { get; set; }

        //Dania przypisane do środy
        public virtual List<Dish> Dishes { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
