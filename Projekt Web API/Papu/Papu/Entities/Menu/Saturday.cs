﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papu.Entities
{
    public class Saturday
    {
        public int SaturdayId { get; set; }


        //Produkty przypisane do soboty
        public virtual List<Product> SaturdayProducts { get; set; }

        //Dania przypisane do soboty
        public virtual List<Dish> SaturdayDishes { get; set; }
    }
}
