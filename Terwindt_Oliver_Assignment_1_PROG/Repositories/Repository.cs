using Terwindt_Oliver_Assignment_1_PROG.Models;

namespace Terwindt_Oliver_Assignment_1_PROG.Repositories
{
    public class Repository
    {
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

        public static List<EquipmentRequest> Requests = new List<EquipmentRequest>();

        // Static counter for auto-incrementing request Ids
        private static int nextId = 1;

        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = nextId;
            nextId++;
            Requests.Add(request);
        }
    }
}
