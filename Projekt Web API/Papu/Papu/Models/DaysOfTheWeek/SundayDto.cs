using System.Collections.Generic;

namespace Papu.Models
{
    public class SundayDto
    {
        //Podstawowe informacje dotyczące niedzieli dostępne dla klienta

        //Id soboty
        public int SundayId { get; set; }

        //Śniadanie wchodzące w skład niedzieli
        //Podstawowe informacje dotyczące śniadania

        //Id śniadania
        public int BreakfastSundayId { get; set; }

        //Produkty wchodzące w skład śniadania
        public virtual ICollection<ProductDto> BreakfastProducts { get; set; }

        //Potrawy wchodzące w skład śniadania
        public virtual ICollection<DishDto> BreakfastDishes { get; set; }

        //Drugie śniadanie wchodzące w skład niedzieli
        //Podstawowe informacje dotyczące drugiego śniadania

        //Id drugiego śniadania
        public int SecondBreakfastSundayId { get; set; }

        //Produkty wchodzące w skład drugiego śniadania
        public virtual ICollection<ProductDto> SecondBreakfastProducts { get; set; }

        //Potrawy wchodzące w skład drugiego śniadania
        public virtual ICollection<DishDto> SecondBreakfastDishes { get; set; }

        //Obiad wchodzący w skład niedzieli
        //Podstawowe informacje dotyczące obiadu

        //Id obiadu
        public int LunchSundayId { get; set; }

        //Produkty wchodzące w skład obiadu
        public virtual ICollection<ProductDto> LunchProducts { get; set; }

        //Potrawy wchodzące w skład obiadu
        public virtual ICollection<DishDto> LunchDishes { get; set; }

        //Podwieczorek wchodzący w skład niedzieli
        //Podstawowe informacje dotyczące podwieczorka

        //Id podwieczorka
        public int SnackSundayId { get; set; }

        //Produkty wchodzące w skład podwieczorka
        public virtual ICollection<ProductDto> SnackProducts { get; set; }

        //Potrawy wchodzące w skład podwieczorka
        public virtual ICollection<DishDto> SnackDishes { get; set; }

        ///Kolacja wchodząca w skład niedzieli
        //Podstawowe informacje dotyczące kolacji

        //Id kolacji
        public int DinnerSundayId { get; set; }

        //Produkty wchodzące w skład kolacji
        public virtual ICollection<ProductDto> DinnerProducts { get; set; }

        //Potrawy wchodzące w skład kolacji
        public virtual ICollection<DishDto> DinnerDishes { get; set; }
    }
}
