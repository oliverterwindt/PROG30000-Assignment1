using Terwindt_Oliver_Assignment_1_PROG.Models;

namespace Terwindt_Oliver_Assignment_1_PROG.Repositories
{
    // Represents a repository that holds the equipment and requests data in memory.
    public class Repository
    {
        // Static list of equipment available in the system.
        public static List<Equipment> EquipmentList = new List<Equipment>()
        {
            new Equipment() {Id=1, Description="Dell Laptop", Type=EquipmentType.Laptop, IsAvailable=true},
            new Equipment() {Id=2, Description="MacBook Laptop", Type=EquipmentType.Laptop, IsAvailable=true},
            new Equipment() {Id=3, Description="Windows Tablet", Type=EquipmentType.Tablet, IsAvailable=false},
            new Equipment() {Id=4, Description="i-Pad mini", Type=EquipmentType.Tablet, IsAvailable=true},
            new Equipment() {Id=5, Description="Iphone 18 Pro Max", Type=EquipmentType.Phone, IsAvailable=true},
            new Equipment() {Id=6, Description="Sony Camera", Type=EquipmentType.Another, IsAvailable=true},
            new Equipment() {Id=7, Description="Mini Projector", Type=EquipmentType.Another, IsAvailable=false},
            new Equipment() {Id=8, Description="Android Phone", Type=EquipmentType.Phone, IsAvailable=true},
        };

        // Requests submitted through the request form
        public static List<EquipmentRequest> Requests = new List<EquipmentRequest>();

        // Static counter for auto-incrementing request Ids
        private static int nextId = 1;

        // Saves a new equipment request to the repository and assigns it a unique Id.
        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = nextId;
            nextId++;
            Requests.Add(request);
        }
    }
}
