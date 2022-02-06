using System;

namespace TamagotchiAPI.Models
{
    public class Feeding
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.Now.Date;

        // Foreign Key
        public int PetId { get; set; }

        public Pet Pet { get; set; }
    }
}
