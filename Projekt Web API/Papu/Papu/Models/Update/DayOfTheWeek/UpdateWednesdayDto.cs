namespace Papu.Models.Update.DayOfTheWeek
{
    public class UpdateWednesdayDto
    {
        //Śniadanie wchodzące w skład środy
        public int BreakfastWednesdayId { get; set; }

        //Drugie śniadanie wchodzące w skład środy
        public int SecondBreakfastWednesdayId { get; set; }

        //Obiad wchodzący w skład środy
        public int LunchWednesdayId { get; set; }

        //Podwieczorek wchodzący w skład środy
        public int SnackWednesdayId { get; set; }

        //Kolacja wchodząca w skład środy
        public int DinnerWednesdayId { get; set; }
    }
}
