using Terwindt_Oliver_Assignment_1_PROG.Models;

namespace Terwindt_Oliver_Assignment_1_PROG.Repositories
{
    public class Repository
    {
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
