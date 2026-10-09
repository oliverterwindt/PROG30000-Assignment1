namespace Terwindt_Oliver_Assignment_1_PROG.Models
{
    // Represents a piece of equipment that can be requested by users.
    public class Equipment
    {
        public int Id { get; set; }
        public String Description { get; set; } = "";
        public EquipmentType Type { get; set; }
        public Boolean IsAvailable { get; set; }
    }
}
