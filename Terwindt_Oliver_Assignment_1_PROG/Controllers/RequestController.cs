using Microsoft.AspNetCore.Mvc;
using Terwindt_Oliver_Assignment_1_PROG.Models;
using Terwindt_Oliver_Assignment_1_PROG.Repositories;

namespace Terwindt_Oliver_Assignment_1_PROG.Controllers
{
    public class RequestController : Controller
    {
        [Route("RequestForm")]
        public IActionResult RequestForm()
        {
            return View(); //views/request/RequestForm.cshtml
        }

        // POST: /RequestForm - handles the submitted form
        [HttpPost]
        [Route("RequestForm")]
        public IActionResult RequestForm(EquipmentRequest request)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(request);
                return View("RequestConfirmation", request);   // Views/Request/Confirmation.cshtml
            }

            // Validation failed: show the form again with the user's data and errors
            return View("RequestForm", request);
        }
    }
}
