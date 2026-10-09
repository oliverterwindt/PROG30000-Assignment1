using System.ComponentModel.DataAnnotations;

namespace Terwindt_Oliver_Assignment_1_PROG.Models
{
    public class EquipmentRequest
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public String Email { get; set; } = "";

        //Phone number must be in the format xxx-xxx-xxxx
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone must be in the format xxx-xxx-xxxx")]
        public String PhoneNumber { get; set; } = "";

        //Nullabke so [Rewuired] fails when no option is selected from he dropdown
        [Required]
        [Display(Name = "Role")]
        public UserRole? Role { get; set; }

        [Required]
        [Display(Name = "Equipment Type")]
        public EquipmentType? EquipmentType { get; set; }

        //Duration must be between 1 to 365 days
        [Required]
        [Range(1, 365, ErrorMessage = "Duration must be at least 1 day and max 365 days")]
        [Display(Name = "Duration (in days)")]
        public int Duration { get; set; }

        [Required]
        [Display(Name = "Request Details")]
        public string RequestDetails { get; set; } = "";

    }

}
