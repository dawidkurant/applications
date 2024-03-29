﻿using System.Collections.Generic;

namespace Papu.Entities
{
    public class SecondBreakfast : TimesOfDay
    {
        //Podstawowe informacje dotyczące drugiego śniadania

        //Id drugiego śniadania
        public int SecondBreakfastId { get; set; }

        //Produkty wchodzące w skład drugiego śniadania
        public virtual ICollection<SecondBreakfastProduct> Products { get; set; }

        //Potrawy wchodzące w skład drugiego śniadania
        public virtual ICollection<SecondBreakfastDish> Dishes { get; set; }
    }
}
