using System.ComponentModel.DataAnnotations;

namespace Papu.Models
{
    public class CreateSecondBreakfastDto
    {
        //Produkty wchodzące w skład drugiego śniadania
        public int[] ProductId { get; set; }

        //Dania wchodzące w skład drugiego śniadania
        public int[] DishId { get; set; }
    }
}
