using Microsoft.AspNetCore.Mvc;
using Terwindt_Oliver_Assignment_1_PROG.Repositories;

namespace Terwindt_Oliver_Assignment_1_PROG.Controllers
{
    public class EquipmentController : Controller
    {
        [Route("AllEquipment")]
        public IActionResult AllEquipment()
        {
            var equipmentList = Repository.EquipmentList;
            return View("Equipments", equipmentList);
        }

        [Route("AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            var availableEquipment = Repository.EquipmentList.Where(e => e.IsAvailable).ToList();
            return View("Equipments", availableEquipment);
        }
    }
}
