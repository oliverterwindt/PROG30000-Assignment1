using Microsoft.AspNetCore.Mvc;
using Terwindt_Oliver_Assignment_1_PROG.Repositories;

namespace Terwindt_Oliver_Assignment_1_PROG.Controllers
{
    //Handles the equipment listing pages
    public class EquipmentController : Controller
    {
        // GET: /AllEquipment - shows all equipment
        [Route("AllEquipment")]
        public IActionResult AllEquipment()
        {
            var equipmentList = Repository.EquipmentList;
            return View("Equipments", equipmentList);
        }

        //GET: /AvailableEquipment - shows only available equipment
        [Route("AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            // Filter the equipment list to only include available equipment
            var availableEquipment = Repository.EquipmentList.Where(e => e.IsAvailable).ToList();
            return View("Equipments", availableEquipment);
        }
    }
}
