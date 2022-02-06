using System;

namespace TamagotchiAPI.Models
{
    public class Scolding
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.Now.Date;


        // public void WhenDateOnly()
        // {
        //     string dateOnly = When.ToShortDateString();
        // }

        // Foreign Key
        public int PetId { get; set; }

        public Pet Pet { get; set; }
    }
}
