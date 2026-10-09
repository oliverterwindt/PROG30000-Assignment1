namespace Terwindt_Oliver_Assignment_1_PROG.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public String Description { get; set; } = "";
        public EquipmentType Type { get; set; }
        public Boolean IsAvailable { get; set; }
    }
}
